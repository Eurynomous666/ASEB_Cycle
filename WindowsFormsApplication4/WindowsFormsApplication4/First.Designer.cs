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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAir = new System.Windows.Forms.Label();
            this.lblUS = new System.Windows.Forms.Label();
            this.lblHRdata = new System.Windows.Forms.Label();
            this.lblPowerI = new System.Windows.Forms.Label();
            this.lblPowerB = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblCadence = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.GrpH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTrue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.GrpH.Location = new System.Drawing.Point(13, 568);
            this.GrpH.Name = "GrpH";
            this.GrpH.Size = new System.Drawing.Size(435, 123);
            this.GrpH.TabIndex = 2;
            this.GrpH.TabStop = false;
            this.GrpH.Text = "Info:";
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
            this.lblsmode.Location = new System.Drawing.Point(261, 73);
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
            this.lbllength.Location = new System.Drawing.Point(261, 47);
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
            this.lblmonitor.Location = new System.Drawing.Point(259, 21);
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
            this.Calendar.Location = new System.Drawing.Point(978, 93);
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
            this.DataTrue.Location = new System.Drawing.Point(20, 243);
            this.DataTrue.Name = "DataTrue";
            this.DataTrue.Size = new System.Drawing.Size(946, 303);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAir);
            this.groupBox1.Controls.Add(this.lblUS);
            this.groupBox1.Controls.Add(this.lblHRdata);
            this.groupBox1.Controls.Add(this.lblPowerI);
            this.groupBox1.Controls.Add(this.lblPowerB);
            this.groupBox1.Controls.Add(this.lblPower);
            this.groupBox1.Controls.Add(this.lblAltitude);
            this.groupBox1.Controls.Add(this.lblCadence);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Location = new System.Drawing.Point(482, 568);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smode";
            // 
            // lblAir
            // 
            this.lblAir.AutoSize = true;
            this.lblAir.Location = new System.Drawing.Point(375, 16);
            this.lblAir.Name = "lblAir";
            this.lblAir.Size = new System.Drawing.Size(63, 13);
            this.lblAir.TabIndex = 8;
            this.lblAir.Text = "Air Pressure";
            // 
            // lblUS
            // 
            this.lblUS.AutoSize = true;
            this.lblUS.Location = new System.Drawing.Point(233, 99);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(48, 13);
            this.lblUS.TabIndex = 7;
            this.lblUS.Text = "US(mph)";
            // 
            // lblHRdata
            // 
            this.lblHRdata.AutoSize = true;
            this.lblHRdata.Location = new System.Drawing.Point(233, 73);
            this.lblHRdata.Name = "lblHRdata";
            this.lblHRdata.Size = new System.Drawing.Size(68, 13);
            this.lblHRdata.TabIndex = 6;
            this.lblHRdata.Text = "Hr Data Only";
            // 
            // lblPowerI
            // 
            this.lblPowerI.AutoSize = true;
            this.lblPowerI.Location = new System.Drawing.Point(233, 47);
            this.lblPowerI.Name = "lblPowerI";
            this.lblPowerI.Size = new System.Drawing.Size(66, 13);
            this.lblPowerI.TabIndex = 5;
            this.lblPowerI.Text = "Power Index";
            // 
            // lblPowerB
            // 
            this.lblPowerB.AutoSize = true;
            this.lblPowerB.Location = new System.Drawing.Point(233, 16);
            this.lblPowerB.Name = "lblPowerB";
            this.lblPowerB.Size = new System.Drawing.Size(79, 13);
            this.lblPowerB.TabIndex = 4;
            this.lblPowerB.Text = "Power Balance";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(6, 99);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(37, 13);
            this.lblPower.TabIndex = 3;
            this.lblPower.Text = "Power";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(7, 73);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(42, 13);
            this.lblAltitude.TabIndex = 2;
            this.lblAltitude.Text = "Altitude";
            // 
            // lblCadence
            // 
            this.lblCadence.AutoSize = true;
            this.lblCadence.Location = new System.Drawing.Point(6, 47);
            this.lblCadence.Name = "lblCadence";
            this.lblCadence.Size = new System.Drawing.Size(50, 13);
            this.lblCadence.TabIndex = 1;
            this.lblCadence.Text = "Cadence";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(7, 21);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Speed";
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
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.summaryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(23, 697);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(642, 372);
            this.zedGraphControl1.TabIndex = 11;
            // 
            // First
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1020, 788);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataTrue);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.GrpH);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "First";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.First_Load);
            this.GrpH.ResumeLayout(false);
            this.GrpH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTrue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox GrpH;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView DataTrue;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAir;
        private System.Windows.Forms.Label lblUS;
        private System.Windows.Forms.Label lblHRdata;
        private System.Windows.Forms.Label lblPowerI;
        private System.Windows.Forms.Label lblPowerB;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblCadence;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}