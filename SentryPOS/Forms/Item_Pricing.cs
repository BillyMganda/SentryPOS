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
    public partial class Item_Pricing : Form
    {
        public Item_Pricing()
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
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Item_Name, Bar_Code, Group_Name, Date_Created, Units FROM Inventory_Items", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGridList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Item_Pricing_Load(object sender, EventArgs e)
        {
            fill_Datagrid();

            this.dataGridList.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.dataGridList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }
        //CELLS TO ONLY ACCEPT NUMBERS
        private void dataGridList_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //dataGridList.Rows[e.RowIndex].ErrorText = "";
            //int newInteger;
            //if (dataGridList.Rows[e.RowIndex].IsNewRow)
            //{
            //    return;
            //}
            //if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0)
            //{
            //    e.Cancel = true;
            //    dataGridList.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            //}
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dataGridList.Rows.Count < 1)
            {
                MessageBox.Show("There is no data to save","No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            string query = "INSERT INTO Stock_Items(Item_Name,Bar_Code,Item_Group,Date_Created,Units,Quantity,Buying_Price,Selling_Price)VALUES(@Item_Name,@Bar_Code,@Item_Group,@Date_Created,@Units,@Quantity,@Buying_Price,@Selling_Price)";
                            SqlCommand cmd = new SqlCommand(query, sqlcon);
                            cmd.Parameters.AddWithValue("@Item_Name", view.Cells["Item_Name"].Value);
                            cmd.Parameters.AddWithValue("@Bar_Code", view.Cells["Bar_Code"].Value);
                            cmd.Parameters.AddWithValue("@Item_Group", view.Cells["Group_Name"].Value);
                            cmd.Parameters.AddWithValue("@Date_Created", view.Cells["Date_Created"].Value);
                            cmd.Parameters.AddWithValue("@Units", view.Cells["Units"].Value);
                            cmd.Parameters.AddWithValue("@Quantity", view.Cells["Quantity"].Value);
                            cmd.Parameters.AddWithValue("@Buying_Price", view.Cells["Buying_Price"].Value);
                            cmd.Parameters.AddWithValue("@Selling_Price", view.Cells["Selling_Price"].Value);
                            cmd.ExecuteNonQuery();
                            delete_FromInventoryItem();
                        }
                        MessageBox.Show("Items saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Fill all fields to save the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }            
        }
        //DELETE FROM INVENTORY_ITEM
        public void delete_FromInventoryItem()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    string query = "DELETE FROM Inventory_Items";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error deleting from Inventory Item. Contact 0729703270", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
