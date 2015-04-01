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
            this.newsTitleLabel = new System.Windows.Forms.Label();
            this.newsBodyLabel = new System.Windows.Forms.Label();
            this.newsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSettingsButton
            // 
            this.videoSettingsButton.Location = new System.Drawing.Point(97, 127);
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
            this.inputSettingsButton.Location = new System.Drawing.Point(97, 72);
            this.inputSettingsButton.Name = "inputSettingsButton";
            this.inputSettingsButton.Size = new System.Drawing.Size(117, 23);
            this.inputSettingsButton.TabIndex = 1;
            this.inputSettingsButton.Text = "Input Settings";
            this.inputSettingsButton.UseVisualStyleBackColor = true;
            this.inputSettingsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdvVideoButton
            // 
            this.AdvVideoButton.Location = new System.Drawing.Point(70, 188);
            this.AdvVideoButton.Name = "AdvVideoButton";
            this.AdvVideoButton.Size = new System.Drawing.Size(164, 23);
            this.AdvVideoButton.TabIndex = 2;
            this.AdvVideoButton.Text = "Advanced Video Settings";
            this.AdvVideoButton.UseVisualStyleBackColor = true;
            this.AdvVideoButton.Click += new System.EventHandler(this.AdvVideoButton_Click);
            // 
            // newsTitleLabel
            // 
            this.newsTitleLabel.AutoSize = true;
            this.newsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsTitleLabel.Location = new System.Drawing.Point(437, 22);
            this.newsTitleLabel.Name = "newsTitleLabel";
            this.newsTitleLabel.Size = new System.Drawing.Size(102, 25);
            this.newsTitleLabel.TabIndex = 3;
            this.newsTitleLabel.Text = "RSS Title";
            // 
            // newsBodyLabel
            // 
            this.newsBodyLabel.AutoSize = true;
            this.newsBodyLabel.Location = new System.Drawing.Point(349, 246);
            this.newsBodyLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.newsBodyLabel.Name = "newsBodyLabel";
            this.newsBodyLabel.Size = new System.Drawing.Size(299, 26);
            this.newsBodyLabel.TabIndex = 4;
            this.newsBodyLabel.Text = "RSS Body test test test test test test test test test test test test test test te" +
    "st";
            this.newsBodyLabel.Click += new System.EventHandler(this.newsBodyLabel_Click);
            // 
            // newsPictureBox
            // 
            this.newsPictureBox.Location = new System.Drawing.Point(379, 63);
            this.newsPictureBox.Name = "newsPictureBox";
            this.newsPictureBox.Size = new System.Drawing.Size(202, 148);
            this.newsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newsPictureBox.TabIndex = 5;
            this.newsPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 363);
            this.Controls.Add(this.newsPictureBox);
            this.Controls.Add(this.newsBodyLabel);
            this.Controls.Add(this.newsTitleLabel);
            this.Controls.Add(this.AdvVideoButton);
            this.Controls.Add(this.inputSettingsButton);
            this.Controls.Add(this.videoSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGLaunch";
            ((System.ComponentModel.ISupportInitialize)(this.newsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button videoSettingsButton;
        private System.Windows.Forms.Button inputSettingsButton;
        private System.Windows.Forms.Button AdvVideoButton;
        private System.Windows.Forms.Label newsTitleLabel;
        private System.Windows.Forms.Label newsBodyLabel;
        private System.Windows.Forms.PictureBox newsPictureBox;
    }
}