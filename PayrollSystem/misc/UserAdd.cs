using System;
using System.Windows.Forms;

namespace PayrollSystem.User
{
    public partial class formAdd : Form
    {

        MainTabAd mta;

        public formAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.DataSend(
                "INSERT INTO Account_Info (" +
                "first_name,middle_name,last_name,address,region,city,jobtitle,age,dateofbirth," +
                "costperday,postalzipcode,contactnumber,Role,country,gender)" +
                "VALUES" +
                "('" + textBoxFirstName.Text + "'" +
                "'" + textBoxMiddleName.Text + "'" +
                "'" + textBoxLastName.Text + "'" +
                "'" + textBoxAddress.Text + "'" +
                "'" + textBoxProvince.Text + "'" +
                "'" + textBoxCity.Text + "'" +
                "'" + textBoxJobTitle + "'" +
                "'" + numericUpDownAge.Value + "'" +
                "'" + Convert.ToString(dateTimePickerBirthday) + "'" +
                "'" + numericUpDownCostPerDay.Value + "'" +
                "'" + textBoxPostal.Text + "'" +
                "'" + textBoxContactNumber.Text + "'" +
                "'" + comboBoxRole.Text + "'" +
                "'" + comboBoxCountry.Text + "'" +
                "'"+InsertGender(radioButtonMale,radioButtonFemale)+"')"
                );

            Switch_mta();

            /*
            if (textBoxFirstName.Equals(""))
            {

            }
            else if(textBoxLastName.Equals(""))
            {

            }
            else if (textBoxPostal.Equals(""))
            {

            }
            else if (textBoxJobTitle.Equals(""))
            {

            }
            else if (textBoxAddress.Equals(""))
            {

            }
            else if (textBoxProvince.Equals(""))
            {

            }
            else if (textBoxCity.Equals(""))
            {

            }
            else if(ex)
            {

            }
            */
        }

        private void Acc_edit(String username, String password, String Email)
        {

        }

        private static String InsertGender(RadioButton maleInput, RadioButton femaleInput)
        {
            string str = "";
            if (maleInput.Checked)
            {
                str = "m";
            }
            else if (femaleInput.Checked)
            {
                str = "f";
            }

            return str;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Switch_mta();
        }

        private void Switch_mta()
        {
            mta = new MainTabAd();
            mta.Show();
            this.Close();
        }

        private void formAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Switch_mta();
        }
    }
}
