using System;
using System.Data;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginToDatabase()
        {
            string passHash = Digests.Sha256.applySHA256(Passwordtxtboxlogin.Text);
            Connection con = new Connection();
            con.dataGet("SELECT * FROM [Accounts] WHERE username = '" + Usernametxtboxlogin.Text + "' AND password = '" + passHash + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                MainTabAd mt = new MainTabAd();
                mt.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginToDatabase();
        }

        private void ButtonCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
