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
    public partial class End_of_Day : Form
    {
        public End_of_Day()
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
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "INSERT INTO Cashier_EndofDay(Date,[1000],[500],[200],[100],[50],[40],[20],[10],[5],[1],Starting_Float) VALUES(@Date,@1000,@500,@200,@100,@50,@40,@20,@10,@5,@1,@Starting_Float)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateTimePicker1.Text));
                    cmd.Parameters.AddWithValue("@1000", num1000.Value);
                    cmd.Parameters.AddWithValue("@500", num500.Value);
                    cmd.Parameters.AddWithValue("@200", num200.Value);
                    cmd.Parameters.AddWithValue("@100", num100.Value);
                    cmd.Parameters.AddWithValue("@50", num50.Value);
                    cmd.Parameters.AddWithValue("@40", num40.Value);
                    cmd.Parameters.AddWithValue("@20", num20.Value);
                    cmd.Parameters.AddWithValue("@10", num10.Value);
                    cmd.Parameters.AddWithValue("@5", num5.Value);
                    cmd.Parameters.AddWithValue("@1", num1.Value);
                    cmd.Parameters.AddWithValue("@Starting_Float", numericStatingFloat.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("End of day successful, This should only be done once a day", "End of Day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //END OF DAY REPORT HERE
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
