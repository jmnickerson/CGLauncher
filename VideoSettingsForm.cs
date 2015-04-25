using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;


namespace CGLauncher
{
    public partial class VideoSettingsForm : BaseForm
    {
        private VideoSettings vs;
        
        public VideoSettingsForm() : base()
        {  
            vs = new VideoSettings();
            InitializeComponent();
            initControlSelectionHandler();
            init();
        }

        protected override void initControlSelectionHandler()
        {
            List<Control> controls = new List<Control>();
            Dictionary<Control, Label> comboBoxToLabel = new Dictionary<Control, Label>();
            initControls(controls);
            initComboBoxToLabel(comboBoxToLabel);

            controlSelection = new ControlSelectionHandler(this, controls, comboBoxToLabel);
        }

        private void initControls(List<Control> controls)
        {
            controls.Add(FullScreenBox);
            controls.Add(vSyncBox);
            controls.Add(MotionBlurBox);
            controls.Add(InvertMouseBox);
            controls.Add(ssaoCheckBox);
            controls.Add(resolutionComboBox);
            controls.Add(videoQualityComboBox);
            controls.Add(shadowQualityComboBox);
            controls.Add(cancelButton);
            controls.Add(applyButton);
            controls.Add(closeButton);

        }

        private void initComboBoxToLabel(Dictionary<Control, Label> comboBoxToLabel)
        {
            comboBoxToLabel.Add(resolutionComboBox, Resolutionlabel);
            comboBoxToLabel.Add(videoQualityComboBox, videoQualityLabel);
            comboBoxToLabel.Add(shadowQualityComboBox, shadowQualityLabel);
        }

        public void init()
        {
            vs.readFile();

            FullScreenBox.Checked = vs.getFullscreen();
            vSyncBox.Checked = vs.getVSync();
            MotionBlurBox.Checked = vs.getMotionBlur();
            InvertMouseBox.Checked = vs.getInvertMouse();
            ssaoCheckBox.Checked = vs.getSSAO();

            resolutionComboBox.SelectedIndex = resolutionComboBox.FindStringExact(vs.getResx() + " x " + vs.getResy());

            string vqString = "Low";
            int vq = vs.getVideoQuality();
            if (vq == 1)
                vqString = "Low";
            if (vq == 2)
                vqString = "Medium";
            if (vq == 3)
                vqString = "High";
            if (vq == 4)
                vqString = "Ultra";
            videoQualityComboBox.SelectedIndex = videoQualityComboBox.FindStringExact(vqString);

            string sqString = "Low";
            int sq = vs.getShadowQuality();
            if (sq == 256)
                sqString = "Low";
            if (sq == 512)
                sqString = "Medium";
            if (sq == 1024)
                sqString = "High";
            shadowQualityComboBox.SelectedIndex = shadowQualityComboBox.FindStringExact(sqString);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            applyButton.PerformClick();   
            this.Close();
        }
   
        private void vSyncBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            vs.setFullscreen(FullScreenBox.Checked);
            vs.setVSync(vSyncBox.Checked);
            vs.setMotionBlur(MotionBlurBox.Checked);
            vs.setInvertMouse(InvertMouseBox.Checked);
            vs.setSSAO(ssaoCheckBox.Checked);

            string[] resoltions = resolutionComboBox.SelectedItem.ToString().Split('x');
            int resx = int.Parse(Regex.Match(resoltions[0], @"\d+").Value, NumberFormatInfo.InvariantInfo);
            int resy = int.Parse(Regex.Match(resoltions[1], @"\d+").Value, NumberFormatInfo.InvariantInfo);
            vs.setResx(resx);
            vs.setResy(resy);

            string vqString = videoQualityComboBox.SelectedItem.ToString();
            int vq = 1;
            if (vqString == "Low")
                vq = 1;
            if (vqString == "Medium")
                vq = 2;
            if (vqString == "High")
                vq = 3;
            if (vqString == "Ultra")
                vq = 4;
            vs.setVideoQuality(vq);

            string sqString = shadowQualityComboBox.SelectedItem.ToString();
            int sq = 1;
            if (sqString == "Low")
                sq = 256;
            if (sqString == "Medium")
                sq = 512;
            if (sqString == "High")
                sq = 1024;
            vs.setShadowQuality(sq);
            vs.output();
        }
    }
}
