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
            this.filteringGroupBox = new System.Windows.Forms.GroupBox();
            this.generationOfMessagesGroupBox = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.batteryChargingGroupBox = new System.Windows.Forms.GroupBox();
            this.startOrStopChargingLabel = new System.Windows.Forms.Label();
            this.chargeButton = new System.Windows.Forms.Button();
            this.batteryChargeProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectApproachLabel = new System.Windows.Forms.Label();
            this.taskApproachRadioButton = new System.Windows.Forms.RadioButton();
            this.threadApproachRadioButton = new System.Windows.Forms.RadioButton();
            this.filteringGroupBox.SuspendLayout();
            this.generationOfMessagesGroupBox.SuspendLayout();
            this.batteryChargingGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFilteringLabel
            // 
            this.selectFilteringLabel.AutoSize = true;
            this.selectFilteringLabel.Location = new System.Drawing.Point(6, 22);
            this.selectFilteringLabel.Name = "selectFilteringLabel";
            this.selectFilteringLabel.Size = new System.Drawing.Size(195, 13);
            this.selectFilteringLabel.TabIndex = 0;
            this.selectFilteringLabel.Text = "Select filtering of messages and apply it:";
            // 
            // senderComboBox
            // 
            this.senderComboBox.FormattingEnabled = true;
            this.senderComboBox.Location = new System.Drawing.Point(95, 44);
            this.senderComboBox.Name = "senderComboBox";
            this.senderComboBox.Size = new System.Drawing.Size(166, 21);
            this.senderComboBox.TabIndex = 1;
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Location = new System.Drawing.Point(6, 47);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(41, 13);
            this.senderLabel.TabIndex = 2;
            this.senderLabel.Text = "Sender";
            // 
            // textToLookForLabel
            // 
            this.textToLookForLabel.AutoSize = true;
            this.textToLookForLabel.Location = new System.Drawing.Point(6, 76);
            this.textToLookForLabel.Name = "textToLookForLabel";
            this.textToLookForLabel.Size = new System.Drawing.Size(78, 13);
            this.textToLookForLabel.TabIndex = 3;
            this.textToLookForLabel.Text = "Text to look for";
            // 
            // lookForTextBox
            // 
            this.lookForTextBox.Location = new System.Drawing.Point(95, 72);
            this.lookForTextBox.Name = "lookForTextBox";
            this.lookForTextBox.Size = new System.Drawing.Size(166, 20);
            this.lookForTextBox.TabIndex = 4;
            // 
            // datePeriodLabel
            // 
            this.datePeriodLabel.AutoSize = true;
            this.datePeriodLabel.Location = new System.Drawing.Point(6, 98);
            this.datePeriodLabel.Name = "datePeriodLabel";
            this.datePeriodLabel.Size = new System.Drawing.Size(65, 13);
            this.datePeriodLabel.TabIndex = 5;
            this.datePeriodLabel.Text = "Date period:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(95, 114);
            this.fromDateTimePicker.MaxDate = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.fromDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(166, 20);
            this.fromDateTimePicker.TabIndex = 6;
            this.fromDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(95, 141);
            this.toDateTimePicker.MaxDate = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(166, 20);
            this.toDateTimePicker.TabIndex = 7;
            this.toDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Location = new System.Drawing.Point(41, 118);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(30, 13);
            this.fromDateLabel.TabIndex = 8;
            this.fromDateLabel.Text = "From";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Location = new System.Drawing.Point(41, 146);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(20, 13);
            this.toDateLabel.TabIndex = 9;
            this.toDateLabel.Text = "To";
            // 
            // andRadioButton
            // 
            this.andRadioButton.AutoSize = true;
            this.andRadioButton.Location = new System.Drawing.Point(95, 171);
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
            this.orRadioButton.Location = new System.Drawing.Point(175, 171);
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
            this.filteringLogicLabel.Location = new System.Drawing.Point(6, 172);
            this.filteringLogicLabel.Name = "filteringLogicLabel";
            this.filteringLogicLabel.Size = new System.Drawing.Size(71, 13);
            this.filteringLogicLabel.TabIndex = 12;
            this.filteringLogicLabel.Text = "Filtering logic:";
            // 
            // formattingLabel
            // 
            this.formattingLabel.AutoSize = true;
            this.formattingLabel.Location = new System.Drawing.Point(6, 228);
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
            this.formattingOptionsComboBox.Location = new System.Drawing.Point(95, 225);
            this.formattingOptionsComboBox.Name = "formattingOptionsComboBox";
            this.formattingOptionsComboBox.Size = new System.Drawing.Size(166, 21);
            this.formattingOptionsComboBox.TabIndex = 14;
            this.formattingOptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.formattingOptionsComboBox_SelectedIndexChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(168, 196);
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
            this.messagesListView.Location = new System.Drawing.Point(284, 49);
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.Size = new System.Drawing.Size(344, 301);
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
            this.resetButton.Location = new System.Drawing.Point(9, 196);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // filteringGroupBox
            // 
            this.filteringGroupBox.Controls.Add(this.resetButton);
            this.filteringGroupBox.Controls.Add(this.applyButton);
            this.filteringGroupBox.Controls.Add(this.filteringLogicLabel);
            this.filteringGroupBox.Controls.Add(this.formattingLabel);
            this.filteringGroupBox.Controls.Add(this.formattingOptionsComboBox);
            this.filteringGroupBox.Controls.Add(this.orRadioButton);
            this.filteringGroupBox.Controls.Add(this.andRadioButton);
            this.filteringGroupBox.Controls.Add(this.toDateLabel);
            this.filteringGroupBox.Controls.Add(this.fromDateLabel);
            this.filteringGroupBox.Controls.Add(this.toDateTimePicker);
            this.filteringGroupBox.Controls.Add(this.fromDateTimePicker);
            this.filteringGroupBox.Controls.Add(this.datePeriodLabel);
            this.filteringGroupBox.Controls.Add(this.lookForTextBox);
            this.filteringGroupBox.Controls.Add(this.textToLookForLabel);
            this.filteringGroupBox.Controls.Add(this.senderLabel);
            this.filteringGroupBox.Controls.Add(this.senderComboBox);
            this.filteringGroupBox.Controls.Add(this.selectFilteringLabel);
            this.filteringGroupBox.Location = new System.Drawing.Point(7, 96);
            this.filteringGroupBox.Name = "filteringGroupBox";
            this.filteringGroupBox.Size = new System.Drawing.Size(272, 254);
            this.filteringGroupBox.TabIndex = 19;
            this.filteringGroupBox.TabStop = false;
            this.filteringGroupBox.Text = "Filtering of messages";
            // 
            // generationOfMessagesGroupBox
            // 
            this.generationOfMessagesGroupBox.Controls.Add(this.startButton);
            this.generationOfMessagesGroupBox.Controls.Add(this.stopButton);
            this.generationOfMessagesGroupBox.Location = new System.Drawing.Point(7, 42);
            this.generationOfMessagesGroupBox.Name = "generationOfMessagesGroupBox";
            this.generationOfMessagesGroupBox.Size = new System.Drawing.Size(270, 48);
            this.generationOfMessagesGroupBox.TabIndex = 20;
            this.generationOfMessagesGroupBox.TabStop = false;
            this.generationOfMessagesGroupBox.Text = "Generation of messages";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(19, 17);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(93, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(159, 17);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(93, 23);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // batteryChargingGroupBox
            // 
            this.batteryChargingGroupBox.Controls.Add(this.startOrStopChargingLabel);
            this.batteryChargingGroupBox.Controls.Add(this.chargeButton);
            this.batteryChargingGroupBox.Controls.Add(this.batteryChargeProgressBar);
            this.batteryChargingGroupBox.Location = new System.Drawing.Point(7, 354);
            this.batteryChargingGroupBox.Name = "batteryChargingGroupBox";
            this.batteryChargingGroupBox.Size = new System.Drawing.Size(621, 61);
            this.batteryChargingGroupBox.TabIndex = 21;
            this.batteryChargingGroupBox.TabStop = false;
            this.batteryChargingGroupBox.Text = "Battery charging";
            // 
            // startOrStopChargingLabel
            // 
            this.startOrStopChargingLabel.AutoSize = true;
            this.startOrStopChargingLabel.Location = new System.Drawing.Point(3, 26);
            this.startOrStopChargingLabel.Name = "startOrStopChargingLabel";
            this.startOrStopChargingLabel.Size = new System.Drawing.Size(164, 13);
            this.startOrStopChargingLabel.TabIndex = 2;
            this.startOrStopChargingLabel.Text = "Start or stop charging the battery:";
            // 
            // chargeButton
            // 
            this.chargeButton.Location = new System.Drawing.Point(172, 21);
            this.chargeButton.Name = "chargeButton";
            this.chargeButton.Size = new System.Drawing.Size(93, 23);
            this.chargeButton.TabIndex = 1;
            this.chargeButton.Text = "Start / Stop";
            this.chargeButton.UseVisualStyleBackColor = true;
            this.chargeButton.Click += new System.EventHandler(this.chargeButton_Click);
            // 
            // batteryChargeProgressBar
            // 
            this.batteryChargeProgressBar.Location = new System.Drawing.Point(278, 21);
            this.batteryChargeProgressBar.Name = "batteryChargeProgressBar";
            this.batteryChargeProgressBar.Size = new System.Drawing.Size(333, 23);
            this.batteryChargeProgressBar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectApproachLabel);
            this.groupBox1.Controls.Add(this.taskApproachRadioButton);
            this.groupBox1.Controls.Add(this.threadApproachRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 40);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Approach to use";
            // 
            // selectApproachLabel
            // 
            this.selectApproachLabel.AutoSize = true;
            this.selectApproachLabel.Location = new System.Drawing.Point(6, 17);
            this.selectApproachLabel.Name = "selectApproachLabel";
            this.selectApproachLabel.Size = new System.Drawing.Size(394, 13);
            this.selectApproachLabel.TabIndex = 2;
            this.selectApproachLabel.Text = "Select an approach to be used during generation of messages or battery charging:";
            // 
            // taskApproachRadioButton
            // 
            this.taskApproachRadioButton.AutoSize = true;
            this.taskApproachRadioButton.Location = new System.Drawing.Point(525, 14);
            this.taskApproachRadioButton.Name = "taskApproachRadioButton";
            this.taskApproachRadioButton.Size = new System.Drawing.Size(54, 17);
            this.taskApproachRadioButton.TabIndex = 1;
            this.taskApproachRadioButton.TabStop = true;
            this.taskApproachRadioButton.Text = "Tasks";
            this.taskApproachRadioButton.UseVisualStyleBackColor = true;
            this.taskApproachRadioButton.CheckedChanged += new System.EventHandler(this.taskApproachRadioButton_CheckedChanged);
            // 
            // threadApproachRadioButton
            // 
            this.threadApproachRadioButton.AutoSize = true;
            this.threadApproachRadioButton.Location = new System.Drawing.Point(424, 15);
            this.threadApproachRadioButton.Name = "threadApproachRadioButton";
            this.threadApproachRadioButton.Size = new System.Drawing.Size(64, 17);
            this.threadApproachRadioButton.TabIndex = 0;
            this.threadApproachRadioButton.TabStop = true;
            this.threadApproachRadioButton.Text = "Threads";
            this.threadApproachRadioButton.UseVisualStyleBackColor = true;
            this.threadApproachRadioButton.CheckedChanged += new System.EventHandler(this.threadApproachRadioButton_CheckedChanged);
            // 
            // MessageFilteringFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.batteryChargingGroupBox);
            this.Controls.Add(this.generationOfMessagesGroupBox);
            this.Controls.Add(this.filteringGroupBox);
            this.Controls.Add(this.messagesListView);
            this.MaximizeBox = false;
            this.Name = "MessageFilteringFrom";
            this.Text = "Message Filtering and Battery Charging";
            this.Load += new System.EventHandler(this.MessageFilteringFrom_Load);
            this.filteringGroupBox.ResumeLayout(false);
            this.filteringGroupBox.PerformLayout();
            this.generationOfMessagesGroupBox.ResumeLayout(false);
            this.batteryChargingGroupBox.ResumeLayout(false);
            this.batteryChargingGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox filteringGroupBox;
        private System.Windows.Forms.GroupBox generationOfMessagesGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox batteryChargingGroupBox;
        private System.Windows.Forms.Button chargeButton;
        private System.Windows.Forms.ProgressBar batteryChargeProgressBar;
        private System.Windows.Forms.Label startOrStopChargingLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label selectApproachLabel;
        private System.Windows.Forms.RadioButton taskApproachRadioButton;
        private System.Windows.Forms.RadioButton threadApproachRadioButton;
    }
}

