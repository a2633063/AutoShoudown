namespace 自动关机Cmd
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabShutdown3 = new System.Windows.Forms.RadioButton();
            this.rabShutdown2 = new System.Windows.Forms.RadioButton();
            this.rabShutdown1 = new System.Windows.Forms.RadioButton();
            this.rabShutdown0 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labTiem = new System.Windows.Forms.Label();
            this.panelTime0 = new System.Windows.Forms.Panel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTime1 = new System.Windows.Forms.Panel();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTime1 = new System.Windows.Forms.RadioButton();
            this.rdbTime0 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelTime0.SuspendLayout();
            this.panelTime1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabShutdown3);
            this.groupBox1.Controls.Add(this.rabShutdown2);
            this.groupBox1.Controls.Add(this.rabShutdown1);
            this.groupBox1.Controls.Add(this.rabShutdown0);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(59, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rabShutdown3
            // 
            this.rabShutdown3.AutoSize = true;
            this.rabShutdown3.Enabled = false;
            this.rabShutdown3.Location = new System.Drawing.Point(6, 86);
            this.rabShutdown3.Name = "rabShutdown3";
            this.rabShutdown3.Size = new System.Drawing.Size(47, 16);
            this.rabShutdown3.TabIndex = 3;
            this.rabShutdown3.Text = "休眠";
            this.rabShutdown3.UseVisualStyleBackColor = true;
            // 
            // rabShutdown2
            // 
            this.rabShutdown2.AutoSize = true;
            this.rabShutdown2.Enabled = false;
            this.rabShutdown2.Location = new System.Drawing.Point(6, 64);
            this.rabShutdown2.Name = "rabShutdown2";
            this.rabShutdown2.Size = new System.Drawing.Size(47, 16);
            this.rabShutdown2.TabIndex = 2;
            this.rabShutdown2.Text = "注销";
            this.rabShutdown2.UseVisualStyleBackColor = true;
            // 
            // rabShutdown1
            // 
            this.rabShutdown1.AutoSize = true;
            this.rabShutdown1.Location = new System.Drawing.Point(6, 42);
            this.rabShutdown1.Name = "rabShutdown1";
            this.rabShutdown1.Size = new System.Drawing.Size(47, 16);
            this.rabShutdown1.TabIndex = 1;
            this.rabShutdown1.Text = "重启";
            this.rabShutdown1.UseVisualStyleBackColor = true;
            // 
            // rabShutdown0
            // 
            this.rabShutdown0.AutoSize = true;
            this.rabShutdown0.Checked = true;
            this.rabShutdown0.Location = new System.Drawing.Point(6, 20);
            this.rabShutdown0.Name = "rabShutdown0";
            this.rabShutdown0.Size = new System.Drawing.Size(47, 16);
            this.rabShutdown0.TabIndex = 0;
            this.rabShutdown0.TabStop = true;
            this.rabShutdown0.Text = "关机";
            this.rabShutdown0.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labTiem);
            this.groupBox2.Controls.Add(this.panelTime0);
            this.groupBox2.Controls.Add(this.btnEnter);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.panelTime1);
            this.groupBox2.Controls.Add(this.rdbTime1);
            this.groupBox2.Controls.Add(this.rdbTime0);
            this.groupBox2.Location = new System.Drawing.Point(77, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // labTiem
            // 
            this.labTiem.AutoSize = true;
            this.labTiem.Location = new System.Drawing.Point(6, 13);
            this.labTiem.Name = "labTiem";
            this.labTiem.Size = new System.Drawing.Size(29, 12);
            this.labTiem.TabIndex = 12;
            this.labTiem.Text = "Time";
            // 
            // panelTime0
            // 
            this.panelTime0.Controls.Add(this.dtpTime);
            this.panelTime0.Controls.Add(this.dtpDate);
            this.panelTime0.Location = new System.Drawing.Point(84, 29);
            this.panelTime0.Name = "panelTime0";
            this.panelTime0.Size = new System.Drawing.Size(198, 22);
            this.panelTime0.TabIndex = 11;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(112, 1);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(86, 21);
            this.dtpTime.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy年MM月dd日 HH:mm:ss";
            this.dtpDate.Location = new System.Drawing.Point(0, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(106, 21);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(152, 84);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "执行";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(31, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消任务";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelTime1
            // 
            this.panelTime1.Controls.Add(this.nudMin);
            this.panelTime1.Controls.Add(this.nudHour);
            this.panelTime1.Controls.Add(this.label2);
            this.panelTime1.Controls.Add(this.label1);
            this.panelTime1.Enabled = false;
            this.panelTime1.Location = new System.Drawing.Point(83, 56);
            this.panelTime1.Name = "panelTime1";
            this.panelTime1.Size = new System.Drawing.Size(198, 22);
            this.panelTime1.TabIndex = 10;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(98, 1);
            this.nudMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(61, 21);
            this.nudMin.TabIndex = 12;
            this.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(1, 1);
            this.nudHour.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(61, 21);
            this.nudHour.TabIndex = 10;
            this.nudHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "分钟";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "小时";
            // 
            // rdbTime1
            // 
            this.rdbTime1.AutoSize = true;
            this.rdbTime1.Location = new System.Drawing.Point(6, 59);
            this.rdbTime1.Name = "rdbTime1";
            this.rdbTime1.Size = new System.Drawing.Size(59, 16);
            this.rdbTime1.TabIndex = 5;
            this.rdbTime1.Text = "倒计时";
            this.rdbTime1.UseVisualStyleBackColor = true;
            this.rdbTime1.CheckedChanged += new System.EventHandler(this.radioButton_Time_CheckedChanged);
            // 
            // rdbTime0
            // 
            this.rdbTime0.AutoSize = true;
            this.rdbTime0.Checked = true;
            this.rdbTime0.Location = new System.Drawing.Point(6, 32);
            this.rdbTime0.Name = "rdbTime0";
            this.rdbTime0.Size = new System.Drawing.Size(71, 16);
            this.rdbTime0.TabIndex = 4;
            this.rdbTime0.TabStop = true;
            this.rdbTime0.Text = "指定时间";
            this.rdbTime0.UseVisualStyleBackColor = true;
            this.rdbTime0.CheckedChanged += new System.EventHandler(this.radioButton_Time_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 499;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 131);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Z定时关机";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelTime0.ResumeLayout(false);
            this.panelTime1.ResumeLayout(false);
            this.panelTime1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabShutdown2;
        private System.Windows.Forms.RadioButton rabShutdown1;
        private System.Windows.Forms.RadioButton rabShutdown0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTime1;
        private System.Windows.Forms.RadioButton rdbTime0;
        private System.Windows.Forms.RadioButton rabShutdown3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTime1;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTime0;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labTiem;
    }
}

