using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;


namespace CGLauncher
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            //setRSS();
            initControlSelectionHandler();
            controlSelection.select();
        }


        protected override void initControlSelectionHandler()
        {
            List<Control> controls = new List<Control>();
            Dictionary<Control, Label> comboBoxToLabel = new Dictionary<Control, Label>();
            controls.Add(inputSettingsButton);
            controls.Add(videoSettingsButton);
            controls.Add(AdvVideoButton);
            controls.Add(startButton);

            controlSelection = new ControlSelectionHandler(this, controls, comboBoxToLabel);
        }

        private void setRSS()
        {
            string url = "http://steamcommunity.com/games/268670/rss/";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            TextSyndicationContent text = feed.Items.First().Summary;
            string source = text.Text;
            string summary = source.Replace("<br>", "");
            var reg1 = new Regex("<.*?>");
            string reg2 = "<.*?>";
            summary = Regex.Replace(source, reg2, string.Empty);

            for (int i = 0; i < summary.Length; i++)
            {
                if (summary[i] == '\n')
                {
                    if (i + 1 < summary.Length && summary[i + 1] == '\n')
                    {
                        summary = summary.Remove(i + 1, 1);
                    }
                }
            }

            List<string> lines = new List<string>(summary.Split(new string[] { "\n" }, StringSplitOptions.None));
            /*for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Length <= 30)
                {
                    Console.WriteLine("long line");
                }
            }*/
            var reg = new Regex("\".*?\"");
            var matches = reg.Matches(source);
            string image = matches[0].ToString();
            image = image.Replace("\"", "");
            //Console.WriteLine(image);
            newsBodyLabel.Text = summary;
            newsTitleLabel.Text = feed.Items.First().Title.Text;
            if (!string.IsNullOrEmpty(image))
            {
                newsPictureBox.ImageLocation = image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            VideoSettingsForm vsf = new VideoSettingsForm();
            vsf.Show();
            vsf.init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputForm inputform = new InputForm();
            inputform.Show();
        }

        private void AdvVideoButton_Click(object sender, EventArgs e)
        {
            AdvancedVideoSettingsForm avsf = new AdvancedVideoSettingsForm();
            avsf.Show();
        }

        private void newsBodyLabel_Click(object sender, EventArgs e)
        {

        }

        private void newsPictureBox_Click(object sender, EventArgs e)
        {

        }


    }
}
