using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New file");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save file");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open file");
        }

        private void StatusBarMenuItem_Click(object sender, EventArgs e)
        {
            StatusBarMenuItem.Checked = !StatusBarMenuItem.Checked;
            statusStrip1.Visible = StatusBarMenuItem.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
