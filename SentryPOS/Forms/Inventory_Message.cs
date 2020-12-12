using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SentryPOS.Forms
{
    public partial class Inventory_Message : Form
    {
        public Inventory_Message()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;
        //LOAD TO DATAGRID FROM INVENTORY_LIMITS_VIEW
        public void load_fromLimits()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Item_Name,Bar_Code,Units,Sum_Quantity,Lower_Limit,Avg_BP FROM Inventory_Limits_View WHERE Sum_Quantity < Lower_Limit", sqlcon);
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
        private void Inventory_Message_Load(object sender, EventArgs e)
        {
            load_fromLimits();
        }
    }
}
