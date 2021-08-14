using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        BindingList<Planet> planets = new BindingList<Planet>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            planetListBox.DataSource = planets;
            planetListBox.DisplayMember = "Name";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPlanetForm addPlanetForm = new AddPlanetForm();
            
            if (addPlanetForm.ShowDialog() == DialogResult.OK)
            {
                planets.Add(new Planet
                {
                    Name = addPlanetForm.PlanetName,
                    Weight = addPlanetForm.PlanetWeight,
                    Diameter = addPlanetForm.PlanetDiameter,
                    IsWater = addPlanetForm.PlanetWater
                });
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(planetListBox.SelectedItem != null)
            {
                Planet planet = planetListBox.SelectedItem as Planet;
                AddPlanetForm editPlanetForm = new AddPlanetForm(planet);
                if(editPlanetForm.ShowDialog() == DialogResult.OK)
                {
               
                    planet.Name = editPlanetForm.PlanetName;
                    planet.Weight = editPlanetForm.PlanetWeight;
                    planet.Diameter = editPlanetForm.PlanetDiameter;
                    planet.IsWater = editPlanetForm.PlanetWater;
                    planets.ResetBindings();
                }
            }
        }
    }
}
