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
    public partial class Purchase_Order : Form
    {
        public Purchase_Order()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        //LOAD ITEM NAME
        public void load_ItemName()
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
                    cmd.CommandText = "SELECT DISTINCT Item_Name FROM Stock_Items";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboItemName.Items.Add(dr["Item_Name"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //LOAD SUPPLIER
        public void load_Supplier()
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
                    cmd.CommandText = "SELECT DISTINCT Supplier_Name FROM Supplier";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboSupplier.Items.Add(dr["Supplier_Name"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //LOAD
        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            load_ItemName();
            load_Supplier();
            random_Number();
        }
        //RANDOM ORDER #
        private void random_Number()
        {
            Random slumpGenerator = new Random();
            int tal = slumpGenerator.Next(0, 1000000);
            txtOrderID.Text = tal.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(comboItemName.Text == ""||txtQuantity.Text == ""||comboSupplier.Text == "")
            {
                MessageBox.Show("Fill all necessary fields to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string[] row = { txtOrderID.Text, dateTimePicker1.Text, comboItemName.Text, txtQuantity.Text, comboSupplier.Text };
                    dataGridList.Rows.Add(row);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //DELETE ITEM
        private int rowIndex = 0;
        private void dataGridList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridList.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridList.CurrentCell = this.dataGridList.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridList, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dataGridList.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridList.Rows.RemoveAt(this.rowIndex);                
            }
        }

        //PROCESS ORDER
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridList.Rows.Count == 0)
            {
                MessageBox.Show("There are no items to order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                    {
                        if (sqlcon.State == ConnectionState.Closed)
                            sqlcon.Open();
                        foreach (DataGridViewRow grid in dataGridList.Rows)
                        {
                            string query = "INSERT INTO Purchase_Order(Order_ID,Date,Item_Name,Quantity,Supplier) VALUES(@Order_ID,@Date,@Item_Name,@Quantity,@Supplier)";
                            SqlCommand cmd = new SqlCommand(query, sqlcon);
                            cmd.Parameters.AddWithValue("@Order_ID", Convert.ToInt32(grid.Cells["Order_ID"].Value));
                            cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(grid.Cells["Order_Date"].Value));
                            cmd.Parameters.AddWithValue("@Item_Name", grid.Cells["Item_Name"].Value);
                            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(grid.Cells["Quantity"].Value));
                            cmd.Parameters.AddWithValue("@Supplier", grid.Cells["Supplier"].Value);
                            cmd.ExecuteNonQuery(); 
                        }
                        MessageBox.Show("Order saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_();
                        random_Number();
                        //TO REPORT
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }      
        //CLEAR
        public void Clear_()
        {
            txtQuantity.Text = "";
            dataGridList.Rows.Clear();
        }
        //ONLY NUMBERS FOR QUANTITY
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
