using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGLauncher
{
    class ControlSelectionHandler
    {
        private List<System.Windows.Forms.Control> controls;
        private int selectedControl;
        private System.Windows.Forms.Form form;

        public ControlSelectionHandler(List<System.Windows.Forms.Control> controls, System.Windows.Forms.Form form)
        {
            this.form = form;
            this.controls = controls;
            selectedControl = 0;
            select();
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
            if (controls[selectedControl] is System.Windows.Forms.CheckBox)
            {
                (controls[selectedControl] as System.Windows.Forms.CheckBox).ForeColor = System.Drawing.Color.Black;
            }
        }

        public void select()
        {
            if (controls[selectedControl] is System.Windows.Forms.CheckBox)
            {
                (controls[selectedControl] as System.Windows.Forms.CheckBox).ForeColor = System.Drawing.Color.Firebrick;
            }
            form.ActiveControl = controls[selectedControl];
        }
    }
}
