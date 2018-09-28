namespace ThreadingsWinForm {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBoxSelectFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.textBoxMsgPattern = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listViewMsg = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBoxSMSGenerating = new System.Windows.Forms.GroupBox();
            this.buttonSendSMSStop = new System.Windows.Forms.Button();
            this.radioButtonSendSMSByTask = new System.Windows.Forms.RadioButton();
            this.radioButtonSendSMSThread = new System.Windows.Forms.RadioButton();
            this.buttonSendSMSStart = new System.Windows.Forms.Button();
            this.groupBoxCharging = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonChargeStart = new System.Windows.Forms.Button();
            this.buttonChargeStop = new System.Windows.Forms.Button();
            this.radioButtonChargeByThread = new System.Windows.Forms.RadioButton();
            this.radioButtonChargeByTask = new System.Windows.Forms.RadioButton();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxSMSGenerating.SuspendLayout();
            this.groupBoxCharging.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSelectFormat
            // 
            this.comboBoxSelectFormat.FormattingEnabled = true;
            this.comboBoxSelectFormat.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Custom",
            "Lowercase",
            "Uppercase"});
            this.comboBoxSelectFormat.Location = new System.Drawing.Point(11, 128);
            this.comboBoxSelectFormat.Name = "comboBoxSelectFormat";
            this.comboBoxSelectFormat.Size = new System.Drawing.Size(190, 21);
            this.comboBoxSelectFormat.TabIndex = 0;
            this.comboBoxSelectFormat.Text = "Select formatting";
            this.comboBoxSelectFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFormat_SelectedIndexChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(154, 19);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(215, 21);
            this.comboBoxUser.TabIndex = 2;
            this.comboBoxUser.Text = "Select subscriber";
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            this.comboBoxUser.Click += new System.EventHandler(this.comboBoxUser_Click);
            // 
            // textBoxMsgPattern
            // 
            this.textBoxMsgPattern.Location = new System.Drawing.Point(154, 46);
            this.textBoxMsgPattern.Name = "textBoxMsgPattern";
            this.textBoxMsgPattern.Size = new System.Drawing.Size(215, 20);
            this.textBoxMsgPattern.TabIndex = 3;
            this.textBoxMsgPattern.Text = "Message";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // listViewMsg
            // 
            this.listViewMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Text,
            this.Time});
            this.listViewMsg.Location = new System.Drawing.Point(11, 155);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(746, 249);
            this.listViewMsg.TabIndex = 7;
            this.listViewMsg.UseCompatibleStateImageBehavior = false;
            this.listViewMsg.SelectedIndexChanged += new System.EventHandler(this.listViewMsg_SelectedIndexChanged);
            // 
            // User
            // 
            this.User.Text = "User";
            // 
            // Text
            // 
            this.Text.Text = "Text";
            this.Text.Width = 120;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.radioButton2);
            this.groupBoxFilter.Controls.Add(this.radioButton1);
            this.groupBoxFilter.Controls.Add(this.dateTimePicker2);
            this.groupBoxFilter.Controls.Add(this.checkedListBox1);
            this.groupBoxFilter.Controls.Add(this.dateTimePicker1);
            this.groupBoxFilter.Controls.Add(this.comboBoxUser);
            this.groupBoxFilter.Controls.Add(this.textBoxMsgPattern);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(382, 108);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter settings";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AND";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "OR";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "subscriber",
            "message",
            "period"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(136, 49);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBoxSMSGenerating
            // 
            this.groupBoxSMSGenerating.Controls.Add(this.buttonSendSMSStop);
            this.groupBoxSMSGenerating.Controls.Add(this.radioButtonSendSMSByTask);
            this.groupBoxSMSGenerating.Controls.Add(this.radioButtonSendSMSThread);
            this.groupBoxSMSGenerating.Controls.Add(this.buttonSendSMSStart);
            this.groupBoxSMSGenerating.Location = new System.Drawing.Point(404, 12);
            this.groupBoxSMSGenerating.Name = "groupBoxSMSGenerating";
            this.groupBoxSMSGenerating.Size = new System.Drawing.Size(353, 54);
            this.groupBoxSMSGenerating.TabIndex = 9;
            this.groupBoxSMSGenerating.TabStop = false;
            this.groupBoxSMSGenerating.Text = "SMS generating";
            // 
            // buttonSendSMSStop
            // 
            this.buttonSendSMSStop.Enabled = false;
            this.buttonSendSMSStop.Location = new System.Drawing.Point(102, 19);
            this.buttonSendSMSStop.Name = "buttonSendSMSStop";
            this.buttonSendSMSStop.Size = new System.Drawing.Size(80, 23);
            this.buttonSendSMSStop.TabIndex = 6;
            this.buttonSendSMSStop.Text = "Stop";
            this.buttonSendSMSStop.UseVisualStyleBackColor = true;
            this.buttonSendSMSStop.Click += new System.EventHandler(this.buttonSendSMSStop_Click);
            // 
            // radioButtonSendSMSByTask
            // 
            this.radioButtonSendSMSByTask.AutoSize = true;
            this.radioButtonSendSMSByTask.Location = new System.Drawing.Point(283, 23);
            this.radioButtonSendSMSByTask.Name = "radioButtonSendSMSByTask";
            this.radioButtonSendSMSByTask.Size = new System.Drawing.Size(63, 17);
            this.radioButtonSendSMSByTask.TabIndex = 5;
            this.radioButtonSendSMSByTask.Text = "by Task";
            this.radioButtonSendSMSByTask.UseVisualStyleBackColor = true;
            this.radioButtonSendSMSByTask.CheckedChanged += new System.EventHandler(this.radioButtonSendSMSByTask_CheckedChanged);
            // 
            // radioButtonSendSMSThread
            // 
            this.radioButtonSendSMSThread.AutoSize = true;
            this.radioButtonSendSMSThread.Checked = true;
            this.radioButtonSendSMSThread.Location = new System.Drawing.Point(204, 23);
            this.radioButtonSendSMSThread.Name = "radioButtonSendSMSThread";
            this.radioButtonSendSMSThread.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSendSMSThread.TabIndex = 4;
            this.radioButtonSendSMSThread.TabStop = true;
            this.radioButtonSendSMSThread.Text = "by Thread";
            this.radioButtonSendSMSThread.UseVisualStyleBackColor = true;
            this.radioButtonSendSMSThread.CheckedChanged += new System.EventHandler(this.radioButtonSendSMSThread_CheckedChanged);
            // 
            // buttonSendSMSStart
            // 
            this.buttonSendSMSStart.Location = new System.Drawing.Point(9, 19);
            this.buttonSendSMSStart.Name = "buttonSendSMSStart";
            this.buttonSendSMSStart.Size = new System.Drawing.Size(87, 23);
            this.buttonSendSMSStart.TabIndex = 1;
            this.buttonSendSMSStart.Text = "Start";
            this.buttonSendSMSStart.UseVisualStyleBackColor = true;
            this.buttonSendSMSStart.Click += new System.EventHandler(this.buttonSendSMSStartStop_Click);
            // 
            // groupBoxCharging
            // 
            this.groupBoxCharging.Controls.Add(this.radioButtonChargeByTask);
            this.groupBoxCharging.Controls.Add(this.radioButtonChargeByThread);
            this.groupBoxCharging.Controls.Add(this.buttonChargeStop);
            this.groupBoxCharging.Controls.Add(this.buttonChargeStart);
            this.groupBoxCharging.Controls.Add(this.progressBar1);
            this.groupBoxCharging.Location = new System.Drawing.Point(404, 72);
            this.groupBoxCharging.Name = "groupBoxCharging";
            this.groupBoxCharging.Size = new System.Drawing.Size(353, 77);
            this.groupBoxCharging.TabIndex = 10;
            this.groupBoxCharging.TabStop = false;
            this.groupBoxCharging.Text = "Charging";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonChargeStart
            // 
            this.buttonChargeStart.Location = new System.Drawing.Point(9, 19);
            this.buttonChargeStart.Name = "buttonChargeStart";
            this.buttonChargeStart.Size = new System.Drawing.Size(87, 23);
            this.buttonChargeStart.TabIndex = 1;
            this.buttonChargeStart.Text = "Start";
            this.buttonChargeStart.UseVisualStyleBackColor = true;
            // 
            // buttonChargeStop
            // 
            this.buttonChargeStop.Location = new System.Drawing.Point(102, 19);
            this.buttonChargeStop.Name = "buttonChargeStop";
            this.buttonChargeStop.Size = new System.Drawing.Size(80, 23);
            this.buttonChargeStop.TabIndex = 2;
            this.buttonChargeStop.Text = "Stop";
            this.buttonChargeStop.UseVisualStyleBackColor = true;
            // 
            // radioButtonChargeByThread
            // 
            this.radioButtonChargeByThread.AutoSize = true;
            this.radioButtonChargeByThread.Checked = true;
            this.radioButtonChargeByThread.Location = new System.Drawing.Point(204, 19);
            this.radioButtonChargeByThread.Name = "radioButtonChargeByThread";
            this.radioButtonChargeByThread.Size = new System.Drawing.Size(73, 17);
            this.radioButtonChargeByThread.TabIndex = 3;
            this.radioButtonChargeByThread.TabStop = true;
            this.radioButtonChargeByThread.Text = "by Thread";
            this.radioButtonChargeByThread.UseVisualStyleBackColor = true;
            // 
            // radioButtonChargeByTask
            // 
            this.radioButtonChargeByTask.AutoSize = true;
            this.radioButtonChargeByTask.Location = new System.Drawing.Point(282, 19);
            this.radioButtonChargeByTask.Name = "radioButtonChargeByTask";
            this.radioButtonChargeByTask.Size = new System.Drawing.Size(63, 17);
            this.radioButtonChargeByTask.TabIndex = 4;
            this.radioButtonChargeByTask.TabStop = true;
            this.radioButtonChargeByTask.Text = "by Task";
            this.radioButtonChargeByTask.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 416);
            this.Controls.Add(this.groupBoxCharging);
            this.Controls.Add(this.groupBoxSMSGenerating);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.listViewMsg);
            this.Controls.Add(this.comboBoxSelectFormat);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxSMSGenerating.ResumeLayout(false);
            this.groupBoxSMSGenerating.PerformLayout();
            this.groupBoxCharging.ResumeLayout(false);
            this.groupBoxCharging.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectFormat;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.TextBox textBoxMsgPattern;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListView listViewMsg;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Text;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBoxSMSGenerating;
        private System.Windows.Forms.RadioButton radioButtonSendSMSByTask;
        private System.Windows.Forms.RadioButton radioButtonSendSMSThread;
        private System.Windows.Forms.Button buttonSendSMSStart;
        private System.Windows.Forms.Button buttonSendSMSStop;
        private System.Windows.Forms.GroupBox groupBoxCharging;
        private System.Windows.Forms.RadioButton radioButtonChargeByTask;
        private System.Windows.Forms.RadioButton radioButtonChargeByThread;
        private System.Windows.Forms.Button buttonChargeStop;
        private System.Windows.Forms.Button buttonChargeStart;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

