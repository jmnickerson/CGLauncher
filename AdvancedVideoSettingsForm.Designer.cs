namespace CGLauncher
{
    partial class AdvancedVideoSettingsForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.bloomComboBox = new System.Windows.Forms.ComboBox();
            this.bloomLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(200, 208);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // bloomComboBox
            // 
            this.bloomComboBox.FormattingEnabled = true;
            this.bloomComboBox.Items.AddRange(new object[] {
            "Off",
            "Low",
            "Medium",
            "High"});
            this.bloomComboBox.Location = new System.Drawing.Point(126, 59);
            this.bloomComboBox.Name = "bloomComboBox";
            this.bloomComboBox.Size = new System.Drawing.Size(94, 21);
            this.bloomComboBox.TabIndex = 0;
            // 
            // bloomLabel
            // 
            this.bloomLabel.AutoSize = true;
            this.bloomLabel.Location = new System.Drawing.Point(77, 62);
            this.bloomLabel.Name = "bloomLabel";
            this.bloomLabel.Size = new System.Drawing.Size(42, 13);
            this.bloomLabel.TabIndex = 13;
            this.bloomLabel.Text = "Bloom: ";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 208);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(107, 208);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // AdvancedVideoSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 263);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bloomComboBox);
            this.Controls.Add(this.bloomLabel);
            this.Controls.Add(this.CloseButton);
            this.Name = "AdvancedVideoSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedVideoSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox bloomComboBox;
        private System.Windows.Forms.Label bloomLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
    }
}