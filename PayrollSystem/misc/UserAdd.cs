using System;
using System.Windows.Forms;

namespace PayrollSystem.User
{
    public partial class formAdd : Form
    {
        public formAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        //cancel button
        private void buttonCancelRegister_Click(object sender, EventArgs e)
        {
            MainTabAd mta = new MainTabAd();
            this.Close();
            mta.Show();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainTabAd mta = new MainTabAd();
            this.Close();
            mta.Show();

        }
    }
}
