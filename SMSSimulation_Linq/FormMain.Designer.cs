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
            this.comboBoxSelectFormat.Location = new System.Drawing.Point(12, 79);
            this.comboBoxSelectFormat.Name = "comboBoxSelectFormat";
            this.comboBoxSelectFormat.Size = new System.Drawing.Size(166, 21);
            this.comboBoxSelectFormat.TabIndex = 0;
            this.comboBoxSelectFormat.Text = "Select formatting";
            this.comboBoxSelectFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFormat_SelectedIndexChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(220, 12);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(241, 21);
            this.comboBoxUser.TabIndex = 2;
            this.comboBoxUser.Text = "Select subscriber";
            // 
            // textBoxMsgPattern
            // 
            this.textBoxMsgPattern.Location = new System.Drawing.Point(220, 44);
            this.textBoxMsgPattern.Name = "textBoxMsgPattern";
            this.textBoxMsgPattern.Size = new System.Drawing.Size(241, 20);
            this.textBoxMsgPattern.TabIndex = 3;
            this.textBoxMsgPattern.Text = "Message";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(355, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // buttonShowMsg
            // 
            this.buttonShowMsg.Location = new System.Drawing.Point(12, 44);
            this.buttonShowMsg.Name = "buttonShowMsg";
            this.buttonShowMsg.Size = new System.Drawing.Size(166, 23);
            this.buttonShowMsg.TabIndex = 6;
            this.buttonShowMsg.Text = "Show messages";
            this.buttonShowMsg.UseVisualStyleBackColor = true;
            this.buttonShowMsg.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewMsg
            // 
            this.listViewMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Text,
            this.Time});
            this.listViewMsg.Location = new System.Drawing.Point(12, 115);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(449, 279);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 406);
            this.Controls.Add(this.listViewMsg);
            this.Controls.Add(this.buttonShowMsg);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMsgPattern);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.comboBoxSelectFormat);
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
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
    }
}

