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
    public partial class Create_New_Item : Form
    {
        public Create_New_Item()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Create_New_Item_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT Group_Name FROM Inventory_Groups";
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
                    comboGroup.Items.Add(client_name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //ONLY NUMBERS FOR BARCODE
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || comboGroup.Text == "" ||txtBarcode.Text == "" || txtUnits.Text == "")
            {
                MessageBox.Show("Item can not be saved! Important fields are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "INSERT INTO Inventory_Items(Item_Name, Bar_Code, Group_Name, Date_Created, Units) VALUES(@Item_Name, @Bar_Code, @Group_Name, @Date_Created, @Units)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Item_Name", txtItemName.Text);
                        cmd.Parameters.AddWithValue("@Bar_Code", txtBarcode.Text);
                        cmd.Parameters.AddWithValue("@Group_Name", comboGroup.Text);
                        cmd.Parameters.AddWithValue("@Date_Created", Convert.ToDateTime(dateTimePicker1.Text));
                        cmd.Parameters.AddWithValue("@Units", txtUnits.Text);
                        cmd.ExecuteNonQuery();
                        save_ToInventoryStore();
                        this.Cursor = Cursors.WaitCursor;
                        var resultDia = DialogResult.None;
                        resultDia = MessageBox.Show("Item saved successfully. Do you wish to add a new item?", "New Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultDia == DialogResult.Yes)
                        {
                            Clear_();
                        }
                        if (resultDia == DialogResult.No)
                        {
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Clear_()
        {
            txtItemName.Text = "";
            txtBarcode.Text = "";
            comboGroup.Text = "";
            txtUnits.Text = "";
        }
        //SAVE TO INVENTORY ITEMS STORE TABLE
        public void save_ToInventoryStore()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "INSERT INTO Inventory_Items_Store(Item_Name, Bar_Code, Group_Name, Date_Created, Units) VALUES(@Item_Name, @Bar_Code, @Group_Name, @Date_Created, @Units)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Item_Name", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@Bar_Code", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@Group_Name", comboGroup.Text);
                    cmd.Parameters.AddWithValue("@Date_Created", Convert.ToDateTime(dateTimePicker1.Text));
                    cmd.Parameters.AddWithValue("@Units", txtUnits.Text);
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
