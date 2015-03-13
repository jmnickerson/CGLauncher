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
        public InputForm()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
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
                source.Text = "Left Mouse";
            }
            if (e.Button == MouseButtons.Right)
            {
                source.Text = "Right Mouse";
            }
        }
    }
}
