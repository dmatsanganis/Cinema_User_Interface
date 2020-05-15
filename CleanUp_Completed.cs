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
    public partial class CleanUp_Completed : Form
    {
        public CleanUp_Completed(string ctime, string date, string room)
        {
            InitializeComponent();
            label1.Text = "You have order Yao 457 to Clean Up the : " + room + Environment.NewLine +
            "At " + date + " at " + ctime;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Vacuum_Cleaner_Main();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }
    }
}
