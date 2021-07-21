using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();

            Load += MainFrom_Load;            
        }

        System.Windows.Forms.Timer _timer;

        private void MainFrom_Load(object sender, EventArgs e)
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToLongTimeString();
            timeLabel.Text = time;
        }
    }
}
