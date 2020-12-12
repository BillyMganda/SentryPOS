using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SentryPOS.Forms
{
    public partial class Create_New_User : Form
    {
        public Create_New_User()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //CONVERT IMAGE
        byte[] convertImage(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "" || txtLastName.Text == ""|| txtUsername.Text == ""|| txtPassword.Text == "" || comboRole.Text == "")
            {
                MessageBox.Show("User can not be saved! Important fields are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    using(SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        string query = "INSERT INTO User_Info(fName,lName,Username,Password,FingerPrint,Role) VALUES(@fName,@lName,@Username,@Password,@FingerPrint,@Role) ";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@FingerPrint", convertImage(pictureBox1.Image));
                        cmd.Parameters.AddWithValue("@Role", comboRole.Text);
                        cmd.ExecuteNonQuery();
                        saveFullName();
                        this.Cursor = Cursors.WaitCursor;
                        var resultDia = DialogResult.None;
                        resultDia = MessageBox.Show("User saved successfully. Do you wish to add a new user?", "New User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultDia == DialogResult.Yes)
                        {
                            clearTextboxes();
                        }
                        if(resultDia == DialogResult.No)
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
        //CLEAR TEXTBOXES
        public void clearTextboxes()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            comboRole.Text = "";
        }
        //FULL NAMES
        public void saveFullName()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                string query = "UPDATE User_Info SET fullNames=@fName+' '+@lName WHERE fName = '"+txtFirstName.Text+"' AND lName = '"+txtLastName.Text+"' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lName", txtLastName.Text);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
