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
    public partial class Cinema_Rooms_Hall : Form
    {
        public Cinema_Rooms_Hall()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form1 = new Cinema_Room_Shanghai();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form1 = new Cinema_Room_YaoHall();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var form1 = new Cinema_Room_Beijing();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Client_Main();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var form1 = new Second_Main_Form();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
    }
}

