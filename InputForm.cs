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
using SlimDX;
using SlimDX.XInput;

namespace CGLauncher
{
    public partial class InputForm : BaseForm
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        private ContextMenu blankMenu = new ContextMenu();
        private InputSettings inputSettings;
        private Dictionary<string, TextBox> keytobox;
        private List<Control> boxArray;
        private Boolean firstClick = true;
        TextBox firstClickBox;
        private int selectedBox = 0;
        private bool initialized = false;

        

        public InputForm() : base()
        {
            InitializeComponent();
            inputSettings = new InputSettings();
            keytobox = new Dictionary<string, TextBox>();
            boxArray = new List<Control>();
            initControlSelectionHandler();
            setFromFile();
            if (controller.IsConnected)
                controllerRadioButton.Checked = true;
            else
                keyboardRadioButton.Checked = true;
            
            //It seems like there should be a better way to do this.
            primaryActionBox.ContextMenu = new ContextMenu();
            secondaryActionBox.ContextMenu = new ContextMenu();
            action1Box.ContextMenu = new ContextMenu();
            action2Box.ContextMenu = new ContextMenu();
            action3Box.ContextMenu = new ContextMenu();
            action4Box.ContextMenu = new ContextMenu();
            action5Box.ContextMenu = new ContextMenu();
            action6Box.ContextMenu = new ContextMenu();
            interactBox.ContextMenu = new ContextMenu();

            blockBox.ContextMenu = new ContextMenu();
            dodgeBox.ContextMenu = new ContextMenu();
            jumpBox.ContextMenu = new ContextMenu();
            parryBox.ContextMenu = new ContextMenu();

            forwardBox.ContextMenu = new ContextMenu();
            leftBox.ContextMenu = new ContextMenu();
            rightBox.ContextMenu = new ContextMenu();
            backBox.ContextMenu = new ContextMenu();

            cancelbutton.ContextMenu = new ContextMenu();
            applybutton.ContextMenu = new ContextMenu();
            closebutton.ContextMenu = new ContextMenu();
        }

        protected override void initControlSelectionHandler()
        {
            List<Control> controls = new List<Control>();
            Dictionary<Control, Label> comboBoxToLabel = new Dictionary<Control,Label>();
            initControls(controls);
            initComboBoxToLabel(comboBoxToLabel);

            controlSelection = new ControlSelectionHandler(this, controls,comboBoxToLabel);
        }

        private void initControls(List<Control> controls)
        {
            controls.Add(primaryActionBox);
            controls.Add(secondaryActionBox);
            controls.Add(action1Box);
            controls.Add(action2Box);
            controls.Add(action3Box);
            controls.Add(action4Box);
            controls.Add(action5Box);
            controls.Add(action6Box);
            controls.Add(interactBox);

            controls.Add(blockBox);
            controls.Add(dodgeBox);
            controls.Add(jumpBox);
            controls.Add(parryBox);

            controls.Add(forwardBox);
            controls.Add(leftBox);
            controls.Add(rightBox);
            controls.Add(backBox);

            controls.Add(cancelbutton);
            controls.Add(applybutton);
            controls.Add(closebutton);
        }

        private void initComboBoxToLabel(Dictionary<Control, Label> comboBoxToLabel)
        {
            comboBoxToLabel.Add(primaryActionBox,primaryActionLabel);
            comboBoxToLabel.Add(secondaryActionBox,secondaryActionLabel);
            comboBoxToLabel.Add(action1Box,action1label);
            comboBoxToLabel.Add(action2Box,action2label);
            comboBoxToLabel.Add(action3Box, action3label);
            comboBoxToLabel.Add(action4Box, action4label);
            comboBoxToLabel.Add(action5Box, action5label);
            comboBoxToLabel.Add(action6Box, action6label);
            comboBoxToLabel.Add(interactBox, interactlabel);

            comboBoxToLabel.Add(blockBox,blocklabel);
            comboBoxToLabel.Add(dodgeBox,dodgelabel);
            comboBoxToLabel.Add(jumpBox,jumplabel);
            comboBoxToLabel.Add(parryBox,parrylabel);

            comboBoxToLabel.Add(forwardBox,forwardlabel2);
            comboBoxToLabel.Add(leftBox,leftlabel);
            comboBoxToLabel.Add(rightBox,rightlabel);
            comboBoxToLabel.Add(backBox,backlabel);
        }

