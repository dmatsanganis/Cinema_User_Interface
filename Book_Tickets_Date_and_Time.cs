using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Book_Tickets_Date_and_Time : Form
    {
        Random rnd = new Random();
        public Book_Tickets_Date_and_Time(string movie_name)
        {
            InitializeComponent();
            label7.Text = "You have select the movie : " + movie_name + "!";
            label11.Text = movie_name;
            label11.Visible = false;

            if (movie_name == "The Irishman")
            {
                button1.Visible = true;
                label6.Visible = true;
                button2.Visible = false;
                label8.Visible = false;
                button3.Visible = false;
                label9.Visible = false;
            }
            else if (movie_name == "Apollo 11")
            {
                button1.Visible = false;
                label6.Visible = false;
                button2.Visible = true;
                label8.Visible = true;
                button3.Visible = false;
                label9.Visible = false;
     
            }
            else if (movie_name == "Sonic The Hedhehog")
            {
                button1.Visible = false;
                label6.Visible = false;
                button2.Visible = false;
                label8.Visible = false;
                button3.Visible = true;
                label9.Visible = true;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Tickets();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Book_Tickets_Date_and_Time_Load(object sender, EventArgs e)
        {
            int timeandrooms = rnd.Next(1, 5); //Random int from 1 to 4.

            if (timeandrooms == 1)
            {
                comboBox1.Items.Add("17:00 @ Shanghai Room" );
                comboBox1.Items.Add("18:30 @ Beijing Room" );
                comboBox1.Items.Add("21:00 @ Yao's Hall Room" );
            }
            else if (timeandrooms == 2)
            {
                comboBox1.Items.Add("17:15 @ Yao's Hall Room" );
                comboBox1.Items.Add("19:30 @ Shanghai Room" );
                comboBox1.Items.Add("21:30 @ Beijing Room" );
            }
            else if (timeandrooms == 3)
            {
                comboBox1.Items.Add("18:15 @ Yao's Hall Room");
                comboBox1.Items.Add("19:45 @ Beijing Room" );
                comboBox1.Items.Add("21:00 @ Shanghai Room");
            }
            else
            {
                comboBox1.Items.Add("17:15 @ Beijing Room");
                comboBox1.Items.Add("20:45 @ Yao's Hall Room");
                comboBox1.Items.Add("22:30 @ Shanghai Room");
            }
            string date = dateTimePicker1.Value.ToString("dd - MM - yyyy");
            string timerooms = comboBox1.Text;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Select Time & Room")
            {
                string timerooms = comboBox1.Text;
                string date = dateTimePicker1.Value.ToString("dd - MM - yyyy");
                string movie_name = label11.Text;
                var form1 = new Seats_Selection(timerooms, date, movie_name);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill all the fields before proceed to the next form!");
            }
        }
    }
}
