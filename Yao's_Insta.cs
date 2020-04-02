using System;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Yao_s_Insta : Form
    {
        public Yao_s_Insta()
        {
            InitializeComponent();
        }

        private void Go_Home_Button_Click(object sender, EventArgs e)
        {
            var form1 = new Client_Main();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
    }
}
