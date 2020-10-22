using PayrollSystem.User;
using System;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class MainTab : Form
    {
        public MainTab()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.UserAdd ua = new User.UserAdd();
            ua.StartPosition = FormStartPosition.CenterScreen;
            ua.Show();
            this.Close();
        }
    }
}
