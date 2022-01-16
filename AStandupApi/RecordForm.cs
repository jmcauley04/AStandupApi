using AStandupApi.Controllers;
using AStandupApi.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStandupApi
{
    public partial class RecordForm : Form
    {
        Point mousedownpoint = Point.Empty;

        public RecordForm()
        {
            InitializeComponent();

            btnCancel.Click += (s, e) => Application.Exit();
            btnSubmit.Click += async (s, e) => await SubmitText();
            btnMeetingMode.Click += (s, e) => OpenMeetingMode();

            lblHeader.MouseDown += lbl_MouseDown;
            lblHeader.MouseMove += lbl_MouseMove;
            lblHeader.MouseUp += lbl_MouseUp;

            Load += RecordForm_Load;
        }

        private void RecordForm_Load(object? sender, EventArgs e)
        {
            if (!Directory.Exists(LoggingContext.AppFolder))
                Directory.CreateDirectory(LoggingContext.AppFolder);

            var context = new LoggingContext();
            context.Database.Migrate();
        }

        private void OpenMeetingMode()
        {
            MeetingForm meetingForm = new MeetingForm();
            meetingForm.Show();
            this.Hide();
        }

        private async Task SubmitText()
        {
            var logController = new LogController();
            await logController.SaveActivity(textBox1.Text);
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