        private void setFromFile()
        {
            Dictionary<string, string> keybinds = inputSettings.getKeybinds();
            keytobox.Clear();
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
            //inputSettings.outputFile();
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
                //Console.WriteLine("Text changed by: " + sender.ToString());
                //TextBox source = sender as TextBox;
                //Console.WriteLine("TEXT CHANGED");
                HideCaret(primaryActionBox.Handle);

                if (sender is TextBox)
                {
                    TextBox box = sender as TextBox;
                    if (box.Text == " ")
                        box.Text = "space";
                    if (box.Text.Length == 2)
                    {
                        //Console.WriteLine("Length is 2");
                        box.Text = box.Text[1].ToString();
                    }
                }

                if (firstClick)
                {
                    firstClick = false;
                    return;
                }
                
                //source.BackColor = System.Drawing.SystemColors.Window;
                if (sender is TextBox)
                {
                    if (!(sender as TextBox).Text.Contains("xi"))
                        controlSelection.selectNext();
                }
                
            }

            
            
        }

        private void textBox_MouseDown(Object sender, MouseEventArgs e)
        {
            //Console.WriteLine("firstClick " + firstClick);
            if (firstClickBox == null)
                firstClickBox = sender as TextBox;

            TextBox source = sender as TextBox;
            if (firstClickBox != source)
            {
                //Console.WriteLine("Not the same as the source");
                firstClick = true;
            }
            firstClickBox = source;
            controlSelection.select(source);
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
            Dictionary<string, string> controllerBinds = inputSettings.getControllerbinds();
            if(keyboardRadioButton.Checked)
                foreach (KeyValuePair<string, TextBox> pair in keytobox)
                {
                    keybinds[pair.Key] = pair.Value.Text;
                }
            if (controllerRadioButton.Checked)
                foreach (KeyValuePair<string, TextBox> pair in keytobox)
                {
                    controllerBinds[pair.Key] = pair.Value.Text;
                }
            inputSettings.outputFile();
        }
        /*protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Down)
            {
                controlSelection.selectNext();
                return true;
            }
            if (keyData == Keys.Up)
            {
                controlSelection.selectPrevious();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }*/



        private void textBox_Enter(object sender, EventArgs e)
        {

        }

        private void keyboardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            controllerRadioButton.Checked = !keyboardRadioButton.Checked;
            if (keyboardRadioButton.Checked)
            {
                loadKeybinds();
                movementBox.Enabled = true;
            }
        }

        private void controllerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            keyboardRadioButton.Checked = !controllerRadioButton.Checked;
            if (controllerRadioButton.Checked)
            {
                loadControllerKeybinds();
                movementBox.Enabled = false;
            }
        }
        private void loadControllerKeybinds()
        {
            //Console.WriteLine("Loading Controller Keybinds");
            setFromFile();
            Dictionary<string, string> controllerbinds = inputSettings.getControllerbinds();
            foreach (KeyValuePair<string, TextBox> pair in keytobox)
            {
                string temp;
                if (controllerbinds.TryGetValue(pair.Key, out temp))
                    pair.Value.Text = temp;
                else
                    pair.Value.Text = "";
            }
            setValues();
            
            controlSelection.selectFirst();
        }
        private void loadKeybinds()
        {
            //Console.WriteLine("Loading Keyboard Keybinds");
            setFromFile();
            Dictionary<string, string> keybinds = inputSettings.getKeybinds();
            foreach (KeyValuePair<string, TextBox> pair in keytobox)
            {
                string temp;
                if (keybinds.TryGetValue(pair.Key, out temp))
                    pair.Value.Text = temp;
                else
                    pair.Value.Text = "";
            }
            setValues();
            
            controlSelection.selectFirst();
        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\t' || e.KeyChar== (char)13)
                e.Handled = true;
        }

        private void txtShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                //Console.WriteLine("Left Shift Pressed");
                if (controlSelection.getCurrentControl() is TextBox)
                    (controlSelection.getCurrentControl() as TextBox).Text = "tab";
            }
            if (e.KeyCode == Keys.LControlKey)
            {
                //Console.WriteLine("Left Control Key");
            }
            if (e.Control)
            {
                //Console.WriteLine("CONTROL PRESSED");
                if (controlSelection.getCurrentControl() is TextBox)
                    (controlSelection.getCurrentControl() as TextBox).Text = "lctrl";
            }
            if (e.Shift)
            {
               // Console.WriteLine("CONTROL PRESSED");
                if (controlSelection.getCurrentControl() is TextBox)
                    (controlSelection.getCurrentControl() as TextBox).Text = "lshift";
            }
         
            if (e.Alt)
            {
               // Console.WriteLine("CONTROL PRESSED");
                if (controlSelection.getCurrentControl() is TextBox)
                    (controlSelection.getCurrentControl() as TextBox).Text = "lalt";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            //if (keyData == Keys.L)
               // Console.WriteLine("L pressed");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
