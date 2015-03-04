using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryLaunch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
