
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Log_in_Employers : Form
    {
        public Log_in_Employers()
        {
            InitializeComponent();
        }

        List<string> users = new List<string>();
        List<string> pass = new List<string>();


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "          Username")
            {
                textBox1.Text = "";
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "          Password")
            {
                textBox2.PasswordChar = '*';
                textBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "          Username";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "          Password";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (users.Contains(textBox1.Text) && pass.Contains(textBox2.Text) && Array.IndexOf(users.ToArray(), textBox1.Text) == Array.IndexOf(pass.ToArray(), textBox2.Text))
            {
                var form1 = new Employer_Main();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username and/or password is incorect and/or empty!");
            }
        }

        private void Log_in_Employers_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("employers.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
            sr.Close();


        }

        private void Go_Home_Button_Click_1(object sender, EventArgs e)
        {
            var form1 = new Second_Main_Form();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "yao")
            {
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox4.Visible = true;
            }

        }

        private void Online_info_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This is the Employer's Login Form!\nIf you are a Yao Cinema's Employer complete your credentials correctly and click on login.\nIf you are not an Employer you can go back to Second Main form by clicking on the back button.", "Online Help", MessageBoxButtons.OK);
            //Online Helper MessageBox's message.
        }
    }
}
