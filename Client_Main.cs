using System;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Client_Main : Form
    {
        public Client_Main()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            var form1 = new Waiting_Room();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            var form1 = new Tickets();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            var form1 = new Waiting_Room();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            var form1 = new Restaurant();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form1 = new Cinema_Rooms_Hall();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Second_Main_Form();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
    }
}

