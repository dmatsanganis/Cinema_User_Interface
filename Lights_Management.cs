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
    public partial class Lights_Management : Form
    {
        public Lights_Management()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Lights_Management_Card_Explain form = new Lights_Management_Card_Explain();
            form.ShowDialog();
            this.Hide();
        }

        private void Go_Home_Button_Click(object sender, EventArgs e)
        {
            var form1 = new Employer_Main();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form1 = new Second_Main_Form();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Room")
            {
                MessageBox.Show("Please select the room first!");
            }
            else if (comboBox1.Text == "Waiting Room")
            {
                var form1 = new Waiting_Room_OffLights();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Tickets Booking Room")
            {
                var form1 = new Tickets_OffLights();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Restaurant Room")
            {
                var form1 = new Restaurant_OffLights();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();
            }           
        }
    }
}
