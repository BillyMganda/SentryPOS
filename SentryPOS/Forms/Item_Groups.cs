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
    public partial class Item_Groups : Form
    {
        public Item_Groups()
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
            if(txtGroupName.Text == "")
            {
                MessageBox.Show("Group can not be saved! Important fields are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "INSERT INTO Inventory_Groups(Group_Name, Date_Created) VALUES(@Group_Name, @Date_Created)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Group_Name", txtGroupName.Text);
                        cmd.Parameters.AddWithValue("@Date_Created", Convert.ToDateTime(dateTimePicker1.Text));
                        cmd.ExecuteNonQuery();
                        this.Cursor = Cursors.WaitCursor;
                        var resultDia = DialogResult.None;
                        resultDia = MessageBox.Show("Group saved successfully. Do you wish to add a new group?", "New Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        //CLEAR
        public void Clear_()
        {
            txtGroupName.Text = "";
        }
    }
}
