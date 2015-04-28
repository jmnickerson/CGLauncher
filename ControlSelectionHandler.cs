using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CGLauncher
{
    public class ControlSelectionHandler
    {
        private List<Control> controls;
        private Dictionary<Control, Label> comboBoxToLabel;
        private int selectedControl;
        private System.Windows.Forms.Form form;
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        private List<Label> labels = new List<Label>();

        public ControlSelectionHandler(Form form, List<Control> controls, Dictionary<Control, Label> comboBoxToLabel)
        {
            this.form = form;
            this.controls = controls;
            this.comboBoxToLabel = comboBoxToLabel;
            select();
        }

        public Control getCurrentControl()
        {
            return controls[selectedControl];
        }

        public void select(Control control)
        {
            unselect();
            int index = controls.FindIndex(x => x==control);
            selectedControl = index;
            select();
        }

        public void selectPrevious()
        {
            //Console.WriteLine("select previous");
            unselect();
            if (selectedControl > 0)
                selectedControl--;
            else
                selectedControl = controls.Count - 1;
            select();
        }

        public void selectNext()
        {
            //Console.WriteLine("select next");
            unselect();
            if (selectedControl < controls.Count - 1)
                selectedControl++;
            else
                selectedControl = 0;
            if (controls[selectedControl] is TextBox)
            {
                TextBox box = controls[selectedControl] as TextBox;
                box.SelectionStart = 0;
                box.SelectionLength = box.Text.Length;
            }
            select();
            
        }
        public void unselect()
        {
            System.Windows.Forms.Control currentControl = controls[selectedControl];
            if (currentControl is System.Windows.Forms.CheckBox)
            {
                (currentControl as System.Windows.Forms.CheckBox).ForeColor = System.Drawing.Color.Black;
            }
            if(comboBoxToLabel.ContainsKey(currentControl))
            {
                Label label;
                if (comboBoxToLabel.TryGetValue(currentControl, out label))
                    label.ForeColor = System.Drawing.Color.Black;
            }
        }

        public void select()
        {
            
            System.Windows.Forms.Control currentControl = controls[selectedControl];
            //Console.WriteLine("selected control: " + selectedControl + "   " + currentControl.Name);
            if (currentControl is System.Windows.Forms.CheckBox)
            {
                (currentControl as System.Windows.Forms.CheckBox).ForeColor = System.Drawing.Color.Firebrick;
            }
            if (comboBoxToLabel.ContainsKey(currentControl))
            {
                Label label;
                if (comboBoxToLabel.TryGetValue(currentControl, out label))
                    label.ForeColor = System.Drawing.Color.Firebrick;
            }
            //if(form.ActiveControl != null)
             //   form.ActiveControl.BeginInvoke(new MethodInvoker(() => form.ActiveControl = currentControl));
            form.ActiveControl = currentControl;
        }

        public void selectFirst()
        {
            unselect();
            selectedControl = 0;
            select();
        }
    }
}
