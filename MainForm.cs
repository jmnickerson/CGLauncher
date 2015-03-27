using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CGLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string url = "";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            /*foreach (SyndicationItem item in feed.Items)
            {
            String subject = item.Title.Text;    
            String summary = item.Summary.Text;
            Console.WriteLine("Subject: " + subject + " Summary: " + summary);
            */
            newsBodyLabel.Text = feed.Items.First().Summary.Text;
            newsTitleLabel.Text = feed.Items.First().Title.Text;
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
    }
}
