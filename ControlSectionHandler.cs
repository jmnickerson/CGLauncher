using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGLauncher
{
    class ControlSectionHandler
    {
        private List<System.Windows.Forms.Control> controls;
        private int selectedControl;
        private System.Windows.Forms.Form form;
        public ControlSectionHandler()
        {

        }
        public void selectPrevious()
        {
            if (selectedControl > 0)
                selectedControl--;
            else
                selectedControl = controls.Count - 1;
            form.ActiveControl = controls[selectedControl];
        }

        public void selectNext()
        {
            if (selectedControl < controls.Count - 1)
                selectedControl++;
            else
                selectedControl = 0;
            form.ActiveControl = controls[selectedControl];
        }
    }
}
