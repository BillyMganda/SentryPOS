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
using SentryPOS.Classes;


namespace SentryPOS.Forms
{
    public partial class Sales_Dashboard : Form
    {
        public Sales_Dashboard()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;
        SQLConfig pro = new SQLConfig();
        //ONLY NUMBERS FOR BAR CODE
        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //RANDOM TRANSACTION ID
        void randomNumber()
        {
            Random rnd = new Random();
            int tal = rnd.Next(0, 10000000);
            label_SalesID.Text = tal.ToString();
        }
        //DATE & TIME
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            label_Time.Text = today.ToLongTimeString();
            label_Date.Text = today.ToShortDateString();
        }
        private void Sales_Dashboard_Load(object sender, EventArgs e)
        {
            txtBarCode.Focus();
            randomNumber();
            timer1.Start();   
        }
        //FILL BAR CODE
        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double vat = 0.0;                
                double tot = 0.0;
                if (txtBarCode.Text.Length == 13)
                {
                    pro.sqlselect = " SELECT Item_Name, Bar_Code, Units, Avg_SP FROM Stock_Items_View WHERE Bar_Code LIKE '%" + txtBarCode.Text + "%' ";
                    pro.Single_Select(pro.sqlselect);
                    if (pro.dt.Rows.Count > 0)
                    {
                        decimal unitPrice = pro.dt.Rows[0].Field<decimal>("Avg_SP");
                        string[] r = new string[] {pro.dt.Rows[0].Field<string>("Bar_Code"),
                        pro.dt.Rows[0].Field<string>("Item_Name"),
                        unitPrice.ToString("N2"),
                        "1" };

                        dataGridList.Rows.Add(r);

                        txtBarCode.Clear();
                        txtBarCode.Focus();

                        for (int i = 0; i < dataGridList.Rows.Count; i++)
                        {
                            tot += double.Parse(dataGridList.Rows[i].Cells[2].Value.ToString());
                        }
                        label_SubTotal.Text = tot.ToString("N2");
                        label_Tax.Text = vat.ToString();
                        label_Total.Text = tot.ToString("N2");
                        label_ToPay.Text = tot.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //CALCULATE PRICE
        public void calculatePrice()
        {
            try
            {
                double vat = 0.0;
                double tot = 0.0;
                pro.sqlselect = " SELECT Item_Name, Bar_Code, Units, Avg_SP FROM Stock_Items_View WHERE Bar_Code LIKE '%" + txtBarCode.Text + "%' ";
                pro.Single_Select(pro.sqlselect);
                if (pro.dt.Rows.Count > 0)
                {
                    decimal unitPrice = pro.dt.Rows[0].Field<decimal>("Avg_SP");
                    string[] r = new string[] {pro.dt.Rows[0].Field<string>("Bar_Code"),
                        pro.dt.Rows[0].Field<string>("Item_Name"),
                        unitPrice.ToString("N2"),
                        "1" };

                    for (int i = 0; i < dataGridList.Rows.Count; i++)
                    {
                        tot += double.Parse(dataGridList.Rows[i].Cells[2].Value.ToString());
                    }
                    label_SubTotal.Text = tot.ToString("N2");
                    label_Tax.Text = vat.ToString();
                    label_Total.Text = tot.ToString("N2");
                    label_ToPay.Text = tot.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //PUBLIC PROPERTIES
        public static string sub_total = "";
        public static string tax = "";
        public static string total = "";
        public static string to_pay = "";
        public static string sales_id = "";
        //F SOMETHING        
        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {            
            //F1 - CASH PAYMENT
            if (e.KeyCode == Keys.F1)
            {
                btnCash_Click(this, new EventArgs());
            }
            //F2 - MPESA PAYMENT
            if (e.KeyCode == Keys.F2)
            {
                btnMpesa_Click(this, new EventArgs());
            }
            //F3 - CARD PAYMENT
            if (e.KeyCode == Keys.F3)
            {
                MessageBox.Show("You are not subscribed to use this module of the system. Contact 0729703270", "Not Authorised", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Card_Payment cp = new Card_Payment();
                //cp.ShowDialog();
            }
            //F4 - NEW SALE
            if (e.KeyCode == Keys.F4)
            {
                clear_ForNewSale();
            }
            //F5 - END OF DAY
            if (e.KeyCode == Keys.F5)
            {
                MessageBox.Show("You are not subscribed to use this module of the system. Contact 0729703270", "Not Authorised", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //End_of_Day eod = new End_of_Day();
                //eod.ShowDialog();
            }
        }
        
        private void btnCash_Click(object sender, EventArgs e)
        {
            if (dataGridList.Rows.Count == 0)
            {
                MessageBox.Show("No sales to process cash payment", "No Sales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {  
                    //SALE SOME DETAILS TO SALES TABLE
                    using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                    {
                        sqlcon.Open();
                        foreach (DataGridViewRow view in dataGridList.Rows)
                        {
                            string query = "INSERT INTO Sales(Item_Name,Bar_Code,Price,Quantity,Date,Time,Sales_ID) VALUES(@Item_Name,@Bar_Code,@Price,@Quantity,@Date,@Time,@Sales_ID)";
                            SqlCommand cmd = new SqlCommand(query, sqlcon);
                            cmd.Parameters.AddWithValue("@Item_Name", view.Cells["Bar_Code"].Value);
                            cmd.Parameters.AddWithValue("@Bar_Code", view.Cells["Item_Name"].Value);
                            cmd.Parameters.AddWithValue("@Price", view.Cells["Units"].Value);
                            cmd.Parameters.AddWithValue("@Quantity", view.Cells["Avg_SP"].Value);
                            cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(label_Date.Text));
                            cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(label_Time.Text));
                            cmd.Parameters.AddWithValue("@Sales_ID", Convert.ToInt32(label_SalesID.Text));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    //OPEN CASH PAYMENT WINDOW
                    sub_total = label_SubTotal.Text;
                    tax = label_Tax.Text;
                    total = label_Total.Text;
                    to_pay = label_ToPay.Text;
                    sales_id = label_SalesID.Text;
                    Cash_Payment cp = new Cash_Payment();
                    cp.ShowDialog();
                    clear_ForNewSale();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnMpesa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not subscribed to use this module of the system. Contact 0729703270", "Not Authorised", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //if (dataGridList.Rows.Count == 0)
            //{
            //    MessageBox.Show("No sales to process M-Pesa payment", "No Sales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //    try
            //    {
            //        //SALE SOME DETAILS TO SALES TABLE
            //        using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            //        {
            //            sqlcon.Open();
            //            foreach (DataGridViewRow view in dataGridList.Rows)
            //            {
            //                string query = "INSERT INTO Sales(Item_Name,Bar_Code,Price,Quantity,Date,Time,Sales_ID) VALUES(@Item_Name,@Bar_Code,@Price,@Quantity,@Date,@Time,@Sales_ID)";
            //                SqlCommand cmd = new SqlCommand(query, sqlcon);
            //                cmd.Parameters.AddWithValue("@Item_Name", view.Cells["Bar_Code"].Value);
            //                cmd.Parameters.AddWithValue("@Bar_Code", view.Cells["Item_Name"].Value);
            //                cmd.Parameters.AddWithValue("@Price", view.Cells["Units"].Value);
            //                cmd.Parameters.AddWithValue("@Quantity", view.Cells["Avg_SP"].Value);
            //                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(label_Date.Text));
            //                cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(label_Time.Text));
            //                cmd.Parameters.AddWithValue("@Sales_ID", Convert.ToInt32(label_SalesID.Text));
            //                cmd.ExecuteNonQuery();
            //            }
            //        }
            //        //OPEN CASH PAYMENT WINDOW
            //        sub_total = label_SubTotal.Text;
            //        tax = label_Tax.Text;
            //        total = label_Total.Text;
            //        to_pay = label_ToPay.Text;
            //        sales_id = label_SalesID.Text;
            //        Mpesa_Payment mp = new Mpesa_Payment();
            //        mp.ShowDialog();
            //        clear_ForNewSale();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
        }

        private void btbCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not subscribed to use this module of the system. Contact 0729703270", "Not Authorised", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Card_Payment cp = new Card_Payment();
            //cp.ShowDialog();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            clear_ForNewSale();
        }        
        private void btnEndofDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not subscribed to use this module of the system. Contact 0729703270", "Not Authorised", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //End_of_Day eod = new End_of_Day();
            //eod.ShowDialog();
        }
        //CLEAR FOR NEW SALE
        public void clear_ForNewSale()
        {
            randomNumber();
            txtBarCode.Focus();
            dataGridList.Rows.Clear();
            label_SubTotal.Text = "0.00";
            label_Tax.Text = "0.00";
            label_Total.Text = "0.00";
            label_ToPay.Text = "0.00";
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
                calculatePrice();
                txtBarCode.Focus();                
            }
        }
    }
}
