namespace ContactsWinForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonGenerateContacts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonContact = new System.Windows.Forms.RadioButton();
            this.radioButtonNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonDirection = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacts";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(22, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(204, 88);
            this.treeView1.TabIndex = 1;
            // 
            // buttonGenerateContacts
            // 
            this.buttonGenerateContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateContacts.Location = new System.Drawing.Point(232, 29);
            this.buttonGenerateContacts.Name = "buttonGenerateContacts";
            this.buttonGenerateContacts.Size = new System.Drawing.Size(167, 23);
            this.buttonGenerateContacts.TabIndex = 2;
            this.buttonGenerateContacts.Text = "Generate Contacts";
            this.buttonGenerateContacts.UseVisualStyleBackColor = true;
            this.buttonGenerateContacts.Click += new System.EventHandler(this.buttonGenerateContacts_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(232, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Calls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show calls";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 166);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 138);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phone";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Direction";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Duration";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "num";
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPhone,
            this.columnDirection,
            this.columnTime,
            this.columnDuration});
            this.listViewHistory.Location = new System.Drawing.Point(71, 337);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(525, 83);
            this.listViewHistory.TabIndex = 6;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            // 
            // columnPhone
            // 
            this.columnPhone.DisplayIndex = 2;
            this.columnPhone.Text = "Phone";
            // 
            // columnDirection
            // 
            this.columnDirection.DisplayIndex = 3;
            this.columnDirection.Text = "Direction";
            // 
            // columnTime
            // 
            this.columnTime.DisplayIndex = 0;
            this.columnTime.Text = "Time";
            // 
            // columnDuration
            // 
            this.columnDuration.DisplayIndex = 1;
            this.columnDuration.Text = "Duration";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "History:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Group by";
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Checked = true;
            this.radioButtonNone.Location = new System.Drawing.Point(249, 141);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(63, 21);
            this.radioButtonNone.TabIndex = 9;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonContact
            // 
            this.radioButtonContact.AutoSize = true;
            this.radioButtonContact.Location = new System.Drawing.Point(325, 141);
            this.radioButtonContact.Name = "radioButtonContact";
            this.radioButtonContact.Size = new System.Drawing.Size(77, 21);
            this.radioButtonContact.TabIndex = 10;
            this.radioButtonContact.TabStop = true;
            this.radioButtonContact.Text = "Contact";
            this.radioButtonContact.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumber
            // 
            this.radioButtonNumber.AutoSize = true;
            this.radioButtonNumber.Location = new System.Drawing.Point(408, 141);
            this.radioButtonNumber.Name = "radioButtonNumber";
            this.radioButtonNumber.Size = new System.Drawing.Size(79, 21);
            this.radioButtonNumber.TabIndex = 11;
            this.radioButtonNumber.TabStop = true;
            this.radioButtonNumber.Text = "Number";
            this.radioButtonNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonDirection
            // 
            this.radioButtonDirection.AutoSize = true;
            this.radioButtonDirection.Location = new System.Drawing.Point(493, 141);
            this.radioButtonDirection.Name = "radioButtonDirection";
            this.radioButtonDirection.Size = new System.Drawing.Size(85, 21);
            this.radioButtonDirection.TabIndex = 12;
            this.radioButtonDirection.TabStop = true;
            this.radioButtonDirection.Text = "Direction";
            this.radioButtonDirection.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 432);
            this.Controls.Add(this.radioButtonDirection);
            this.Controls.Add(this.radioButtonNumber);
            this.Controls.Add(this.radioButtonContact);
            this.Controls.Add(this.radioButtonNone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGenerateContacts);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Calls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonGenerateContacts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonContact;
        private System.Windows.Forms.RadioButton radioButtonNumber;
        private System.Windows.Forms.RadioButton radioButtonDirection;
    }
}

