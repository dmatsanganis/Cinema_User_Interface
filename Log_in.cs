using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Log_in : Form
    {
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        public Log_in()
        {
            InitializeComponent();
        }

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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (users.Contains(textBox1.Text) && pass.Contains(textBox2.Text) && Array.IndexOf(users.ToArray(), textBox1.Text) == Array.IndexOf(pass.ToArray(), textBox2.Text))
            {
                var form1 = new Client_Main();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username and/or password is incorect");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form1 = new Register();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Go_Home_Button_Click(object sender, EventArgs e)
        {
            var form1 = new Second_Main_Form();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("users.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
            sr.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var form1 = new Log_in_Employers();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Online_info_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This is the Client's Login Form!\nIf you are a Yao Cinema's Member complete your credentials correctly and click on login.\nIf you are a newone click to Register button to register.\nIf you are a Employer click on the Cinema's Employers Login.You can go back to Second Main form by clicking on the back button.", "Online Help", MessageBoxButtons.OK);
            //Online Helper MessageBox's message.
        }
    }
}

