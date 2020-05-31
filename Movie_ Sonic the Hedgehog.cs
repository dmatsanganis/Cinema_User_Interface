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
    public partial class Movie__Sonic_the_Hedgehog : Form
    {
        public Movie__Sonic_the_Hedgehog()
        {
            InitializeComponent();
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            var form1 = new Yao_s_Insta();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
            webBrowser1.Navigate("");

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Book_Tickets_Main();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
            webBrowser1.Navigate("");

        }

        private void Movie__Sonic_the_Hedgehog_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://youtu.be/szby7ZHLnkA");
        }
    }
}
