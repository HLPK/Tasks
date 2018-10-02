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
            this.labelCharging = new System.Windows.Forms.Label();
            this.radioButtonChargeByTask = new System.Windows.Forms.RadioButton();
            this.radioButtonChargeByThread = new System.Windows.Forms.RadioButton();
            this.buttonChargeStop = new System.Windows.Forms.Button();
            this.buttonChargeStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.comboBoxSelectFormat.Location = new System.Drawing.Point(15, 158);
            this.comboBoxSelectFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectFormat.Name = "comboBoxSelectFormat";
            this.comboBoxSelectFormat.Size = new System.Drawing.Size(252, 24);
            this.comboBoxSelectFormat.TabIndex = 0;
            this.comboBoxSelectFormat.Text = "Select formatting";
            this.comboBoxSelectFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFormat_SelectedIndexChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(205, 23);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(285, 24);
            this.comboBoxUser.TabIndex = 2;
            this.comboBoxUser.Text = "Select subscriber";
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            this.comboBoxUser.Click += new System.EventHandler(this.comboBoxUser_Click);
            // 
            // textBoxMsgPattern
            // 
            this.textBoxMsgPattern.Location = new System.Drawing.Point(205, 57);
            this.textBoxMsgPattern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMsgPattern.Name = "textBoxMsgPattern";
            this.textBoxMsgPattern.Size = new System.Drawing.Size(285, 22);
            this.textBoxMsgPattern.TabIndex = 3;
            this.textBoxMsgPattern.Text = "Message";
            this.textBoxMsgPattern.TextChanged += new System.EventHandler(this.textBoxMsgPattern_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 87);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(352, 87);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // listViewMsg
            // 
            this.listViewMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Text,
            this.Time});
            this.listViewMsg.Location = new System.Drawing.Point(15, 191);
            this.listViewMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(993, 306);
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
            this.groupBoxFilter.Location = new System.Drawing.Point(16, 15);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFilter.Size = new System.Drawing.Size(509, 133);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter settings";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 105);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AND";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 105);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "OR";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "subscriber",
            "message",
            "period"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 24);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(193, 72);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBoxSMSGenerating
            // 
            this.groupBoxSMSGenerating.Controls.Add(this.buttonSendSMSStop);
            this.groupBoxSMSGenerating.Controls.Add(this.radioButtonSendSMSByTask);
            this.groupBoxSMSGenerating.Controls.Add(this.radioButtonSendSMSThread);
            this.groupBoxSMSGenerating.Controls.Add(this.buttonSendSMSStart);
            this.groupBoxSMSGenerating.Location = new System.Drawing.Point(539, 15);
            this.groupBoxSMSGenerating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSMSGenerating.Name = "groupBoxSMSGenerating";
            this.groupBoxSMSGenerating.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSMSGenerating.Size = new System.Drawing.Size(471, 66);
            this.groupBoxSMSGenerating.TabIndex = 9;
            this.groupBoxSMSGenerating.TabStop = false;
            this.groupBoxSMSGenerating.Text = "SMS generating";
            // 
            // buttonSendSMSStop
            // 
            this.buttonSendSMSStop.Enabled = false;
            this.buttonSendSMSStop.Location = new System.Drawing.Point(136, 23);
            this.buttonSendSMSStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendSMSStop.Name = "buttonSendSMSStop";
            this.buttonSendSMSStop.Size = new System.Drawing.Size(107, 28);
            this.buttonSendSMSStop.TabIndex = 6;
            this.buttonSendSMSStop.Text = "Stop";
            this.buttonSendSMSStop.UseVisualStyleBackColor = true;
            this.buttonSendSMSStop.Click += new System.EventHandler(this.buttonSendSMSStop_Click);
            // 
            // radioButtonSendSMSByTask
            // 
            this.radioButtonSendSMSByTask.AutoSize = true;
            this.radioButtonSendSMSByTask.Location = new System.Drawing.Point(377, 28);
            this.radioButtonSendSMSByTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSendSMSByTask.Name = "radioButtonSendSMSByTask";
            this.radioButtonSendSMSByTask.Size = new System.Drawing.Size(79, 21);
            this.radioButtonSendSMSByTask.TabIndex = 5;
            this.radioButtonSendSMSByTask.Text = "by Task";
            this.radioButtonSendSMSByTask.UseVisualStyleBackColor = true;
            this.radioButtonSendSMSByTask.CheckedChanged += new System.EventHandler(this.radioButtonSendSMSByTask_CheckedChanged);
            // 
            // radioButtonSendSMSThread
            // 
            this.radioButtonSendSMSThread.AutoSize = true;
            this.radioButtonSendSMSThread.Checked = true;
            this.radioButtonSendSMSThread.Location = new System.Drawing.Point(272, 28);
            this.radioButtonSendSMSThread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSendSMSThread.Name = "radioButtonSendSMSThread";
            this.radioButtonSendSMSThread.Size = new System.Drawing.Size(94, 21);
            this.radioButtonSendSMSThread.TabIndex = 4;
            this.radioButtonSendSMSThread.TabStop = true;
            this.radioButtonSendSMSThread.Text = "by Thread";
            this.radioButtonSendSMSThread.UseVisualStyleBackColor = true;
            this.radioButtonSendSMSThread.CheckedChanged += new System.EventHandler(this.radioButtonSendSMSThread_CheckedChanged);
            // 
            // buttonSendSMSStart
            // 
            this.buttonSendSMSStart.Location = new System.Drawing.Point(12, 23);
            this.buttonSendSMSStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSendSMSStart.Name = "buttonSendSMSStart";
            this.buttonSendSMSStart.Size = new System.Drawing.Size(116, 28);
            this.buttonSendSMSStart.TabIndex = 1;
            this.buttonSendSMSStart.Text = "Start";
            this.buttonSendSMSStart.UseVisualStyleBackColor = true;
            this.buttonSendSMSStart.Click += new System.EventHandler(this.buttonSendSMSStartStop_Click);
            // 
            // groupBoxCharging
            // 
            this.groupBoxCharging.Controls.Add(this.labelCharging);
            this.groupBoxCharging.Controls.Add(this.radioButtonChargeByTask);
            this.groupBoxCharging.Controls.Add(this.radioButtonChargeByThread);
            this.groupBoxCharging.Controls.Add(this.buttonChargeStop);
            this.groupBoxCharging.Controls.Add(this.buttonChargeStart);
            this.groupBoxCharging.Controls.Add(this.progressBar1);
            this.groupBoxCharging.Location = new System.Drawing.Point(539, 89);
            this.groupBoxCharging.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCharging.Name = "groupBoxCharging";
            this.groupBoxCharging.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCharging.Size = new System.Drawing.Size(471, 95);
            this.groupBoxCharging.TabIndex = 10;
            this.groupBoxCharging.TabStop = false;
            this.groupBoxCharging.Text = "Charging";
            this.groupBoxCharging.Enter += new System.EventHandler(this.groupBoxCharging_Enter);
            // 
            // labelCharging
            // 
            this.labelCharging.AutoSize = true;
            this.labelCharging.Location = new System.Drawing.Point(265, 64);
            this.labelCharging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCharging.Name = "labelCharging";
            this.labelCharging.Size = new System.Drawing.Size(44, 17);
            this.labelCharging.TabIndex = 5;
            this.labelCharging.Text = "100%";
            // 
            // radioButtonChargeByTask
            // 
            this.radioButtonChargeByTask.AutoSize = true;
            this.radioButtonChargeByTask.Location = new System.Drawing.Point(376, 23);
            this.radioButtonChargeByTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonChargeByTask.Name = "radioButtonChargeByTask";
            this.radioButtonChargeByTask.Size = new System.Drawing.Size(79, 21);
            this.radioButtonChargeByTask.TabIndex = 4;
            this.radioButtonChargeByTask.TabStop = true;
            this.radioButtonChargeByTask.Text = "by Task";
            this.radioButtonChargeByTask.UseVisualStyleBackColor = true;
            this.radioButtonChargeByTask.CheckedChanged += new System.EventHandler(this.radioButtonChargeByTask_CheckedChanged);
            // 
            // radioButtonChargeByThread
            // 
            this.radioButtonChargeByThread.AutoSize = true;
            this.radioButtonChargeByThread.Checked = true;
            this.radioButtonChargeByThread.Location = new System.Drawing.Point(272, 23);
            this.radioButtonChargeByThread.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonChargeByThread.Name = "radioButtonChargeByThread";
            this.radioButtonChargeByThread.Size = new System.Drawing.Size(94, 21);
            this.radioButtonChargeByThread.TabIndex = 3;
            this.radioButtonChargeByThread.TabStop = true;
            this.radioButtonChargeByThread.Text = "by Thread";
            this.radioButtonChargeByThread.UseVisualStyleBackColor = true;
            this.radioButtonChargeByThread.CheckedChanged += new System.EventHandler(this.radioButtonChargeByThread_CheckedChanged);
            // 
            // buttonChargeStop
            // 
            this.buttonChargeStop.Enabled = false;
            this.buttonChargeStop.Location = new System.Drawing.Point(136, 23);
            this.buttonChargeStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChargeStop.Name = "buttonChargeStop";
            this.buttonChargeStop.Size = new System.Drawing.Size(107, 28);
            this.buttonChargeStop.TabIndex = 2;
            this.buttonChargeStop.Text = "Stop";
            this.buttonChargeStop.UseVisualStyleBackColor = true;
            this.buttonChargeStop.Click += new System.EventHandler(this.buttonChargeStop_Click);
            // 
            // buttonChargeStart
            // 
            this.buttonChargeStart.Location = new System.Drawing.Point(12, 23);
            this.buttonChargeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChargeStart.Name = "buttonChargeStart";
            this.buttonChargeStart.Size = new System.Drawing.Size(116, 28);
            this.buttonChargeStart.TabIndex = 1;
            this.buttonChargeStart.Text = "Start";
            this.buttonChargeStart.UseVisualStyleBackColor = true;
            this.buttonChargeStart.Click += new System.EventHandler(this.buttonChargeStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 59);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 512);
            this.Controls.Add(this.groupBoxCharging);
            this.Controls.Add(this.groupBoxSMSGenerating);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.listViewMsg);
            this.Controls.Add(this.comboBoxSelectFormat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label labelCharging;
    }
}

