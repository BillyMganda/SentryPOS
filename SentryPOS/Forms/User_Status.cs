using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SentryPOS.Forms
{
    public partial class User_Status : Form
    {
        public User_Status()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //LOAD CUSTOMER GROUP
        public void loadUsers()
        {
            string query = "SELECT DISTINCT FUllNames FROM User_Info";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            SqlDataReader sqlreader;
            try
            {
                sqlcon.Open();
                sqlreader = sqlcmd.ExecuteReader();
                while (sqlreader.Read())
                {
                    string client_name = sqlreader.GetString(0);
                    comboUsers.Items.Add(client_name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //LOAD
        private void User_Status_Load(object sender, EventArgs e)
        {
            loadUsers();
        }
        //LOAD ONE NAME
        private void comboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    DataTable dt = new DataTable();
                    sqlcon.Open();
                    SqlDataReader myReader = null;
                    string query = "SELECT fName FROM User_Info WHERE FullNames = '" + comboUsers.Text + "' ";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                    myReader = sqlcmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        label_FirstName.Text = (myReader["fName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        string status = "";

        private void radioActive_CheckedChanged(object sender, EventArgs e)
        {
            status = "True";
        }

        private void radioInactive_CheckedChanged(object sender, EventArgs e)
        {
            status = "False";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "")
            {
                MessageBox.Show("Status has not changed for a particular user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(comboUsers.Text == "")
            {
                MessageBox.Show("No user has been selected for a status change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "UPDATE User_Info SET Status = @Status WHERE FullNames = @FullNames";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@FullNames", comboUsers.Text);                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User successfully updated","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
       
    }
}
