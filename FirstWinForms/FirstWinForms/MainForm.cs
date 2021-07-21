using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = "Main from";
            Width = 500;
            Height = 300;

            MouseClick += MainForm_MouseClick;
            KeyUp += MainForm_KeyUp;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {            
            Text = $"Mouse click: {e.Location}";
        }
    }
}
