namespace SimCorp.IMS.Course.WinFormsApplication
{
    partial class MessagesForm
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
            this.selectFormattingLabel = new System.Windows.Forms.Label();
            this.formattingOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.messagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // selectFormattingLabel
            // 
            this.selectFormattingLabel.AutoSize = true;
            this.selectFormattingLabel.Location = new System.Drawing.Point(7, 9);
            this.selectFormattingLabel.Name = "selectFormattingLabel";
            this.selectFormattingLabel.Size = new System.Drawing.Size(134, 13);
            this.selectFormattingLabel.TabIndex = 0;
            this.selectFormattingLabel.Text = "Select message formatting:";
            // 
            // formattingOptionsComboBox
            // 
            this.formattingOptionsComboBox.FormattingEnabled = true;
            this.formattingOptionsComboBox.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Lower case",
            "Upper case",
            "End with message length"});
            this.formattingOptionsComboBox.Location = new System.Drawing.Point(10, 34);
            this.formattingOptionsComboBox.Name = "formattingOptionsComboBox";
            this.formattingOptionsComboBox.Size = new System.Drawing.Size(171, 21);
            this.formattingOptionsComboBox.TabIndex = 1;
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.Location = new System.Drawing.Point(10, 71);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.Size = new System.Drawing.Size(258, 188);
            this.messagesRichTextBox.TabIndex = 2;
            this.messagesRichTextBox.Text = "";
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 267);
            this.Controls.Add(this.messagesRichTextBox);
            this.Controls.Add(this.formattingOptionsComboBox);
            this.Controls.Add(this.selectFormattingLabel);
            this.MaximizeBox = false;
            this.Name = "MessagesForm";
            this.Text = "Messages";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessagesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectFormattingLabel;
        private System.Windows.Forms.ComboBox formattingOptionsComboBox;
        private System.Windows.Forms.RichTextBox messagesRichTextBox;
    }
}

