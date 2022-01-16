namespace AStandupApi
{
    partial class MeetingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTimestamps = new System.Windows.Forms.DataGridView();
            this.lblDgv = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtbNotes_old = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOldNotesDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotes_old = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnEndMeeting = new System.Windows.Forms.Button();
            this.btnCancelMeeting = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDbLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimestamps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTimestamps);
            this.splitContainer1.Panel1.Controls.Add(this.lblDgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1261, 672);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvTimestamps
            // 
            this.dgvTimestamps.AllowUserToAddRows = false;
            this.dgvTimestamps.AllowUserToDeleteRows = false;
            this.dgvTimestamps.AllowUserToResizeColumns = false;
            this.dgvTimestamps.AllowUserToResizeRows = false;
            this.dgvTimestamps.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvTimestamps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimestamps.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvTimestamps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimestamps.Location = new System.Drawing.Point(0, 30);
            this.dgvTimestamps.Name = "dgvTimestamps";
            this.dgvTimestamps.ReadOnly = true;
            this.dgvTimestamps.RowHeadersVisible = false;
            this.dgvTimestamps.RowTemplate.Height = 25;
            this.dgvTimestamps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimestamps.Size = new System.Drawing.Size(400, 642);
            this.dgvTimestamps.TabIndex = 0;
            // 
            // lblDgv
            // 
            this.lblDgv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDgv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDgv.Location = new System.Drawing.Point(0, 0);
            this.lblDgv.Name = "lblDgv";
            this.lblDgv.Size = new System.Drawing.Size(400, 30);
            this.lblDgv.TabIndex = 1;
            this.lblDgv.Text = "Activity Log";
            this.lblDgv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rtbNotes_old);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbNotes);
            this.splitContainer2.Panel2.Controls.Add(this.lblNotes);
            this.splitContainer2.Size = new System.Drawing.Size(857, 672);
            this.splitContainer2.SplitterDistance = 303;
            this.splitContainer2.TabIndex = 0;
            // 
            // rtbNotes_old
            // 
            this.rtbNotes_old.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbNotes_old.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotes_old.Location = new System.Drawing.Point(0, 30);
            this.rtbNotes_old.Name = "rtbNotes_old";
            this.rtbNotes_old.ReadOnly = true;
            this.rtbNotes_old.Size = new System.Drawing.Size(857, 273);
            this.rtbNotes_old.TabIndex = 2;
            this.rtbNotes_old.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbOldNotesDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNotes_old);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 30);
            this.panel1.TabIndex = 3;
            // 
            // cbOldNotesDate
            // 
            this.cbOldNotesDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOldNotesDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOldNotesDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOldNotesDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbOldNotesDate.FormattingEnabled = true;
            this.cbOldNotesDate.Location = new System.Drawing.Point(607, 3);
            this.cbOldNotesDate.Name = "cbOldNotesDate";
            this.cbOldNotesDate.Size = new System.Drawing.Size(238, 25);
            this.cbOldNotesDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(551, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNotes_old
            // 
            this.lblNotes_old.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNotes_old.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNotes_old.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes_old.Location = new System.Drawing.Point(0, 0);
            this.lblNotes_old.Name = "lblNotes_old";
            this.lblNotes_old.Size = new System.Drawing.Size(350, 30);
            this.lblNotes_old.TabIndex = 0;
            this.lblNotes_old.Text = "label2";
            this.lblNotes_old.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotes.Location = new System.Drawing.Point(0, 15);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(857, 350);
            this.rtbNotes.TabIndex = 1;
            this.rtbNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.Location = new System.Drawing.Point(0, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(857, 15);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "label3";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(99, 16);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "A STANDUP API";
            // 
            // btnEndMeeting
            // 
            this.btnEndMeeting.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEndMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndMeeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEndMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndMeeting.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEndMeeting.ForeColor = System.Drawing.Color.White;
            this.btnEndMeeting.Location = new System.Drawing.Point(0, 0);
            this.btnEndMeeting.Name = "btnEndMeeting";
            this.btnEndMeeting.Size = new System.Drawing.Size(1011, 31);
            this.btnEndMeeting.TabIndex = 2;
            this.btnEndMeeting.UseVisualStyleBackColor = false;
            // 
            // btnCancelMeeting
            // 
            this.btnCancelMeeting.AutoSize = true;
            this.btnCancelMeeting.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelMeeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMeeting.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelMeeting.ForeColor = System.Drawing.Color.White;
            this.btnCancelMeeting.Location = new System.Drawing.Point(0, 0);
            this.btnCancelMeeting.Name = "btnCancelMeeting";
            this.btnCancelMeeting.Size = new System.Drawing.Size(246, 31);
            this.btnCancelMeeting.TabIndex = 3;
            this.btnCancelMeeting.Text = "Cancel Meeting";
            this.btnCancelMeeting.UseVisualStyleBackColor = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 688);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnCancelMeeting);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnEndMeeting);
            this.splitContainer3.Size = new System.Drawing.Size(1261, 31);
            this.splitContainer3.SplitterDistance = 246;
            this.splitContainer3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.lblDbLocation);
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 16);
            this.panel2.TabIndex = 7;
            // 
            // lblDbLocation
            // 
            this.lblDbLocation.AutoSize = true;
            this.lblDbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblDbLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbLocation.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDbLocation.ForeColor = System.Drawing.Color.White;
            this.lblDbLocation.Location = new System.Drawing.Point(1212, 0);
            this.lblDbLocation.Name = "lblDbLocation";
            this.lblDbLocation.Size = new System.Drawing.Size(49, 16);
            this.lblDbLocation.TabIndex = 2;
            this.lblDbLocation.Text = "label2";
            // 
            // MeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 719);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Standup API";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimestamps)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DataGridView dgvTimestamps;
        private Label lblDgv;
        private RichTextBox rtbNotes_old;
        private Label lblNotes_old;
        private RichTextBox rtbNotes;
        private Label lblNotes;
        private Label lblHeader;
        private Button btnEndMeeting;
        private Button btnCancelMeeting;
        private SplitContainer splitContainer3;
        private ComboBox cbOldNotesDate;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblDbLocation;
    }
}