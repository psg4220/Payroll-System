using PayrollSystem.User;
using System;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class MainTabAd : Form
    {
        public MainTabAd()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.buttonAddRegister ua = new User.buttonAddRegister();
            ua.StartPosition = FormStartPosition.CenterScreen;
            ua.Show();
            this.Hide();
        }
    }
}
