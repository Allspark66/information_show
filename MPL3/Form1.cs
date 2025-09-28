using System;
using System.Windows.Forms;

namespace MPL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked) gender = "Male";
            else if (radioButton2.Checked) gender = "Female";
            else if (radioButton3.Checked) gender = "Other";

            string city = "";
            if (listBox1.SelectedItem != null)
                city = listBox1.SelectedItem.ToString();

            string country = "";
            if (comboBox1.SelectedItem != null)
                country = comboBox1.SelectedItem.ToString();

            string skills = "";
            if (checkBox1.Checked) skills += "C# ";
            if (checkBox2.Checked) skills += "C++ ";
            if (checkBox3.Checked) skills += "Java ";
            if (checkBox4.Checked) skills += "Other ";

            MessageBox.Show(
                "Gender: " + gender +
                "\nCity: " + city +
                "\nCountry: " + country +
                "\nSkills: " + skills,
                "Entered Information"
            );
        }
        
    }

}

