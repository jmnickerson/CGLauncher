namespace CGLauncher
{
    partial class MainForm
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
            this.videoSettingsButton = new System.Windows.Forms.Button();
            this.inputSettingsButton = new System.Windows.Forms.Button();
            this.AdvVideoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoSettingsButton
            // 
            this.videoSettingsButton.Location = new System.Drawing.Point(206, 128);
            this.videoSettingsButton.Name = "videoSettingsButton";
            this.videoSettingsButton.Size = new System.Drawing.Size(117, 23);
            this.videoSettingsButton.TabIndex = 0;
            this.videoSettingsButton.Text = "Video Settings";
            this.videoSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.videoSettingsButton.UseVisualStyleBackColor = true;
            this.videoSettingsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputSettingsButton
            // 
            this.inputSettingsButton.Location = new System.Drawing.Point(206, 62);
            this.inputSettingsButton.Name = "inputSettingsButton";
            this.inputSettingsButton.Size = new System.Drawing.Size(117, 23);
            this.inputSettingsButton.TabIndex = 1;
            this.inputSettingsButton.Text = "Input Settings";
            this.inputSettingsButton.UseVisualStyleBackColor = true;
            this.inputSettingsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdvVideoButton
            // 
            this.AdvVideoButton.Location = new System.Drawing.Point(179, 188);
            this.AdvVideoButton.Name = "AdvVideoButton";
            this.AdvVideoButton.Size = new System.Drawing.Size(164, 23);
            this.AdvVideoButton.TabIndex = 2;
            this.AdvVideoButton.Text = "Advanced Video Settings";
            this.AdvVideoButton.UseVisualStyleBackColor = true;
            this.AdvVideoButton.Click += new System.EventHandler(this.AdvVideoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 262);
            this.Controls.Add(this.AdvVideoButton);
            this.Controls.Add(this.inputSettingsButton);
            this.Controls.Add(this.videoSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGLaunch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button videoSettingsButton;
        private System.Windows.Forms.Button inputSettingsButton;
        private System.Windows.Forms.Button AdvVideoButton;
    }
}