namespace SimCorp.IMS.Course.WinFormsApplication
{
    partial class LinkedCallsForm
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
            this.linkedCallsListView = new System.Windows.Forms.ListView();
            this.ContactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkedCallsLabel = new System.Windows.Forms.Label();
            this.CallDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // linkedCallsListView
            // 
            this.linkedCallsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContactName,
            this.CallDirection,
            this.CallTime,
            this.PhoneNumber,
            this.CallDuration});
            this.linkedCallsListView.GridLines = true;
            this.linkedCallsListView.Location = new System.Drawing.Point(8, 36);
            this.linkedCallsListView.Name = "linkedCallsListView";
            this.linkedCallsListView.Size = new System.Drawing.Size(510, 145);
            this.linkedCallsListView.TabIndex = 0;
            this.linkedCallsListView.UseCompatibleStateImageBehavior = false;
            this.linkedCallsListView.View = System.Windows.Forms.View.Details;
            // 
            // ContactName
            // 
            this.ContactName.Text = "Name";
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
            // linkedCallsLabel
            // 
            this.linkedCallsLabel.AutoSize = true;
            this.linkedCallsLabel.Location = new System.Drawing.Point(5, 11);
            this.linkedCallsLabel.Name = "linkedCallsLabel";
            this.linkedCallsLabel.Size = new System.Drawing.Size(157, 13);
            this.linkedCallsLabel.TabIndex = 1;
            this.linkedCallsLabel.Text = "Calls linked to the selected one:";
            // 
            // CallDuration
            // 
            this.CallDuration.Text = "Duration";
            // 
            // LinkedCallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 189);
            this.Controls.Add(this.linkedCallsLabel);
            this.Controls.Add(this.linkedCallsListView);
            this.MaximizeBox = false;
            this.Name = "LinkedCallsForm";
            this.Text = "Linked calls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label linkedCallsLabel;
        private System.Windows.Forms.ColumnHeader ContactName;
        private System.Windows.Forms.ColumnHeader CallDirection;
        private System.Windows.Forms.ColumnHeader CallTime;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        internal System.Windows.Forms.ListView linkedCallsListView;
        private System.Windows.Forms.ColumnHeader CallDuration;
    }
}