using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModlessDialog
{
    public partial class ModlessForm : Form
    {
        public ModlessForm()
        {
            InitializeComponent();
        }
        public string Data
        {
            set { textBox1.Text = value;  }
        }

        public event StateEventHandler CheckboxStateChanged;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckboxStateChanged != null)
            {
                CheckboxStateChanged(this, new StateEventArgs{State = checkBox1.Checked});
            }
        }

    }
}
