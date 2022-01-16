using AStandupApi.Controllers;
using AStandupApi.Data.Models;
using System.Timers;

namespace AStandupApi
{
    public partial class MeetingForm : Form
    {
        Point mousedownpoint = Point.Empty;
        System.Timers.Timer timer;
        DateTime startTime;
        List<MeetingNote> meetingNotes = new();
        DateTime earliestLoadTarget = DateTime.Now.AddDays(1);
        bool allNotesLoaded = false;

        string EndMeetingLabelText(string timeMsg) => $"End Meeting ({timeMsg})";
        string MeetingNotesLabelText(DateTime datetime) => $"Meeting Notes ({datetime})";

        public MeetingForm()
        {
            InitializeComponent();

            lblDbLocation.Text = $"SQLite DB: {Data.Contexts.LoggingContext.DbPath}";

            btnEndMeeting.Text = EndMeetingLabelText("just started...");
            startTime = DateTime.Now;

            timer = new System.Timers.Timer(6000);
            timer.Elapsed += UpdateEndMeetingLabel;
            timer.Start();

            btnCancelMeeting.Click += (s, e) => Application.Exit();
            btnEndMeeting.Click += async (s, e) => await EndMeeting();

            lblHeader.MouseDown += lbl_MouseDown;
            lblHeader.MouseMove += lbl_MouseMove;
            lblHeader.MouseUp += lbl_MouseUp;

            dgvTimestamps.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn(){Name="Id", HeaderText="Id", DataPropertyName="Id", AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells },
                new DataGridViewTextBoxColumn(){Name="LogTime", HeaderText="LogTime", DataPropertyName="LogTime", AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells },
                new DataGridViewTextBoxColumn(){Name="Note", HeaderText="Note", DataPropertyName="Note", AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill }
            });

            dgvTimestamps.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTimestamps.Columns["LogTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTimestamps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTimestamps.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            cbOldNotesDate.DisplayMember = nameof(MeetingNote.MeetingDate);
            cbOldNotesDate.ValueMember = nameof(MeetingNote.Id);
            cbOldNotesDate.SelectedIndexChanged += async (s, e) => await SelectOldNotes();

            lblNotes.Text = MeetingNotesLabelText(DateTime.Now);

            Load += async (s, e) => await PopulateHistory();
        }

        private async Task SelectOldNotes()
        {
            var selectedNote = (MeetingNote)cbOldNotesDate.SelectedItem;
            rtbNotes_old.Rtf = selectedNote.Notes;
            lblNotes_old.Text = MeetingNotesLabelText(selectedNote.MeetingDate);

            await TryLoadMoreOldNotes(selectedNote.MeetingDate);
        }

        private async Task TryLoadMoreOldNotes(DateTime targetDate)
        {
            if (allNotesLoaded || targetDate >= earliestLoadTarget)
                return;

            earliestLoadTarget = targetDate;

            var prevNoteCount = meetingNotes.Count;

            var logController = new LogController();
            meetingNotes = (await logController.GetLastNotes(targetDate)).ToList();

            if (meetingNotes.Count() > 0)
            {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = meetingNotes;

                int? selectedId = null;

                if (cbOldNotesDate.Items.Count > 0)
                    selectedId = ((MeetingNote)cbOldNotesDate.SelectedItem).Id;

                cbOldNotesDate.DataSource = bindingSource;

                if (selectedId is not null)
                    cbOldNotesDate.SelectedValue = selectedId;
            }

            if (meetingNotes.Count == prevNoteCount)
                allNotesLoaded = true;
        }

        private async Task PopulateHistory()
        {
            var logController = new LogController();
            var activityLog = await logController.GetLogYesterday();

            dgvTimestamps.DataSource = activityLog;

            await TryLoadMoreOldNotes(DateTime.Now);
        }

        private void UpdateEndMeetingLabel(object? sender, ElapsedEventArgs e)
        {
            var span = DateTime.Now - startTime;
            Invoke(() => btnEndMeeting.Text = EndMeetingLabelText($"{(int)span.TotalMinutes} mins"));
        }

        private async Task EndMeeting()
        {
            var span = DateTime.Now - startTime;
            var logController = new LogController();

            await logController.SaveNotes(rtbNotes.Rtf, (int)span.TotalMinutes);

            Application.Exit();
        }


        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {

            if (mousedownpoint.IsEmpty)
                return;
            Location = new Point(Location.X + (e.X - mousedownpoint.X), Location.Y + (e.Y - mousedownpoint.Y));

        }

        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }
    }
}