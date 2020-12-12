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
using SentryPOS.Reports;

namespace SentryPOS.Forms
{
    public partial class Cash_Payment : Form
    {
        public Cash_Payment()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;
        
        //LOAD
        private void Cash_Payment_Load(object sender, EventArgs e)
        {
            txtSubTotal.Text = Sales_Dashboard.sub_total;
            txtTax.Text = Sales_Dashboard.tax;
            txtTotal.Text = Sales_Dashboard.total;
            txtToPay.Text = Sales_Dashboard.to_pay;
            label_Sales.Text = Sales_Dashboard.sales_id;
            textBox_Submited.Focus();
        }        
        //CLOSE
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //PAY
        public static string sales_id = "";
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(textBox_Submited.Text == "" || txtBalance.Text == "")
            {
                MessageBox.Show("Enter submited amount to proceed","Enter submited amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (double.Parse(textBox_Submited.Text) < double.Parse(txtToPay.Text))
            {
                MessageBox.Show("Amount submited is less than the value of bought items, ask customer to top up","Less than value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "UPDATE Sales SET Sub_Total=@Sub_Total, Tax=@Tax, Total=@Total, To_Pay=@To_Pay, Amount_Submited=@Amount_Submited, Balance=@Balance WHERE Sales_ID = '" + Convert.ToInt32(label_Sales.Text) + "' ";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Sub_Total", Convert.ToDouble(txtSubTotal.Text));
                        cmd.Parameters.AddWithValue("@Tax", Convert.ToDouble(txtTax.Text));
                        cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(txtTotal.Text));
                        cmd.Parameters.AddWithValue("@To_Pay", Convert.ToDouble(txtToPay.Text));
                        cmd.Parameters.AddWithValue("@Amount_Submited", Convert.ToDouble(textBox_Submited.Text));
                        cmd.Parameters.AddWithValue("@Balance", Convert.ToDouble(txtBalance.Text));
                        cmd.ExecuteNonQuery();
                        Close();
                        //PRINT RECEIPT
                        sales_id = label_Sales.Text;
                        Receipt receipt = new Receipt();
                        receipt.Show();
                        //REDUCE STOCK
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //ONLY NUMBERS
        private void textBox_Submited_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //ESCAPE TO CLOSE WINDOW & ENTER TO PAY 
        private void textBox_Submited_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnPay_Click(this, new EventArgs());
            }
        }
        //CALCULATE BALANCE
        private void textBox_Submited_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal to_pay = Convert.ToDecimal(txtToPay.Text);
                decimal submited_amount = Convert.ToDecimal(textBox_Submited.Text);
                decimal balance = submited_amount - to_pay;
                txtBalance.Text = balance.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You can not have a zero or negative amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //REDUCE STOCK
        public void reduce_Stock()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "INSERT INTO Stock_Items()VALUES()";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Sub_Total", Convert.ToDouble(txtSubTotal.Text));
                    cmd.Parameters.AddWithValue("@Tax", Convert.ToDouble(txtTax.Text));
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(txtTotal.Text));
                    cmd.Parameters.AddWithValue("@To_Pay", Convert.ToDouble(txtToPay.Text));
                    cmd.Parameters.AddWithValue("@Amount_Submited", Convert.ToDouble(textBox_Submited.Text));
                    cmd.Parameters.AddWithValue("@Balance", Convert.ToDouble(txtBalance.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
