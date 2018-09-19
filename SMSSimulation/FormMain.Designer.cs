namespace SMSSimulation {
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
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
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
            this.comboBoxSelectFormat.Location = new System.Drawing.Point(21, 17);
            this.comboBoxSelectFormat.Name = "comboBoxSelectFormat";
            this.comboBoxSelectFormat.Size = new System.Drawing.Size(166, 21);
            this.comboBoxSelectFormat.TabIndex = 0;
            this.comboBoxSelectFormat.Text = "Select formatting";
            this.comboBoxSelectFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectFormat_SelectedIndexChanged);
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMessages.Location = new System.Drawing.Point(21, 54);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.Size = new System.Drawing.Size(324, 195);
            this.richTextBoxMessages.TabIndex = 1;
            this.richTextBoxMessages.Text = "";
            this.richTextBoxMessages.TextChanged += new System.EventHandler(this.richTextBoxMessages_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.richTextBoxMessages);
            this.Controls.Add(this.comboBoxSelectFormat);
            this.Name = "FormMain";
            this.Text = "Message Formatting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectFormat;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
    }
}

