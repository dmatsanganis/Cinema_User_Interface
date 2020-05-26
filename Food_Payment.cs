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
    public partial class Food_Payment : Form
    {
        public Food_Payment(string tcost)
        {
            InitializeComponent();
            label1.Text = "Your Total Cost is : " + tcost + "€";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Yao_s_Food_App();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            var form1 = new Paypal();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form1 = new CreditCard();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
    }
}
