using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SentryPOS.Forms
{
    public partial class Update_Item_Selling_Price : Form
    {
        public Update_Item_Selling_Price()
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
        //LOAD STOCK ITEMS
        public void load_Items()
        {
            string query = "SELECT DISTINCT Item_Name FROM Stock_Items";
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
                    comboItemName.Items.Add(client_name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Update_Item_Selling_Price_Load(object sender, EventArgs e)
        {
            load_Items();
        }
        private void btnAlter_Click(object sender, EventArgs e)
        {
            if(comboItemName.Text == "" || txtSelling.Text == "")
            {
                MessageBox.Show("Please fill item name to proceed","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "UPDATE Stock_Items SET Selling_Price = @Selling_Price WHERE Item_Name = @Item_Name";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Selling_Price", Convert.ToDouble(txtSelling.Text));
                        cmd.Parameters.AddWithValue("@Item_Name", comboItemName.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item price successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }            
        }
        //ONLY NUMBERS FOR QUANTITY
        private void txtSelling_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
