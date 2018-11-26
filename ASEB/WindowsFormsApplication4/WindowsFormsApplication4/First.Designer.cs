namespace WindowsFormsApplication4
{
    partial class First
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GrpH = new System.Windows.Forms.GroupBox();
            this.lblinterval = new System.Windows.Forms.Label();
            this.lblsmode = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbllength = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.lblmonitor = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.DataTrue = new System.Windows.Forms.DataGridView();
            this.time_interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heart_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitudes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power_watt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pending_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.left_right_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.GroupBox();
            this.lbl_Avg_Altitude = new System.Windows.Forms.Label();
            this.lbl_Min_Altitude = new System.Windows.Forms.Label();
            this.lbl_Max_Altitude = new System.Windows.Forms.Label();
            this.lbl_Avg_Power = new System.Windows.Forms.Label();
            this.lbl_Min_Power = new System.Windows.Forms.Label();
            this.lbl_Max_Power = new System.Windows.Forms.Label();
            this.lbl_Avg_Speed = new System.Windows.Forms.Label();
            this.lbl_Min_Speed = new System.Windows.Forms.Label();
            this.lbl_Max_Speed = new System.Windows.Forms.Label();
            this.lbl_Avg_Heart = new System.Windows.Forms.Label();
            this.lbl_Min_Heart = new System.Windows.Forms.Label();
            this.lbl_Max_Heart = new System.Windows.Forms.Label();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.GrpH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTrue)).BeginInit();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 199);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // GrpH
            // 
            this.GrpH.Controls.Add(this.lblinterval);
            this.GrpH.Controls.Add(this.lblsmode);
            this.GrpH.Controls.Add(this.lbldate);
            this.GrpH.Controls.Add(this.lbllength);
            this.GrpH.Controls.Add(this.lblstartdate);
            this.GrpH.Controls.Add(this.lblmonitor);
            this.GrpH.Controls.Add(this.lblversion);
            this.GrpH.Location = new System.Drawing.Point(111, 28);
            this.GrpH.Name = "GrpH";
            this.GrpH.Size = new System.Drawing.Size(200, 199);
            this.GrpH.TabIndex = 2;
            this.GrpH.TabStop = false;
            this.GrpH.Text = "Header: ";
            // 
            // lblinterval
            // 
            this.lblinterval.AutoSize = true;
            this.lblinterval.Location = new System.Drawing.Point(6, 99);
            this.lblinterval.Name = "lblinterval";
            this.lblinterval.Size = new System.Drawing.Size(42, 13);
            this.lblinterval.TabIndex = 7;
            this.lblinterval.Text = "Interval";
            // 
            // lblsmode
            // 
            this.lblsmode.AutoSize = true;
            this.lblsmode.Location = new System.Drawing.Point(6, 86);
            this.lblsmode.Name = "lblsmode";
            this.lblsmode.Size = new System.Drawing.Size(40, 13);
            this.lblsmode.TabIndex = 6;
            this.lblsmode.Text = "Smode";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(6, 73);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 5;
            this.lbldate.Text = "Date";
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Location = new System.Drawing.Point(8, 60);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(40, 13);
            this.lbllength.TabIndex = 4;
            this.lbllength.Text = "Length";
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Location = new System.Drawing.Point(6, 47);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(52, 13);
            this.lblstartdate.TabIndex = 3;
            this.lblstartdate.Text = "StartDate";
            // 
            // lblmonitor
            // 
            this.lblmonitor.AutoSize = true;
            this.lblmonitor.Location = new System.Drawing.Point(6, 34);
            this.lblmonitor.Name = "lblmonitor";
            this.lblmonitor.Size = new System.Drawing.Size(42, 13);
            this.lblmonitor.TabIndex = 2;
            this.lblmonitor.Text = "Monitor";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(6, 21);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(42, 13);
            this.lblversion.TabIndex = 1;
            this.lblversion.Text = "Version";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(323, 33);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 3;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // DataTrue
            // 
            this.DataTrue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTrue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time_interval,
            this.heart_rate,
            this.speeds,
            this.cadences,
            this.altitudes,
            this.Power_watt,
            this.power_balance,
            this.pending_index,
            this.left_right_balance});
            this.DataTrue.Location = new System.Drawing.Point(13, 234);
            this.DataTrue.Name = "DataTrue";
            this.DataTrue.Size = new System.Drawing.Size(537, 150);
            this.DataTrue.TabIndex = 4;
            // 
            // time_interval
            // 
            this.time_interval.HeaderText = "Time Interval (sec)";
            this.time_interval.Name = "time_interval";
            // 
            // heart_rate
            // 
            this.heart_rate.HeaderText = "HeartRate (Bpm)";
            this.heart_rate.Name = "heart_rate";
            // 
            // speeds
            // 
            this.speeds.HeaderText = "Speed ()";
            this.speeds.Name = "speeds";
            // 
            // cadences
            // 
            this.cadences.HeaderText = "Cadence (Rpm)";
            this.cadences.Name = "cadences";
            // 
            // altitudes
            // 
            this.altitudes.HeaderText = "Altitude ()";
            this.altitudes.Name = "altitudes";
            // 
            // Power_watt
            // 
            this.Power_watt.HeaderText = "Power (Watt)";
            this.Power_watt.Name = "Power_watt";
            // 
            // power_balance
            // 
            this.power_balance.HeaderText = "Power Balance";
            this.power_balance.Name = "power_balance";
            // 
            // pending_index
            // 
            this.pending_index.HeaderText = "Power Index";
            this.pending_index.Name = "pending_index";
            // 
            // left_right_balance
            // 
            this.left_right_balance.HeaderText = "Left Right Balance";
            this.left_right_balance.Name = "left_right_balance";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Controls.Add(this.lbl_Avg_Altitude);
            this.Data.Controls.Add(this.lbl_Min_Altitude);
            this.Data.Controls.Add(this.lbl_Max_Altitude);
            this.Data.Controls.Add(this.lbl_Avg_Power);
            this.Data.Controls.Add(this.lbl_Min_Power);
            this.Data.Controls.Add(this.lbl_Max_Power);
            this.Data.Controls.Add(this.lbl_Avg_Speed);
            this.Data.Controls.Add(this.lbl_Min_Speed);
            this.Data.Controls.Add(this.lbl_Max_Speed);
            this.Data.Controls.Add(this.lbl_Avg_Heart);
            this.Data.Controls.Add(this.lbl_Min_Heart);
            this.Data.Controls.Add(this.lbl_Max_Heart);
            this.Data.Location = new System.Drawing.Point(563, 33);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(300, 277);
            this.Data.TabIndex = 5;
            this.Data.TabStop = false;
            this.Data.Text = " Summary";
            // 
            // lbl_Avg_Altitude
            // 
            this.lbl_Avg_Altitude.AutoSize = true;
            this.lbl_Avg_Altitude.Location = new System.Drawing.Point(5, 248);
            this.lbl_Avg_Altitude.Name = "lbl_Avg_Altitude";
            this.lbl_Avg_Altitude.Size = new System.Drawing.Size(88, 13);
            this.lbl_Avg_Altitude.TabIndex = 12;
            this.lbl_Avg_Altitude.Text = "Average Altitude:";
            // 
            // lbl_Min_Altitude
            // 
            this.lbl_Min_Altitude.AutoSize = true;
            this.lbl_Min_Altitude.Location = new System.Drawing.Point(3, 235);
            this.lbl_Min_Altitude.Name = "lbl_Min_Altitude";
            this.lbl_Min_Altitude.Size = new System.Drawing.Size(89, 13);
            this.lbl_Min_Altitude.TabIndex = 11;
            this.lbl_Min_Altitude.Text = "Minimum Altitude:";
            // 
            // lbl_Max_Altitude
            // 
            this.lbl_Max_Altitude.AutoSize = true;
            this.lbl_Max_Altitude.Location = new System.Drawing.Point(3, 222);
            this.lbl_Max_Altitude.Name = "lbl_Max_Altitude";
            this.lbl_Max_Altitude.Size = new System.Drawing.Size(92, 13);
            this.lbl_Max_Altitude.TabIndex = 10;
            this.lbl_Max_Altitude.Text = "Maximum Altitude:";
            // 
            // lbl_Avg_Power
            // 
            this.lbl_Avg_Power.AutoSize = true;
            this.lbl_Avg_Power.Location = new System.Drawing.Point(3, 181);
            this.lbl_Avg_Power.Name = "lbl_Avg_Power";
            this.lbl_Avg_Power.Size = new System.Drawing.Size(83, 13);
            this.lbl_Avg_Power.TabIndex = 9;
            this.lbl_Avg_Power.Text = "Average Power:";
            // 
            // lbl_Min_Power
            // 
            this.lbl_Min_Power.AutoSize = true;
            this.lbl_Min_Power.Location = new System.Drawing.Point(3, 168);
            this.lbl_Min_Power.Name = "lbl_Min_Power";
            this.lbl_Min_Power.Size = new System.Drawing.Size(84, 13);
            this.lbl_Min_Power.TabIndex = 8;
            this.lbl_Min_Power.Text = "Minimum Power:";
            // 
            // lbl_Max_Power
            // 
            this.lbl_Max_Power.AutoSize = true;
            this.lbl_Max_Power.Location = new System.Drawing.Point(3, 155);
            this.lbl_Max_Power.Name = "lbl_Max_Power";
            this.lbl_Max_Power.Size = new System.Drawing.Size(87, 13);
            this.lbl_Max_Power.TabIndex = 7;
            this.lbl_Max_Power.Text = "Maximum Power:";
            // 
            // lbl_Avg_Speed
            // 
            this.lbl_Avg_Speed.AutoSize = true;
            this.lbl_Avg_Speed.Location = new System.Drawing.Point(3, 119);
            this.lbl_Avg_Speed.Name = "lbl_Avg_Speed";
            this.lbl_Avg_Speed.Size = new System.Drawing.Size(84, 13);
            this.lbl_Avg_Speed.TabIndex = 6;
            this.lbl_Avg_Speed.Text = "Average Speed:";
            // 
            // lbl_Min_Speed
            // 
            this.lbl_Min_Speed.AutoSize = true;
            this.lbl_Min_Speed.Location = new System.Drawing.Point(2, 106);
            this.lbl_Min_Speed.Name = "lbl_Min_Speed";
            this.lbl_Min_Speed.Size = new System.Drawing.Size(85, 13);
            this.lbl_Min_Speed.TabIndex = 5;
            this.lbl_Min_Speed.Text = "Minimum Speed:";
            // 
            // lbl_Max_Speed
            // 
            this.lbl_Max_Speed.AutoSize = true;
            this.lbl_Max_Speed.Location = new System.Drawing.Point(3, 93);
            this.lbl_Max_Speed.Name = "lbl_Max_Speed";
            this.lbl_Max_Speed.Size = new System.Drawing.Size(86, 13);
            this.lbl_Max_Speed.TabIndex = 4;
            this.lbl_Max_Speed.Text = "Maximun Speed:";
            // 
            // lbl_Avg_Heart
            // 
            this.lbl_Avg_Heart.AutoSize = true;
            this.lbl_Avg_Heart.Location = new System.Drawing.Point(3, 42);
            this.lbl_Avg_Heart.Name = "lbl_Avg_Heart";
            this.lbl_Avg_Heart.Size = new System.Drawing.Size(105, 13);
            this.lbl_Avg_Heart.TabIndex = 3;
            this.lbl_Avg_Heart.Text = "Average Heart Rate:";
            // 
            // lbl_Min_Heart
            // 
            this.lbl_Min_Heart.AutoSize = true;
            this.lbl_Min_Heart.Location = new System.Drawing.Point(3, 29);
            this.lbl_Min_Heart.Name = "lbl_Min_Heart";
            this.lbl_Min_Heart.Size = new System.Drawing.Size(106, 13);
            this.lbl_Min_Heart.TabIndex = 2;
            this.lbl_Min_Heart.Text = "Minimum Heart Rate:";
            // 
            // lbl_Max_Heart
            // 
            this.lbl_Max_Heart.AutoSize = true;
            this.lbl_Max_Heart.Location = new System.Drawing.Point(3, 16);
            this.lbl_Max_Heart.Name = "lbl_Max_Heart";
            this.lbl_Max_Heart.Size = new System.Drawing.Size(109, 13);
            this.lbl_Max_Heart.TabIndex = 1;
            this.lbl_Max_Heart.Text = "Maximum Heart Rate:";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
            // 
            // First
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 343);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.DataTrue);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.GrpH);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "First";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GrpH.ResumeLayout(false);
            this.GrpH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTrue)).EndInit();
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox GrpH;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView DataTrue;
        private System.Windows.Forms.GroupBox Data;
        private System.Windows.Forms.Label lbl_Avg_Altitude;
        private System.Windows.Forms.Label lbl_Min_Altitude;
        private System.Windows.Forms.Label lbl_Max_Altitude;
        private System.Windows.Forms.Label lbl_Avg_Power;
        private System.Windows.Forms.Label lbl_Min_Power;
        private System.Windows.Forms.Label lbl_Max_Power;
        private System.Windows.Forms.Label lbl_Avg_Speed;
        private System.Windows.Forms.Label lbl_Min_Speed;
        private System.Windows.Forms.Label lbl_Max_Speed;
        private System.Windows.Forms.Label lbl_Avg_Heart;
        private System.Windows.Forms.Label lbl_Min_Heart;
        private System.Windows.Forms.Label lbl_Max_Heart;
        private System.Windows.Forms.Label lblinterval;
        private System.Windows.Forms.Label lblsmode;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbllength;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.Label lblmonitor;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn heart_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn speeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadences;
        private System.Windows.Forms.DataGridViewTextBoxColumn altitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power_watt;
        private System.Windows.Forms.DataGridViewTextBoxColumn power_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn pending_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn left_right_balance;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
    }
}