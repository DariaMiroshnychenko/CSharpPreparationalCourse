namespace SimCorp.IMS.Course.WinFormsApplication
{
    partial class CallsForm
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
            this.selectCallsViewLabel = new System.Windows.Forms.Label();
            this.singleViewRadioButton = new System.Windows.Forms.RadioButton();
            this.groupViewRadioButton = new System.Windows.Forms.RadioButton();
            this.callsListView = new System.Windows.Forms.ListView();
            this.ContactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.generateCallsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.callsGenerationGroupBox = new System.Windows.Forms.GroupBox();
            this.viewSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CallDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.callsGenerationGroupBox.SuspendLayout();
            this.viewSelectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectCallsViewLabel
            // 
            this.selectCallsViewLabel.AutoSize = true;
            this.selectCallsViewLabel.Location = new System.Drawing.Point(6, 24);
            this.selectCallsViewLabel.Name = "selectCallsViewLabel";
            this.selectCallsViewLabel.Size = new System.Drawing.Size(89, 13);
            this.selectCallsViewLabel.TabIndex = 0;
            this.selectCallsViewLabel.Text = "Select calls view:";
            // 
            // singleViewRadioButton
            // 
            this.singleViewRadioButton.AutoSize = true;
            this.singleViewRadioButton.Location = new System.Drawing.Point(131, 11);
            this.singleViewRadioButton.Name = "singleViewRadioButton";
            this.singleViewRadioButton.Size = new System.Drawing.Size(79, 17);
            this.singleViewRadioButton.TabIndex = 1;
            this.singleViewRadioButton.TabStop = true;
            this.singleViewRadioButton.Text = "Single view";
            this.singleViewRadioButton.UseVisualStyleBackColor = true;
            this.singleViewRadioButton.CheckedChanged += new System.EventHandler(this.singleViewRadioButton_CheckedChanged);
            // 
            // groupViewRadioButton
            // 
            this.groupViewRadioButton.AutoSize = true;
            this.groupViewRadioButton.Location = new System.Drawing.Point(131, 31);
            this.groupViewRadioButton.Name = "groupViewRadioButton";
            this.groupViewRadioButton.Size = new System.Drawing.Size(79, 17);
            this.groupViewRadioButton.TabIndex = 2;
            this.groupViewRadioButton.TabStop = true;
            this.groupViewRadioButton.Text = "Group view";
            this.groupViewRadioButton.UseVisualStyleBackColor = true;
            this.groupViewRadioButton.CheckedChanged += new System.EventHandler(this.groupViewRadioButton_CheckedChanged);
            // 
            // callsListView
            // 
            this.callsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContactName,
            this.CallDirection,
            this.CallTime,
            this.PhoneNumber,
            this.CallDuration});
            this.callsListView.GridLines = true;
            this.callsListView.Location = new System.Drawing.Point(10, 71);
            this.callsListView.Name = "callsListView";
            this.callsListView.Size = new System.Drawing.Size(511, 311);
            this.callsListView.TabIndex = 3;
            this.callsListView.UseCompatibleStateImageBehavior = false;
            this.callsListView.View = System.Windows.Forms.View.Details;
            this.callsListView.SelectedIndexChanged += new System.EventHandler(this.callsListView_SelectedIndexChanged);
            // 
            // ContactName
            // 
            this.ContactName.Text = "Contact";
            this.ContactName.Width = 110;
            // 
            // CallDirection
            // 
            this.CallDirection.Text = "In / out";
            this.CallDirection.Width = 70;
            // 
            // CallTime
            // 
            this.CallTime.Text = "Time";
            this.CallTime.Width = 150;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone number";
            this.PhoneNumber.Width = 100;
            // 
            // generateCallsLabel
            // 
            this.generateCallsLabel.AutoSize = true;
            this.generateCallsLabel.Location = new System.Drawing.Point(6, 25);
            this.generateCallsLabel.Name = "generateCallsLabel";
            this.generateCallsLabel.Size = new System.Drawing.Size(120, 13);
            this.generateCallsLabel.TabIndex = 4;
            this.generateCallsLabel.Text = "Generate a new call list:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(142, 20);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Generate";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // callsGenerationGroupBox
            // 
            this.callsGenerationGroupBox.Controls.Add(this.generateCallsLabel);
            this.callsGenerationGroupBox.Controls.Add(this.startButton);
            this.callsGenerationGroupBox.Location = new System.Drawing.Point(10, 8);
            this.callsGenerationGroupBox.Name = "callsGenerationGroupBox";
            this.callsGenerationGroupBox.Size = new System.Drawing.Size(247, 57);
            this.callsGenerationGroupBox.TabIndex = 6;
            this.callsGenerationGroupBox.TabStop = false;
            this.callsGenerationGroupBox.Text = "Calls generation";
            // 
            // viewSelectionGroupBox
            // 
            this.viewSelectionGroupBox.Controls.Add(this.groupViewRadioButton);
            this.viewSelectionGroupBox.Controls.Add(this.singleViewRadioButton);
            this.viewSelectionGroupBox.Controls.Add(this.selectCallsViewLabel);
            this.viewSelectionGroupBox.Location = new System.Drawing.Point(263, 8);
            this.viewSelectionGroupBox.Name = "viewSelectionGroupBox";
            this.viewSelectionGroupBox.Size = new System.Drawing.Size(258, 57);
            this.viewSelectionGroupBox.TabIndex = 7;
            this.viewSelectionGroupBox.TabStop = false;
            this.viewSelectionGroupBox.Text = "View selection";
            // 
            // CallDuration
            // 
            this.CallDuration.Text = "Duration";
            // 
            // CallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 390);
            this.Controls.Add(this.viewSelectionGroupBox);
            this.Controls.Add(this.callsGenerationGroupBox);
            this.Controls.Add(this.callsListView);
            this.MaximizeBox = false;
            this.Name = "CallsForm";
            this.Text = "Calls";
            this.Load += new System.EventHandler(this.MessagesForm_Load);
            this.callsGenerationGroupBox.ResumeLayout(false);
            this.callsGenerationGroupBox.PerformLayout();
            this.viewSelectionGroupBox.ResumeLayout(false);
            this.viewSelectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectCallsViewLabel;
        private System.Windows.Forms.RadioButton singleViewRadioButton;
        private System.Windows.Forms.RadioButton groupViewRadioButton;
        private System.Windows.Forms.ListView callsListView;
        private System.Windows.Forms.ColumnHeader ContactName;
        private System.Windows.Forms.ColumnHeader CallTime;
        private System.Windows.Forms.ColumnHeader CallDirection;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.Label generateCallsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox callsGenerationGroupBox;
        private System.Windows.Forms.GroupBox viewSelectionGroupBox;
        private System.Windows.Forms.ColumnHeader CallDuration;
    }
}

