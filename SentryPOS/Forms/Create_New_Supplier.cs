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
    public partial class Create_New_Supplier : Form
    {
        public Create_New_Supplier()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtSupplierName.Text == "")
            {
                MessageBox.Show("Supplier can not be saved! Important fields are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "INSERT INTO Supplier(Supplier_Name,Supplier_Address,Supplier_City,Supplier_Email,Supplier_Telephone,Contact_Person,CP_Telephone) VALUES(@Supplier_Name,@Supplier_Address,@Supplier_City,@Supplier_Email,@Supplier_Telephone,@Contact_Person,@CP_Telephone)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Supplier_Name", txtSupplierName.Text);
                        cmd.Parameters.AddWithValue("@Supplier_Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Supplier_City", txtCity.Text);
                        cmd.Parameters.AddWithValue("@Supplier_Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Supplier_Telephone", txtTelephone.Text);
                        cmd.Parameters.AddWithValue("@Contact_Person", txtContactPerson.Text);
                        cmd.Parameters.AddWithValue("@CP_Telephone", txtContactPersonTelephone.Text);
                        cmd.ExecuteNonQuery();
                        this.Cursor = Cursors.WaitCursor;
                        var resultDia = DialogResult.None;
                        resultDia = MessageBox.Show("Supplier saved successfully. Do you wish to add a new supplier?", "New Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultDia == DialogResult.Yes)
                        {
                            Clear_();
                        }
                        if (resultDia == DialogResult.No)
                        {
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //CLEAR
        public void Clear_()
        {
            txtSupplierName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtTelephone.Text = "";
            txtContactPerson.Text = "";
            txtContactPersonTelephone.Text = "";
        }
    }
}
