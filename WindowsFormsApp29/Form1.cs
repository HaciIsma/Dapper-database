using MetroFramework.Forms;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp29
{
    public partial class Form1 : MetroForm
    {
        List<PersonModel> people = new List<PersonModel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadPeopleList()
        {
            people = SqliteDataAccsess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = people;
            listBox1.DisplayMember = "FullName";
        }

        private void AddDB()
        {
            PersonModel p = new PersonModel();
            p.Name = name.Text;
            p.Lastname = lastname.Text;

            SqliteDataAccsess.SavePerson(p);

            name.Text = default;
            lastname.Text = default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
    }
}
