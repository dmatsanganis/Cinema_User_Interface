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
    public partial class Employer_Main : Form
    {
        public Employer_Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form1 = new Second_Main_Form();
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

        private void Label1_Click(object sender, EventArgs e)
        {
            var form1 = new Lights_Management();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            var form1 = new Vacuum_Cleaner_Main();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
    }
}
