using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SentryPOS.Forms
{
    public partial class Supplier_Status : Form
    {
        public Supplier_Status()
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
        //LOAD SUPPLIERS
        public void loadSuppliers()
        {
            string query = "SELECT DISTINCT Supplier_Name FROM Supplier";
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
                    comboSupplier.Items.Add(client_name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Supplier_Status_Load(object sender, EventArgs e)
        {
            loadSuppliers();
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
                MessageBox.Show("Status has not changed for a particular supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (comboSupplier.Text == "")
            {
                MessageBox.Show("No supplier has been selected for a status change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "UPDATE Supplier SET Status = @Status WHERE Supplier_Name = @Supplier_Name ";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Supplier_Name", comboSupplier.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
