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
    public partial class InputForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        private ContextMenu blankMenu = new ContextMenu();
        private InputSettings inputSettings;
        public InputForm()
        {
            InitializeComponent();
            inputSettings = new InputSettings();
            setFromFile();
        }

        private void setFromFile()
        {
            System.Collections.Generic.SortedDictionary<string, string> keybinds = inputSettings.getKeybinds();
            string val;

            if (keybinds.TryGetValue("click1", out val))
            {
                primaryActionBox.Text = "Mouse 1";
            }
            if (keybinds.TryGetValue("click2", out val))
            {
                secondaryActionBox.Text = "Mouse 2";
            }
            
 
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            outputFile();
            this.Close();
        }

        private void jumplabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("TEXT CHANGED");
            HideCaret(primaryActionBox.Handle);
            
        }

        private void textBox_MouseDown(Object sender, MouseEventArgs e)
        {
            TextBox source = sender as TextBox;
            if (e.Button == MouseButtons.Left)
            {
                source.Text = "Mouse 1";
            }
            if (e.Button == MouseButtons.Right)
            {
                source.Text = "Mouse 2";
            }
        }

        private void outputFile()
        {

        }


    }
}
