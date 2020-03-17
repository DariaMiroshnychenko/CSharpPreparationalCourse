namespace SimCorp.IMS.Course.WinFormsApplication
{
    partial class SelectAndRunComponentForm
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
            this.components = new System.ComponentModel.Container();
            this.menuTitleLabel = new System.Windows.Forms.Label();
            this.playbackComponentRadioButton = new System.Windows.Forms.RadioButton();
            this.chargerRadioButton = new System.Windows.Forms.RadioButton();
            this.removableStorageRadioButton = new System.Windows.Forms.RadioButton();
            this.simCardRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.componentTypeMenuRichTextBox = new System.Windows.Forms.RichTextBox();
            this.userChoiseLabel = new System.Windows.Forms.Label();
            this.chosenComponentTypeIndex = new System.Windows.Forms.TextBox();
            this.outputOfSettingAndRunningComponentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.vodafoneSimCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vodafoneSimCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTitleLabel
            // 
            this.menuTitleLabel.AutoSize = true;
            this.menuTitleLabel.Location = new System.Drawing.Point(8, 16);
            this.menuTitleLabel.Name = "menuTitleLabel";
            this.menuTitleLabel.Size = new System.Drawing.Size(289, 13);
            this.menuTitleLabel.TabIndex = 2;
            this.menuTitleLabel.Text = "Select component which you would like to set to the phone:";
            // 
            // playbackComponentRadioButton
            // 
            this.playbackComponentRadioButton.AutoSize = true;
            this.playbackComponentRadioButton.Location = new System.Drawing.Point(12, 42);
            this.playbackComponentRadioButton.Name = "playbackComponentRadioButton";
            this.playbackComponentRadioButton.Size = new System.Drawing.Size(125, 17);
            this.playbackComponentRadioButton.TabIndex = 3;
            this.playbackComponentRadioButton.TabStop = true;
            this.playbackComponentRadioButton.Text = "Playback component";
            this.playbackComponentRadioButton.UseVisualStyleBackColor = true;
            // 
            // chargerRadioButton
            // 
            this.chargerRadioButton.AutoSize = true;
            this.chargerRadioButton.Location = new System.Drawing.Point(12, 65);
            this.chargerRadioButton.Name = "chargerRadioButton";
            this.chargerRadioButton.Size = new System.Drawing.Size(62, 17);
            this.chargerRadioButton.TabIndex = 4;
            this.chargerRadioButton.TabStop = true;
            this.chargerRadioButton.Text = "Charger";
            this.chargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // removableStorageRadioButton
            // 
            this.removableStorageRadioButton.AutoSize = true;
            this.removableStorageRadioButton.Location = new System.Drawing.Point(12, 88);
            this.removableStorageRadioButton.Name = "removableStorageRadioButton";
            this.removableStorageRadioButton.Size = new System.Drawing.Size(117, 17);
            this.removableStorageRadioButton.TabIndex = 5;
            this.removableStorageRadioButton.TabStop = true;
            this.removableStorageRadioButton.Text = "Removable storage";
            this.removableStorageRadioButton.UseVisualStyleBackColor = true;
            // 
            // simCardRadioButton
            // 
            this.simCardRadioButton.AutoSize = true;
            this.simCardRadioButton.Location = new System.Drawing.Point(12, 111);
            this.simCardRadioButton.Name = "simCardRadioButton";
            this.simCardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.simCardRadioButton.TabIndex = 6;
            this.simCardRadioButton.TabStop = true;
            this.simCardRadioButton.Text = "SIM card";
            this.simCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(320, 123);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // componentTypeMenuRichTextBox
            // 
            this.componentTypeMenuRichTextBox.Location = new System.Drawing.Point(16, 152);
            this.componentTypeMenuRichTextBox.Name = "componentTypeMenuRichTextBox";
            this.componentTypeMenuRichTextBox.ReadOnly = true;
            this.componentTypeMenuRichTextBox.Size = new System.Drawing.Size(379, 129);
            this.componentTypeMenuRichTextBox.TabIndex = 8;
            this.componentTypeMenuRichTextBox.Text = "";
            this.componentTypeMenuRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // userChoiseLabel
            // 
            this.userChoiseLabel.AutoSize = true;
            this.userChoiseLabel.Location = new System.Drawing.Point(212, 291);
            this.userChoiseLabel.Name = "userChoiseLabel";
            this.userChoiseLabel.Size = new System.Drawing.Size(66, 13);
            this.userChoiseLabel.TabIndex = 10;
            this.userChoiseLabel.Text = "Your choise:";
            // 
            // chosenComponentTypeIndex
            // 
            this.chosenComponentTypeIndex.Location = new System.Drawing.Point(284, 288);
            this.chosenComponentTypeIndex.Name = "chosenComponentTypeIndex";
            this.chosenComponentTypeIndex.Size = new System.Drawing.Size(30, 20);
            this.chosenComponentTypeIndex.TabIndex = 11;
            this.chosenComponentTypeIndex.TextChanged += new System.EventHandler(this.chosenComponentTypeIndex_TextChanged);
            // 
            // outputOfSettingAndRunningComponentRichTextBox
            // 
            this.outputOfSettingAndRunningComponentRichTextBox.Location = new System.Drawing.Point(16, 319);
            this.outputOfSettingAndRunningComponentRichTextBox.Name = "outputOfSettingAndRunningComponentRichTextBox";
            this.outputOfSettingAndRunningComponentRichTextBox.ReadOnly = true;
            this.outputOfSettingAndRunningComponentRichTextBox.Size = new System.Drawing.Size(379, 155);
            this.outputOfSettingAndRunningComponentRichTextBox.TabIndex = 12;
            this.outputOfSettingAndRunningComponentRichTextBox.Text = "";
            this.outputOfSettingAndRunningComponentRichTextBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(320, 286);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 13;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // vodafoneSimCardBindingSource
            // 
            this.vodafoneSimCardBindingSource.DataSource = typeof(SimCorp.IMS.Course.VodafoneSimCard);
            // 
            // SelectAndRunComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 486);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.outputOfSettingAndRunningComponentRichTextBox);
            this.Controls.Add(this.chosenComponentTypeIndex);
            this.Controls.Add(this.userChoiseLabel);
            this.Controls.Add(this.componentTypeMenuRichTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.simCardRadioButton);
            this.Controls.Add(this.removableStorageRadioButton);
            this.Controls.Add(this.chargerRadioButton);
            this.Controls.Add(this.playbackComponentRadioButton);
            this.Controls.Add(this.menuTitleLabel);
            this.Name = "SelectAndRunComponentForm";
            this.Text = "Select component for the phone";
            ((System.ComponentModel.ISupportInitialize)(this.vodafoneSimCardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label menuTitleLabel;
        private System.Windows.Forms.RadioButton playbackComponentRadioButton;
        private System.Windows.Forms.RadioButton chargerRadioButton;
        private System.Windows.Forms.RadioButton removableStorageRadioButton;
        private System.Windows.Forms.RadioButton simCardRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.BindingSource vodafoneSimCardBindingSource;
        private System.Windows.Forms.RichTextBox componentTypeMenuRichTextBox;
        private System.Windows.Forms.Label userChoiseLabel;
        private System.Windows.Forms.TextBox chosenComponentTypeIndex;
        private System.Windows.Forms.RichTextBox outputOfSettingAndRunningComponentRichTextBox;
        private System.Windows.Forms.Button selectButton;
    }
}

