using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Accelerations.Add(new NumericUpDownAcceleration(seconds: 1, increment: 1));
            numericUpDown1.Accelerations.Add(new NumericUpDownAcceleration(seconds: 2, increment: 10));
            numericUpDown1.Accelerations.Add(new NumericUpDownAcceleration(seconds: 3, increment: 50));
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // progressBar1.PerformStep();
            // progressBar1.Value += 10;
            progressBar1.Increment(10);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 200;
            progressBar1.Style = ProgressBarStyle.Continuous;
            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;
        }
    }
}
