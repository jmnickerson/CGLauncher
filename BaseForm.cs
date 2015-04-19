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
    public partial class BaseForm : Form
    {
        protected ControlSelectionHandler controlSelection;
        public BaseForm()
        {
            InitializeComponent();
            
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
    }
}
