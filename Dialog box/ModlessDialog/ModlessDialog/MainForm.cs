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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ModlessForm form = null;

        private void openButton_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new ModlessForm();
                form.Data = textBox1.Text;
                form.FormClosed += (s, a) => form = null;
                form.CheckboxStateChanged += form_CheckboxStateChanged;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        void form_CheckboxStateChanged(object sender, StateEventArgs e)
        {
            label2.Text = "checkbox: " + e.State.ToString();
        }

      

       
    }
}
