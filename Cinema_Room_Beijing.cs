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
    public partial class Cinema_Room_Beijing : Form
    {
        public Cinema_Room_Beijing()
        {
            InitializeComponent();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var form1 = new Cinema_Rooms_Hall();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Online_info_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This is Beijing Cinema Room.\nClick on the back button to return to Hallway.", "Online Help", MessageBoxButtons.OK);
            //Online Helper MessageBox's message.
        }
    }
}

