using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.User
{
    public partial class buttonAddRegister : Form
    {
        public buttonAddRegister()
        {
            InitializeComponent();
        }

        private void textBoxUsernameRegister_TextChanged(object sender, EventArgs e)
        {
            //username textbox
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add button 
        }

        //cancel button
        private void buttonCancelRegister_Click(object sender, EventArgs e)
        {
            MainTabAd mta = new MainTabAd();
            this.Close();
            mta.Show();
            
        }
    }
}
