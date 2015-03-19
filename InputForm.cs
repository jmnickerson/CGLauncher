﻿using System;
using System.Collections.Generic;
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
        public InputForm()
        {
            InitializeComponent();
            inputSettings = new InputSettings();
            setFromFile();
        }

        private void setFromFile()
        {
            System.Collections.Generic.SortedDictionary<string, string> keybinds = inputSettings.getKeybinds();
            SortedDictionary<string, TextBox> keytobox = new SortedDictionary<string, TextBox>();
            string val;
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
            }
            /*if (keybinds.TryGetValue("attack1", out val))
            {
                    primaryActionBox.Text = getDisplayString(val);
            }
            if (keybinds.TryGetValue("attack2", out val))
            {
                secondaryActionBox.Text = getDisplayString(val);
            }
            if (keybinds.TryGetValue("attack2", out val))
            {
                secondaryActionBox.Text = getDisplayString(val);
            }*/
            
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

        private void setValues()
        {
            SortedDictionary<string, string> keybinds = inputSettings.getKeybinds();
            keybinds["click1"] = "TEST";

    
           /* foreach (XElement book in query)
            {
                if
                book.Attribute("attr1").Value = "MyNewValue";
            }*/

            
        }

    }
}
