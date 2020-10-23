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

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.formAdd ua = new User.formAdd();
            ua.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            ua.Show();
        }

        private void MainTabAd_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this program?","Wait",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
