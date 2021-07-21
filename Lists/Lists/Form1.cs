using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    public partial class Form1 : Form
    {
        PersonRegister personRegister = new PersonRegister();
        public Form1()
        { 
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contactsListBox.DataSource = personRegister.Contacts;
            contactsListBox.DisplayMember = "FullName";

            int count = personRegister.Contacts.Count;
            countStatusStripLabel.Text = $"Count: {count}";
        }

        private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {  
            Person person = contactsListBox.SelectedItem as Person;
            personInfoLabel.Text = $"Full name: {person.FullName}\nPhone: {person.Phone}\nBith date: {person.BirthDate.ToShortDateString()}";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                FirstName = firstnameTextBox.Text,
                LastName = lastnameTextBox.Text,
                Phone = phoneTextBox.Text,
                BirthDate = birthDateTimePicker.Value
            };

            personRegister.Contacts.Add(person);

            int count = personRegister.Contacts.Count;
            countStatusStripLabel.Text = $"Count: {count}";


            firstnameTextBox.Clear();
            lastnameTextBox.Clear();
            phoneTextBox.Clear();
        }
    }
}
