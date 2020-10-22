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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userHash = Digests.Sha256.applySHA256(Usernametxtboxlogin.Text);
            string passHash = Digests.Sha256.applySHA256(Passwordtxtboxlogin.Text);
            Connection con = new Connection();
            con.dataGet("SELECT * FROM [Accounts] WHERE Username = '"+userHash+"' AND Password = '"+passHash+"'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if(dt.Rows.Count > 0)
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

        private void ButtonCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usernametxtboxlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
