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
    public partial class Receive_Orders : Form
    {
        public Receive_Orders()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //ORDER ID
        public void fill_OrderID()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    SqlCommand cmd;
                    SqlDataReader dr;
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DISTINCT Order_ID FROM Purchase_Order_View";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtOrderID.Text = (dr["Order_ID"]).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no order to process at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //FILL OTHER DETAILS
        public void fillOtherDetails()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    SqlCommand cmd;
                    SqlDataReader dr;
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT Supplier,Supplier_Address,Supplier_City,Supplier_Telephone,Date FROM Purchase_Order_View WHERE Order_ID = '"+Convert.ToInt32(txtOrderID.Text)+"' ";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtOrderDate.Text = (dr["Date"]).ToString();
                        txtSupplierName.Text = (dr["Supplier"]).ToString();
                        txtSupplierAddress.Text = (dr["Supplier_Address"]).ToString();
                        txtCity.Text = (dr["Supplier_City"]).ToString();
                        txtTelephone.Text = (dr["Supplier_Telephone"]).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no order to process at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //FILL DATAGRID
        public void fill_Datagrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Item_Name,Bar_Code,Units,Quantity,Buying_Price FROM Purchase_Order_View WHERE Order_ID = '" + Convert.ToInt32(txtOrderID.Text) + "'", con);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGridList.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no order to process at this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void Receive_Orders_Load(object sender, EventArgs e)
        {
            fill_OrderID();
            fillOtherDetails();
            fill_Datagrid();
        }
        //CALCULATION IN DATAGRID
        private void dataGridList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridList.Rows)
                {
                    row.Cells[dataGridList.Columns["Total_Price"].Index].Value = (Convert.ToDouble(row.Cells[dataGridList.Columns["Quantity"].Index].Value) * Convert.ToDouble(row.Cells[dataGridList.Columns["Unit_Price"].Index].Value));
                }                
                int sum = 0;
                for (int i = 0; i < dataGridList.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridList.Rows[i].Cells["Total_Price"].Value);
                }
                txtTotalAmount.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //DELETE FROM PURCHASE ORDER
        public void delete_FromPurchaseOrder()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    string query = "DELETE FROM Purchase_Order WHERE Order_ID = '"+Convert.ToInt32(txtOrderID.Text)+"' ";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error moving Items from purchase order. Contact 0729703270 for assistance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtTotalAmount.Text == "")
            {
                MessageBox.Show("Confirm Received quantity to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            string query = "INSERT INTO Received_Goods(Item_Name,Item_Code,Units,Quantity,Unit_Price,Total_Price,Order_ID,Order_Date,Supplier,Address,City,Telephone,Received_Date) VALUES(@Item_Name,@Item_Code,@Units,@Quantity,@Unit_Price,@Total_Price,@Order_ID,@Order_Date,@Supplier,@Address,@City,@Telephone,@Received_Date)";
                            SqlCommand cmd = new SqlCommand(query, sqlcon);
                            cmd.Parameters.AddWithValue("@Item_Name", view.Cells["Item_Name"].Value);
                            cmd.Parameters.AddWithValue("@Item_Code", view.Cells["Bar_Code"].Value);
                            cmd.Parameters.AddWithValue("@Units", view.Cells["Units"].Value);
                            cmd.Parameters.AddWithValue("@Quantity", view.Cells["Quantity"].Value);
                            cmd.Parameters.AddWithValue("@Unit_Price", view.Cells["Unit_Price"].Value);
                            cmd.Parameters.AddWithValue("@Total_Price", view.Cells["Total_Price"].Value);
                            cmd.Parameters.AddWithValue("@Order_ID", Convert.ToInt32(txtOrderID.Text));
                            cmd.Parameters.AddWithValue("@Order_Date", Convert.ToDateTime(txtOrderDate.Text));
                            cmd.Parameters.AddWithValue("@Supplier", txtSupplierName.Text);
                            cmd.Parameters.AddWithValue("@Address", txtSupplierAddress.Text);
                            cmd.Parameters.AddWithValue("@City", txtCity.Text);
                            cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                            cmd.Parameters.AddWithValue("@Received_Date", Convert.ToDateTime(dateTimePicker1.Text));
                            cmd.ExecuteNonQuery();
                            add_Positive();
                        }
                        MessageBox.Show("Items received successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        delete_FromPurchaseOrder();
                        fill_OrderID();
                        fillOtherDetails();
                        fill_Datagrid();
                        txtTotalAmount.Text = "";                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //ADD POSITIVE TO STOCK ITEMS TABLE
        public void add_Positive()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    foreach (DataGridViewRow view in dataGridList.Rows)
                    {
                        string query = "INSERT INTO Stock_Items(Item_Name,Bar_Code,Units,Quantity,Buying_Price) VALUES(@Item_Name,@Bar_Code,@Units,@Quantity,@Buying_Price)";
                        SqlCommand cmd = new SqlCommand(query, sqlcon);
                        cmd.Parameters.AddWithValue("@Item_Name", view.Cells["Item_Name"].Value);
                        cmd.Parameters.AddWithValue("@Bar_Code", view.Cells["Bar_Code"].Value);
                        cmd.Parameters.AddWithValue("@Units", view.Cells["Units"].Value);
                        cmd.Parameters.AddWithValue("@Quantity", view.Cells["Quantity"].Value);
                        cmd.Parameters.AddWithValue("@Buying_Price", view.Cells["Unit_Price"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
    }
}
