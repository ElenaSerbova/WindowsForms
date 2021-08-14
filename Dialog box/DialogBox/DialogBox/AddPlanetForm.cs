using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace DialogBox
{
    public partial class AddPlanetForm : Form
    {
        public AddPlanetForm()
        {
            InitializeComponent();
        }  
        
        public AddPlanetForm(Planet planet) : this()
        {
            nameTextBox.Text = planet.Name;
            weightTextBox.Text = planet.Weight.ToString();
            diameterTextBox.Text = planet.Diameter.ToString();
            waterRadioYes.Checked = planet.IsWater;
        }

        public string PlanetName
        {
            get => nameTextBox.Text;          
        }
        public double PlanetWeight
        {
            get => double.Parse(weightTextBox.Text, CultureInfo.CurrentCulture.NumberFormat);
        }
        public double PlanetDiameter
        {
            get => double.Parse(diameterTextBox.Text, CultureInfo.CurrentCulture.NumberFormat);
        }
        public bool PlanetWater
        {
            get => waterRadioYes.Checked;
        }

        bool ValidateForm()
        {            
            bool isValidName = !string.IsNullOrWhiteSpace(nameTextBox.Text);
            
            double weight;
            bool isValidWeight = double.TryParse(weightTextBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture.NumberFormat, out weight);

            double diameter;
            bool isValidDiameter = double.TryParse(diameterTextBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture.NumberFormat, out diameter);

            return isValidName && isValidWeight && isValidDiameter;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {      
            if(ValidateForm())
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Data is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPlanetForm_FormClosing(object sender, FormClosingEventArgs e)
        {       
        }
    }
}
