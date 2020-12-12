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
using System.IO;
using System.Net;
using System.Net.Http;

namespace SentryPOS.Forms
{
    public partial class Mpesa_Payment : Form
    {
        public Mpesa_Payment()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        //LOAD
        private void Mpesa_Payment_Load(object sender, EventArgs e)
        {
            txtSubTotal.Text = Sales_Dashboard.sub_total;
            txtTax.Text = Sales_Dashboard.tax;
            txtTotal.Text = Sales_Dashboard.total;
            txtToPay.Text = Sales_Dashboard.to_pay;
            label_Sales.Text = Sales_Dashboard.sales_id;
            txt_Phone.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (textBox_Amount.Text == "")
            {
                MessageBox.Show("No amount found for the sale", "Transaction not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtBalance.Text == "")
            {
                MessageBox.Show("No amount found for the sale", "Enter submited amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (double.Parse(textBox_Amount.Text) < double.Parse(txtToPay.Text))
            {
                MessageBox.Show("Amount submited is less than the value of bought items, ask customer to top up", "Less than value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        cmd.Parameters.AddWithValue("@Amount_Submited", Convert.ToDouble(textBox_Amount.Text));
                        cmd.Parameters.AddWithValue("@Balance", Convert.ToDouble(txtBalance.Text));
                        cmd.ExecuteNonQuery();
                        Close();
                        //PRINT RECEIPT
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //ONLY NUMBERS FOR PHONE NUMBER
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //ESCAPE TO CLOSE WINDOW & ENTER TO CHANGE FOCUS TO AMOUNT      -- SAFARICOM API COMES HERE
        private void txt_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //search mobile number & populate amount with corresponding amount
                //1.
                string a = "https://sandbox.safaricom.co.ke/oauth/v1/generate?grant_type=client_credentials";
                string baseUrl = a;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl);
                //2.
                string token = "ACCESS_TOKEN";
                request.Headers.Add("authorization", "Bearer " + token);
                request.Method = "POST";
                request.ContentType = "application/json";

                string json = "{\"InitiatorName\":\" here\"," +
                                "\"SecurityCredential\":\" here \"," +
                                "\"CommandID\":\" here \"," +
                                "\"Amount\":\" here \"," +
                                "\"PartyA\":\" here \"," +
                                "\"PartyB\":\" here \"," +
                                "\"Remarks\":\" here \"," +
                                "\"QueueTimeOutURL\":\"http://your_timeout_url\"," +
                                "\"ResultURL\":\"http://your_result_url\"," +
                                "\"Occasion\":\" here \"}";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    //the string (json) should be here
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                //3
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Close();


                textBox_Amount.Focus();
            }
        }
        //CALCULATE BALANCE
        private void textBox_Amount_TextChanged(object sender, EventArgs e)
        {
            decimal to_pay = Convert.ToDecimal(txtToPay.Text);
            decimal submited_amount = Convert.ToDecimal(textBox_Amount.Text);
            decimal balance = submited_amount - to_pay;
            txtBalance.Text = balance.ToString();
        }
        //PAY
        private void textBox_Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPay_Click(this, new EventArgs());
            }
        }
    }
}
