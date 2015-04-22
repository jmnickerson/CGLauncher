using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CGLauncher
{
    public class ControlSelectionHandler
    {
        private List<System.Windows.Forms.Control> controls;
        private Dictionary<ComboBox, Label> comboBoxToLabel;
        private int selectedControl;
        private System.Windows.Forms.Form form;
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        private List<Label> labels = new List<Label>();
        public ControlSelectionHandler(System.Windows.Forms.Form mainForm)
        {
            this.form = mainForm;
            controls = new List<Control>();
            
            List<GroupBox> groupBoxes = mainForm.Controls.OfType<GroupBox>().ToList();
            comboBoxToLabel = new System.Collections.Generic.Dictionary<ComboBox, Label>();
            if (groupBoxes.Count == 0)
            {
                Console.WriteLine("No groupboxes");
                controls.AddRange(form.Controls.OfType<ComboBox>().Cast<Control>().ToList());
                controls.AddRange(form.Controls.OfType<CheckBox>().Cast<Control>().ToList());
                controls.AddRange(form.Controls.OfType<TextBox>().Cast<Control>().ToList());
                controls.Reverse();
                controls.AddRange(form.Controls.OfType<Button>().Cast<Control>().ToList());
                comboBoxes.AddRange(form.Controls.OfType<ComboBox>().ToList());
                labels = form.Controls.OfType<Label>().ToList();
                for (int i = 0; i < comboBoxes.Count; i++)
                {
                    comboBoxToLabel.Add(comboBoxes[i], labels[i]);
                }
            }
            else
                addGroupBoxes(groupBoxes);

            Console.WriteLine("GroupBoxes: " + groupBoxes.Count + " Controls: " + controls.Count);
            selectedControl = 0;
            
            //select();
        }

        private void addGroupBoxes(List<GroupBox> groupBoxes)
        {
            foreach (GroupBox groupBox in groupBoxes)
            {
                List<Control> boxControls = new List<Control>();
                boxControls.AddRange(groupBox.Controls.OfType<ComboBox>().Cast<Control>().ToList());
                boxControls.AddRange(groupBox.Controls.OfType<CheckBox>().Cast<Control>().ToList());
                boxControls.AddRange(groupBox.Controls.OfType<TextBox>().Cast<Control>().ToList());
                boxControls.Reverse();
                boxControls.AddRange(groupBox.Controls.OfType<Button>().Cast<Control>().ToList());
                Console.WriteLine("Boxcontrols size " + boxControls.Count);
                controls.AddRange(boxControls);
                comboBoxToLabel = new System.Collections.Generic.Dictionary<ComboBox, Label>();
                comboBoxes.AddRange(form.Controls.OfType<ComboBox>().ToList());
                labels.AddRange(form.Controls.OfType<Label>().ToList());
                for (int i = 0; i < comboBoxes.Count; i++)
                {
                    comboBoxToLabel.Add(comboBoxes[i], labels[i]);
                }
            }
        }


        public void selectPrevious()
        {
            unselect();
            if (selectedControl > 0)
                selectedControl--;
            else
                selectedControl = controls.Count - 1;
            select();
        }

        public void selectNext()
        {
            unselect();
            if (selectedControl < controls.Count - 1)
                selectedControl++;
            else
                selectedControl = 0;
            select();
            
        }
        public void unselect()
        {
            System.Windows.Forms.Control currentControl = controls[selectedControl];
            if (currentControl is System.Windows.Forms.CheckBox)
            {
                (currentControl as System.Windows.Forms.CheckBox).ForeColor = System.Drawing.Color.Black;
            }
            if (currentControl is System.Windows.Forms.ComboBox)
            {
                Label label;
                if (comboBoxToLabel.TryGetValue((currentControl as ComboBox), out label))
                    label.ForeColor = System.Drawing.Color.Black;
            }
        }

        public void select()
        {
            System.Windows.Forms.Control currentControl = controls[selectedControl];
            if (currentControl is System.Windows.Forms.CheckBox)
            {
                (currentControl as System.Windows.Forms.CheckBox).ForeColor = System.Drawing.Color.Firebrick;
            }
            if (currentControl is System.Windows.Forms.ComboBox)
            {
                Label label;
                if(comboBoxToLabel.TryGetValue((currentControl as ComboBox), out label))
                    label.ForeColor = System.Drawing.Color.Firebrick;
            }
            form.ActiveControl = currentControl;
        }
    }
}
