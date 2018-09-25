namespace SMSSimulation_Linq {
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
            this.buttonShowMsg = new System.Windows.Forms.Button();
            this.listViewMsg = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonCurDel = new System.Windows.Forms.Button();
            this.groupBoxFilter.SuspendLayout();
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
            this.comboBoxSelectFormat.Location = new System.Drawing.Point(11, 126);
            this.comboBoxSelectFormat.Name = "comboBoxSelectFormat";
            this.comboBoxSelectFormat.Size = new System.Drawing.Size(190, 21);
            this.comboBoxSelectFormat.TabIndex = 0;
            this.comboBoxSelectFormat.Text = "Select formatting";
            this.comboBoxSelectFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFormat_SelectedIndexChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(219, 12);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(241, 21);
            this.comboBoxUser.TabIndex = 2;
            this.comboBoxUser.Text = "Select subscriber";
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            this.comboBoxUser.Click += new System.EventHandler(this.comboBoxUser_Click);
            // 
            // textBoxMsgPattern
            // 
            this.textBoxMsgPattern.Location = new System.Drawing.Point(219, 44);
            this.textBoxMsgPattern.Name = "textBoxMsgPattern";
            this.textBoxMsgPattern.Size = new System.Drawing.Size(241, 20);
            this.textBoxMsgPattern.TabIndex = 3;
            this.textBoxMsgPattern.Text = "Message";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(354, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // buttonShowMsg
            // 
            this.buttonShowMsg.Location = new System.Drawing.Point(219, 124);
            this.buttonShowMsg.Name = "buttonShowMsg";
            this.buttonShowMsg.Size = new System.Drawing.Size(124, 23);
            this.buttonShowMsg.TabIndex = 6;
            this.buttonShowMsg.Text = "Show messages";
            this.buttonShowMsg.UseVisualStyleBackColor = true;
            this.buttonShowMsg.Visible = false;
            this.buttonShowMsg.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewMsg
            // 
            this.listViewMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Text,
            this.Time});
            this.listViewMsg.Location = new System.Drawing.Point(11, 155);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(449, 232);
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
            this.groupBoxFilter.Controls.Add(this.checkedListBox1);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(189, 108);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter settings";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 85);
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
            this.radioButton1.Location = new System.Drawing.Point(6, 85);
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
            this.checkedListBox1.Size = new System.Drawing.Size(177, 49);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // buttonCurDel
            // 
            this.buttonCurDel.Location = new System.Drawing.Point(354, 124);
            this.buttonCurDel.Name = "buttonCurDel";
            this.buttonCurDel.Size = new System.Drawing.Size(105, 23);
            this.buttonCurDel.TabIndex = 9;
            this.buttonCurDel.Text = "Del current";
            this.buttonCurDel.UseVisualStyleBackColor = true;
            this.buttonCurDel.Visible = false;
            this.buttonCurDel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 406);
            this.Controls.Add(this.buttonCurDel);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.listViewMsg);
            this.Controls.Add(this.buttonShowMsg);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMsgPattern);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.comboBoxSelectFormat);
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectFormat;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.TextBox textBoxMsgPattern;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonShowMsg;
        private System.Windows.Forms.ListView listViewMsg;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Text;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonCurDel;
    }
}

