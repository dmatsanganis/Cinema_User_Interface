using System.Windows.Forms;

namespace Cinema
{
    public partial class Cinema_Entrance : Form
    {

        public Cinema_Entrance()
        {
            InitializeComponent();

        }
      

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            var form1 = new Second_Main_Form();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void Online_info_button_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This is the first form, our Cinema's Entrance!\nClick on Yao to continue to the Second and Main form.", "Online Help", MessageBoxButtons.OK);
            //Online Helper MessageBox's message.
        }
    }
}
