using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CGLauncher
{
    public partial class AdvancedVideoSettingsForm : Form
    {
        AdvancedVideoSettings avs;
        public AdvancedVideoSettingsForm()
        {
            avs = new AdvancedVideoSettings();
            InitializeComponent();
            init();
        }

        public void init()
        {
            avs.readFile();

            string bString = "Low";
            double b = avs.getBloom();
            Console.WriteLine("BLOOM: " + b);
            if (b == 0.0)
                bString = "Off";
            if (b == 0.1)
                bString = "Low";
            if (b == 0.15)
                bString = "Medium";
            if (b == 0.3)
                bString = "High";
            bloomComboBox.SelectedIndex = bloomComboBox.FindStringExact(bString);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
           string bString = bloomComboBox.SelectedItem.ToString();
           double b = 1;
           if (bString == "Off")
               b = 0.0;
           if (bString == "Low")
               b = 0.1;
           if (bString == "Medium")
               b = 0.15;
           if (bString == "High")
               b = 0.3;
           Console.WriteLine("Bloom set to: " + b);
            avs.setBloom(b);
            avs.output();
            this.Close();
        }
    }
}
