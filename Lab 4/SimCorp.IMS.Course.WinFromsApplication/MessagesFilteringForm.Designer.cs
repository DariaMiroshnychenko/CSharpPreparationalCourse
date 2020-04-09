namespace SimCorp.IMS.Course.WinFromsApplication
{
    partial class MessageFilteringFrom
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
            this.selectFilteringLabel = new System.Windows.Forms.Label();
            this.senderComboBox = new System.Windows.Forms.ComboBox();
            this.senderLabel = new System.Windows.Forms.Label();
            this.textToLookForLabel = new System.Windows.Forms.Label();
            this.lookForTextBox = new System.Windows.Forms.TextBox();
            this.datePeriodLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.andRadioButton = new System.Windows.Forms.RadioButton();
            this.orRadioButton = new System.Windows.Forms.RadioButton();
            this.filteringLogicLabel = new System.Windows.Forms.Label();
            this.formattingLabel = new System.Windows.Forms.Label();
            this.formattingOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.messagesListView = new System.Windows.Forms.ListView();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFilteringLabel
            // 
            this.selectFilteringLabel.AutoSize = true;
            this.selectFilteringLabel.Location = new System.Drawing.Point(7, 7);
            this.selectFilteringLabel.Name = "selectFilteringLabel";
            this.selectFilteringLabel.Size = new System.Drawing.Size(195, 13);
            this.selectFilteringLabel.TabIndex = 0;
            this.selectFilteringLabel.Text = "Select filtering of messages and apply it:";
            // 
            // senderComboBox
            // 
            this.senderComboBox.FormattingEnabled = true;
            this.senderComboBox.Location = new System.Drawing.Point(101, 29);
            this.senderComboBox.Name = "senderComboBox";
            this.senderComboBox.Size = new System.Drawing.Size(166, 21);
            this.senderComboBox.TabIndex = 1;
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Location = new System.Drawing.Point(7, 32);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(41, 13);
            this.senderLabel.TabIndex = 2;
            this.senderLabel.Text = "Sender";
            // 
            // textToLookForLabel
            // 
            this.textToLookForLabel.AutoSize = true;
            this.textToLookForLabel.Location = new System.Drawing.Point(7, 59);
            this.textToLookForLabel.Name = "textToLookForLabel";
            this.textToLookForLabel.Size = new System.Drawing.Size(78, 13);
            this.textToLookForLabel.TabIndex = 3;
            this.textToLookForLabel.Text = "Text to look for";
            // 
            // lookForTextBox
            // 
            this.lookForTextBox.Location = new System.Drawing.Point(101, 56);
            this.lookForTextBox.Name = "lookForTextBox";
            this.lookForTextBox.Size = new System.Drawing.Size(166, 20);
            this.lookForTextBox.TabIndex = 4;
            // 
            // datePeriodLabel
            // 
            this.datePeriodLabel.AutoSize = true;
            this.datePeriodLabel.Location = new System.Drawing.Point(7, 82);
            this.datePeriodLabel.Name = "datePeriodLabel";
            this.datePeriodLabel.Size = new System.Drawing.Size(65, 13);
            this.datePeriodLabel.TabIndex = 5;
            this.datePeriodLabel.Text = "Date period:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(101, 99);
            this.fromDateTimePicker.MaxDate = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.fromDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(166, 20);
            this.fromDateTimePicker.TabIndex = 6;
            this.fromDateTimePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(101, 129);
            this.toDateTimePicker.MaxDate = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(166, 20);
            this.toDateTimePicker.TabIndex = 7;
            this.toDateTimePicker.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Location = new System.Drawing.Point(42, 105);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(30, 13);
            this.fromDateLabel.TabIndex = 8;
            this.fromDateLabel.Text = "From";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Location = new System.Drawing.Point(52, 129);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(20, 13);
            this.toDateLabel.TabIndex = 9;
            this.toDateLabel.Text = "To";
            // 
            // andRadioButton
            // 
            this.andRadioButton.AutoSize = true;
            this.andRadioButton.Location = new System.Drawing.Point(102, 161);
            this.andRadioButton.Name = "andRadioButton";
            this.andRadioButton.Size = new System.Drawing.Size(48, 17);
            this.andRadioButton.TabIndex = 10;
            this.andRadioButton.Text = "AND";
            this.andRadioButton.UseVisualStyleBackColor = true;
            // 
            // orRadioButton
            // 
            this.orRadioButton.AutoSize = true;
            this.orRadioButton.Checked = true;
            this.orRadioButton.Location = new System.Drawing.Point(194, 161);
            this.orRadioButton.Name = "orRadioButton";
            this.orRadioButton.Size = new System.Drawing.Size(41, 17);
            this.orRadioButton.TabIndex = 11;
            this.orRadioButton.TabStop = true;
            this.orRadioButton.Text = "OR";
            this.orRadioButton.UseVisualStyleBackColor = true;
            // 
            // filteringLogicLabel
            // 
            this.filteringLogicLabel.AutoSize = true;
            this.filteringLogicLabel.Location = new System.Drawing.Point(7, 163);
            this.filteringLogicLabel.Name = "filteringLogicLabel";
            this.filteringLogicLabel.Size = new System.Drawing.Size(71, 13);
            this.filteringLogicLabel.TabIndex = 12;
            this.filteringLogicLabel.Text = "Filtering logic:";
            // 
            // formattingLabel
            // 
            this.formattingLabel.AutoSize = true;
            this.formattingLabel.Location = new System.Drawing.Point(7, 220);
            this.formattingLabel.Name = "formattingLabel";
            this.formattingLabel.Size = new System.Drawing.Size(56, 13);
            this.formattingLabel.TabIndex = 13;
            this.formattingLabel.Text = "Formatting";
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
            this.formattingOptionsComboBox.Location = new System.Drawing.Point(102, 217);
            this.formattingOptionsComboBox.Name = "formattingOptionsComboBox";
            this.formattingOptionsComboBox.Size = new System.Drawing.Size(166, 21);
            this.formattingOptionsComboBox.TabIndex = 14;
            this.formattingOptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.formattingOptionsComboBox_SelectedIndexChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(174, 184);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(93, 23);
            this.applyButton.TabIndex = 16;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // messagesListView
            // 
            this.messagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.Message});
            this.messagesListView.Location = new System.Drawing.Point(284, 7);
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.Size = new System.Drawing.Size(350, 231);
            this.messagesListView.TabIndex = 17;
            this.messagesListView.TileSize = new System.Drawing.Size(300, 30);
            this.messagesListView.UseCompatibleStateImageBehavior = false;
            this.messagesListView.View = System.Windows.Forms.View.Tile;
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            this.Sender.Width = 200;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 200;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(10, 184);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // MessageFilteringFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 247);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.messagesListView);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.formattingOptionsComboBox);
            this.Controls.Add(this.formattingLabel);
            this.Controls.Add(this.filteringLogicLabel);
            this.Controls.Add(this.orRadioButton);
            this.Controls.Add(this.andRadioButton);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.datePeriodLabel);
            this.Controls.Add(this.lookForTextBox);
            this.Controls.Add(this.textToLookForLabel);
            this.Controls.Add(this.senderLabel);
            this.Controls.Add(this.senderComboBox);
            this.Controls.Add(this.selectFilteringLabel);
            this.MaximizeBox = false;
            this.Name = "MessageFilteringFrom";
            this.Text = "Message Filtering";
            this.Load += new System.EventHandler(this.MessageFilteringFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectFilteringLabel;
        private System.Windows.Forms.ComboBox senderComboBox;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.Label textToLookForLabel;
        private System.Windows.Forms.TextBox lookForTextBox;
        private System.Windows.Forms.Label datePeriodLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.RadioButton andRadioButton;
        private System.Windows.Forms.RadioButton orRadioButton;
        private System.Windows.Forms.Label filteringLogicLabel;
        private System.Windows.Forms.Label formattingLabel;
        private System.Windows.Forms.ComboBox formattingOptionsComboBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.Button resetButton;
    }
}

