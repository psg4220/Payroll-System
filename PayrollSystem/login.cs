using System;
using System.Data;
using System.Windows.Forms;
using PayrollSystem;

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
            Connection con = new Connection();
            con.dataGet("SELECT * FROM [Users] WHERE username = '"+Usernametxtboxlogin.Text+"' AND password = '"+Passwordtxtboxlogin);
            DataTable dt = new DataTable();
            con.sda.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                this.Hide();
                MainTab mt = new MainTab();
                mt.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
