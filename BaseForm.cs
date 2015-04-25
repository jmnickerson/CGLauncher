using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SlimDX; //x86
using SlimDX.XInput; //x86
using System.Threading;
using System.Runtime.InteropServices;
namespace CGLauncher
{
    public partial class BaseForm : Form
    {

        protected ControlSelectionHandler controlSelection;
        protected Controller controller;
        GamepadState gamePadState;
        public BaseForm()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            UserIndex ui = new UserIndex();
            controller = new Controller(ui);
            gamePadState = new GamepadState(ui);
        }

        protected virtual void initControlSelectionHandler()
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
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
            if (keyData == Keys.Enter)
            {

                if (this.ActiveControl is CheckBox)
                {
                    CheckBox c1 = this.ActiveControl as CheckBox;
                    c1.Checked = !c1.Checked;
                }
                if (this.ActiveControl is ComboBox)
                {
                    //ComboBox c1 = this.ActiveControl as ComboBox;
                    //c1.SelectedIndex = c1.SelectedIndex+5;
                    //controlSelection.selectNext();
                }
            }

            if (keyData == Keys.J)
            {
                if (this.ActiveControl is ComboBox)
                {
                    ComboBox c1 = this.ActiveControl as ComboBox;
                    c1.SelectedIndex = Math.Max(0, (c1.SelectedIndex - 1));
                }
            }
            if (keyData == Keys.K)
            {
                if (this.ActiveControl is ComboBox)
                {
                    ComboBox c1 = this.ActiveControl as ComboBox;
                    c1.SelectedIndex = Math.Min((c1.SelectedIndex + 1), c1.Items.Count - 1);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(50);
            if(!gamePadState.Update())
                return;
            this.Invoke(new MethodInvoker(() => update()));
        }

        private void update()
        {
            //bool isFocused = false;
            //this.Invoke(new MethodInvoker(delegate() { isFocused = this.Focused; }));
            if (!CGLauncher.GetForwardWindow.IsActive(this.Handle))
            {
                //Console.WriteLine(this.Name + " is not in focus");
                return;
            }
            
            if (gamePadState.DPad.Up)
            {
                Console.WriteLine("UP");
                controlSelection.selectPrevious();
            }
            if (gamePadState.DPad.Down)
            {
                Console.WriteLine("DOWN");
                controlSelection.selectNext();
            }
            if (gamePadState.DPad.Left)
            {
                Console.WriteLine("LEFT" + this.ActiveControl.GetType().ToString());
                if (this.ActiveControl is ComboBox)
                {
                    ComboBox c1 = this.ActiveControl as ComboBox;
                    c1.BeginInvoke(new MethodInvoker(() => c1.SelectedIndex = Math.Max(0, (c1.SelectedIndex - 1))));
                }
                else
                    controlSelection.selectPrevious();
            }
            if (gamePadState.DPad.Right)
            {
                if (this.ActiveControl is ComboBox)
                {
                    ComboBox c1 = this.ActiveControl as ComboBox;
                    c1.BeginInvoke(new MethodInvoker(() => c1.SelectedIndex = Math.Min((c1.SelectedIndex + 1), c1.Items.Count - 1)));
                }
                else
                    controlSelection.selectNext();
            }
            if (gamePadState.A)
            {
                APressed();
            }
            if (gamePadState.B)
            {
                BPressed();
            }
            if (gamePadState.X)
            {
                XPressed();
            }
            if (gamePadState.Y)
            {
                YPressed();
            }
            if (gamePadState.LeftTrigger)
            {
                LTriggerPressed();
            }
            if (gamePadState.RightTrigger)
            {
                RTriggerPressed();
            }
            if (gamePadState.RightShoulder)
            {
                RShoulderPressed();
            }
            if (gamePadState.LeftShoulder)
            {
                LShoulderPressed();
            }
            if (gamePadState.LeftStick.Clicked)
            {
                LStickPressed();
            }
            if (gamePadState.RightStick.Clicked)
            {
                RStickPressed();
            }

        }

        protected void APressed()
        {
            Console.WriteLine("A pressed");
            if (ActiveControl is Button)
            {
                Button b1 = ActiveControl as Button;
                //b1.PerformClick();
               // b1.BeginInvoke(new MethodInvoker(() => b1.PerformClick()));
                b1.PerformClick();
                return;
                
            }
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_a");  
            }
            if (ActiveControl is CheckBox)
            {
                (ActiveControl as CheckBox).Checked = !(ActiveControl as CheckBox).Checked;
            }
        }
        protected void BPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_b");              
            }
        }
        protected void XPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_x");
            }
        }
        protected void YPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_y");
            }
        }
        protected void LTriggerPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_triggerl");
            }
        }
        protected void RTriggerPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_triggerr");
            }
        }
        protected void RShoulderPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_shoulderr");
            }
        }
        protected void LShoulderPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_shoulderl");
            }
        }
        protected void LStickPressed()
        {

            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_thumbl");
            }
        }
        protected void RStickPressed()
        {
            if (ActiveControl is TextBox)
            {
                setTextBox(ActiveControl as TextBox, "xi_thumbr");
            }
        }
        protected void setTextBox(TextBox box, String text)
        {
            box.Text = text;
            controlSelection.selectNext();
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        
    }
}
