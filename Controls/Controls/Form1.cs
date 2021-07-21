using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string driverLicense = checkBox1.Checked ? "есть" : "нет";
            string gender = radioButton1.Checked ? "женский" : "мужской";

            StringBuilder resumeBuilder = new StringBuilder();
            resumeBuilder.AppendLine($"{firstName} {lastName}");
            resumeBuilder.AppendLine($"Пол: {gender}");
            resumeBuilder.AppendLine($"Водительские права: {driverLicense}");

            MessageBox.Show(resumeBuilder.ToString());
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zа-я]{2,}$";
            
            if(Regex.IsMatch(firstNameTextBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
