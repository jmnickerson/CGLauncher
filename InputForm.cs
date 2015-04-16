using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CGLauncher
{
    public partial class InputForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        private ContextMenu blankMenu = new ContextMenu();
        private InputSettings inputSettings;
        private Dictionary<string, TextBox> keytobox;
        private List<Control> boxArray;
        private Boolean firstClick = true;
        private int selectedBox = 0;
        private bool initialized = false;
        private ControlSelectionHandler controlSection;

        public InputForm()
        {
            InitializeComponent();
            inputSettings = new InputSettings();
            keytobox = new Dictionary<string, TextBox>();
            boxArray = new List<Control>();
            setFromFile();
            controlSection = new ControlSelectionHandler(boxArray,this);
        }

        private void setFromFile()
        {
            System.Collections.Generic.Dictionary<string, string> keybinds = inputSettings.getKeybinds();
            
            //Actions
            keytobox.Add("attack1", primaryActionBox);
            keytobox.Add("attack2", secondaryActionBox);
            keytobox.Add("HUD_0", action1Box);
            keytobox.Add("HUD_1", action2Box);
            keytobox.Add("HUD_2", action3Box);
            keytobox.Add("HUD_3", action4Box);
            keytobox.Add("HUD_4", action5Box);
            keytobox.Add("HUD_5", action6Box);
            keytobox.Add("activate", interactBox);
            //Combat
            keytobox.Add("block", blockBox);
            keytobox.Add("dodge", dodgeBox);
            keytobox.Add("jump", jumpBox);
            keytobox.Add("parry", parryBox);
            //Movement
            keytobox.Add("moveforward", forwardBox);
            keytobox.Add("moveleft", leftBox);
            keytobox.Add("moveright", rightBox);
            keytobox.Add("moveback", backBox);

            foreach (KeyValuePair<string, TextBox> pair in keytobox)
            {
                string temp;
                if (keybinds.TryGetValue(pair.Key, out temp))
                    pair.Value.Text = temp;
                //Add this element to the list of Control objects for the key input selection.
                boxArray.Add(pair.Value);
            }
            this.ActiveControl = boxArray[selectedBox];
            initialized = true;
        }

        private string getDisplayString(string val)
        {
            /*if(val.Contains("mouse"))
            {
                if(val == "mouse1");
                    retur
            }
            else*/
                return val;             
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            setValues();
            inputSettings.outputFile();
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
            if(initialized)
            {
                //TextBox source = sender as TextBox;
                //Console.WriteLine("TEXT CHANGED");
                HideCaret(primaryActionBox.Handle);
                firstClick = false;
                controlSection.selectNext();
                //source.BackColor = System.Drawing.SystemColors.Window;

            }

            
            
        }

        private void textBox_MouseDown(Object sender, MouseEventArgs e)
        {
            Console.WriteLine("firstClick " + firstClick);
            TextBox source = sender as TextBox;
            if(firstClick)
            {
                source.Text = "";
                //source.BackColor = System.Drawing.SystemColors.ActiveCaption;
                firstClick = false;
            }
            else
            { 
            //source.Text = "";
               // source.BackColor = System.Drawing.SystemColors.Window;
                if (e.Button == MouseButtons.Left)
                {
                    source.Text = "mouse1";
                }
                if (e.Button == MouseButtons.Right)
                {
                    source.Text = "mouse2";
                }
                firstClick = true;
            }
        }

        private void setValues()
        {
            Dictionary<string, string> keybinds = inputSettings.getKeybinds();
            foreach (KeyValuePair<string, TextBox> pair in keytobox)
            {
                keybinds[pair.Key] = pair.Value.Text;
            }         
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Down)
            {
                controlSection.selectNext();
                return true;
            }
            if (keyData == Keys.Up)
            {
                controlSection.selectPrevious();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void textBox_Enter(object sender, EventArgs e)
        {

        }

    }
}
