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
    public partial class Inventory_Limits : Form
    {
        public Inventory_Limits()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //FILL DATAGRID
        public void fill_Datagrid()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Item_Name, Bar_Code, Units, Sum_Quantity, Avg_BP, Avg_SP FROM Stock_Items_View", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGridList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Inventory_Limits_Load(object sender, EventArgs e)
        {
            fill_Datagrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridList.Rows.Count < 1)
            {
                MessageBox.Show("There is no data to save", "No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                    {
                        sqlcon.Open();
                        foreach (DataGridViewRow view in dataGridList.Rows)
                        {
                            string query = "INSERT INTO Inventory_Limits(Item_Name,Bar_Code,Units,Current_Quantity,Buying_Price,Selling_Price,Lower_Limit) VALUES(@Item_Name,@Bar_Code,@Units,@Current_Quantity,@Buying_Price,@Selling_Price,@Lower_Limit)";
                            SqlCommand cmd = new SqlCommand(query, sqlcon);
                            cmd.Parameters.AddWithValue("@Item_Name", view.Cells["Item_Name"].Value);
                            cmd.Parameters.AddWithValue("@Bar_Code", view.Cells["Bar_Code"].Value);
                            cmd.Parameters.AddWithValue("@Units", view.Cells["Units"].Value);
                            cmd.Parameters.AddWithValue("@Current_Quantity", Convert.ToInt32(view.Cells["Quantity"].Value));
                            cmd.Parameters.AddWithValue("@Buying_Price", Convert.ToDouble(view.Cells["Buying_Price"].Value));
                            cmd.Parameters.AddWithValue("@Selling_Price", Convert.ToDouble(view.Cells["Selling_Price"].Value));
                            cmd.Parameters.AddWithValue("@Lower_Limit", Convert.ToInt32(view.Cells["Lower_Limit"].Value));
                            cmd.ExecuteNonQuery();                            
                        }
                        MessageBox.Show("Limits saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
