namespace CGLauncher
{
    partial class VideoSettingsForm
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
            this.FullScreenBox = new System.Windows.Forms.CheckBox();
            this.vSyncBox = new System.Windows.Forms.CheckBox();
            this.MotionBlurBox = new System.Windows.Forms.CheckBox();
            this.InvertMouseBox = new System.Windows.Forms.CheckBox();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.Resolutionlabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.videoQualityLabel = new System.Windows.Forms.Label();
            this.videoQualityComboBox = new System.Windows.Forms.ComboBox();
            this.shadowQualityLabel = new System.Windows.Forms.Label();
            this.shadowQualityComboBox = new System.Windows.Forms.ComboBox();
            this.ssaoCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FullScreenBox
            // 
            this.FullScreenBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.FullScreenBox.AutoSize = true;
            this.FullScreenBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FullScreenBox.Location = new System.Drawing.Point(81, 12);
            this.FullScreenBox.Name = "FullScreenBox";
            this.FullScreenBox.Size = new System.Drawing.Size(79, 17);
            this.FullScreenBox.TabIndex = 0;
            this.FullScreenBox.Text = "Full Screen";
            this.FullScreenBox.UseVisualStyleBackColor = true;
            this.FullScreenBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vSyncBox
            // 
            this.vSyncBox.AutoSize = true;
            this.vSyncBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vSyncBox.Location = new System.Drawing.Point(103, 35);
            this.vSyncBox.Name = "vSyncBox";
            this.vSyncBox.Size = new System.Drawing.Size(57, 17);
            this.vSyncBox.TabIndex = 1;
            this.vSyncBox.Text = "VSync";
            this.vSyncBox.UseVisualStyleBackColor = true;
            this.vSyncBox.CheckedChanged += new System.EventHandler(this.vSyncBox_CheckedChanged);
            // 
            // MotionBlurBox
            // 
            this.MotionBlurBox.AutoSize = true;
            this.MotionBlurBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MotionBlurBox.Location = new System.Drawing.Point(81, 59);
            this.MotionBlurBox.Name = "MotionBlurBox";
            this.MotionBlurBox.Size = new System.Drawing.Size(79, 17);
            this.MotionBlurBox.TabIndex = 2;
            this.MotionBlurBox.Text = "Motion Blur";
            this.MotionBlurBox.UseVisualStyleBackColor = true;
            // 
            // InvertMouseBox
            // 
            this.InvertMouseBox.AutoSize = true;
            this.InvertMouseBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InvertMouseBox.Location = new System.Drawing.Point(72, 83);
            this.InvertMouseBox.Name = "InvertMouseBox";
            this.InvertMouseBox.Size = new System.Drawing.Size(88, 17);
            this.InvertMouseBox.TabIndex = 3;
            this.InvertMouseBox.Text = "Invert Mouse";
            this.InvertMouseBox.UseVisualStyleBackColor = true;
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "640 x 480",
            "800 x 600",
            "1024 x 768",
            "1152 x 864",
            "1280 x 720",
            "1280 x 768",
            "1280 x 800",
            "1280 x 960",
            "1280 x 1024",
            "1360 x 768",
            "1366 x 768",
            "1440 x 900",
            "1600 x 1024",
            "1600 x 900",
            "1600 x 1200",
            "1680 x 1050",
            "1920 x 1080",
            "1920 x 1200",
            "2560 x 1440"});
            this.resolutionComboBox.Location = new System.Drawing.Point(148, 145);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(94, 21);
            this.resolutionComboBox.TabIndex = 4;
            this.resolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Resolutionlabel
            // 
            this.Resolutionlabel.AutoSize = true;
            this.Resolutionlabel.Location = new System.Drawing.Point(74, 148);
            this.Resolutionlabel.Name = "Resolutionlabel";
            this.Resolutionlabel.Size = new System.Drawing.Size(60, 13);
            this.Resolutionlabel.TabIndex = 5;
            this.Resolutionlabel.Text = "Resolution:";
            this.Resolutionlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(197, 264);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // videoQualityLabel
            // 
            this.videoQualityLabel.AutoSize = true;
            this.videoQualityLabel.Location = new System.Drawing.Point(62, 179);
            this.videoQualityLabel.Name = "videoQualityLabel";
            this.videoQualityLabel.Size = new System.Drawing.Size(72, 13);
            this.videoQualityLabel.TabIndex = 7;
            this.videoQualityLabel.Text = "Video Quality:";
            // 
            // videoQualityComboBox
            // 
            this.videoQualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoQualityComboBox.FormattingEnabled = true;
            this.videoQualityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.videoQualityComboBox.Location = new System.Drawing.Point(148, 176);
            this.videoQualityComboBox.Name = "videoQualityComboBox";
            this.videoQualityComboBox.Size = new System.Drawing.Size(94, 21);
            this.videoQualityComboBox.TabIndex = 8;
            // 
            // shadowQualityLabel
            // 
            this.shadowQualityLabel.AutoSize = true;
            this.shadowQualityLabel.Location = new System.Drawing.Point(50, 210);
            this.shadowQualityLabel.Name = "shadowQualityLabel";
            this.shadowQualityLabel.Size = new System.Drawing.Size(84, 13);
            this.shadowQualityLabel.TabIndex = 9;
            this.shadowQualityLabel.Text = "Shadow Quality:";
            // 
            // shadowQualityComboBox
            // 
            this.shadowQualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shadowQualityComboBox.FormattingEnabled = true;
            this.shadowQualityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.shadowQualityComboBox.Location = new System.Drawing.Point(148, 207);
            this.shadowQualityComboBox.Name = "shadowQualityComboBox";
            this.shadowQualityComboBox.Size = new System.Drawing.Size(94, 21);
            this.shadowQualityComboBox.TabIndex = 10;
            // 
            // ssaoCheckBox
            // 
            this.ssaoCheckBox.AutoSize = true;
            this.ssaoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ssaoCheckBox.Location = new System.Drawing.Point(105, 107);
            this.ssaoCheckBox.Name = "ssaoCheckBox";
            this.ssaoCheckBox.Size = new System.Drawing.Size(55, 17);
            this.ssaoCheckBox.TabIndex = 14;
            this.ssaoCheckBox.Text = "SSAO";
            this.ssaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(105, 264);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 15;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 263);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // VideoSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.ssaoCheckBox);
            this.Controls.Add(this.shadowQualityComboBox);
            this.Controls.Add(this.shadowQualityLabel);
            this.Controls.Add(this.videoQualityComboBox);
            this.Controls.Add(this.videoQualityLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.Resolutionlabel);
            this.Controls.Add(this.resolutionComboBox);
            this.Controls.Add(this.InvertMouseBox);
            this.Controls.Add(this.MotionBlurBox);
            this.Controls.Add(this.vSyncBox);
            this.Controls.Add(this.FullScreenBox);
            this.Name = "VideoSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Settings";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FullScreenBox;
        private System.Windows.Forms.CheckBox vSyncBox;
        private System.Windows.Forms.CheckBox MotionBlurBox;
        private System.Windows.Forms.CheckBox InvertMouseBox;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.Label Resolutionlabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label videoQualityLabel;
        private System.Windows.Forms.ComboBox videoQualityComboBox;
        private System.Windows.Forms.Label shadowQualityLabel;
        private System.Windows.Forms.ComboBox shadowQualityComboBox;
        private System.Windows.Forms.CheckBox ssaoCheckBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
    }
}