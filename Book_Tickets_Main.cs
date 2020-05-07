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
    public partial class Book_Tickets_Main : Form
    {
        public Book_Tickets_Main()
        {
            InitializeComponent();
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            var form1 = new Yao_s_Insta();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Tickets();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form1 = new Movie_The_Irishman();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form1 = new Movie_Apollo11();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var form1 = new Movie__Sonic_the_Hedgehog();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Book_Tickets_Main_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "The Irishman")
            {
                button1.Visible = true;
                label4.Visible = true;
                button2.Visible = false;
                label5.Visible = false;
                button3.Visible = false;
                label6.Visible = false;
                string movie_name = "The Irishman";
            }
            else if (comboBox1.Text == "Apollo 11")
            {
                button1.Visible = false;
                label4.Visible = false;
                button2.Visible = true;
                label5.Visible = true;
                button3.Visible = false;
                label6.Visible = false;
                string movie_name = "Apollo 11";
            }
            else if (comboBox1.Text == "Sonic The Hedhehog")
            {
                button1.Visible = false;
                label4.Visible = false;
                button2.Visible = false;
                label5.Visible = false;
                button3.Visible = true;
                label6.Visible = true;
                string movie_name = "Sonic The Hedhehog";
            }
            else
            {
                button1.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                label5.Visible = true;
                button3.Visible = true;
                label6.Visible = true;
                string movie_name = "";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "The Irishman" || comboBox1.Text == "Apollo 11" || comboBox1.Text == "Sonic The Hedhehog")
            {
                string movie_name = comboBox1.Text;
                var form1 = new Book_Tickets_Date_and_Time(movie_name);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a movie before proceed to the next form!");
            }

        }
    }
}
