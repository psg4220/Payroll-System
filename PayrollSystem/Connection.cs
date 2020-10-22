﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;

        public void connection()
        {
            con = new SqlConnection("Data Source=DESKTOP-POG661L;Initial Catalog=localdb;Integrated Security=True");
            con.Open();
        }

        public void DataSend(string sql)
        {

            try
            {
                connection();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show("Exception Occured: " + e,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            con.Close();
        }

        public void dataGet(string sql)
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(sql, con);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occured: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}