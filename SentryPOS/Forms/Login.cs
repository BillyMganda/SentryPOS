using SentryPOS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SentryPOS.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SQLSelects config = new SQLSelects();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            config.ValidatingAccounts(txtUsername, txtPassword);
            int maxrows = config.dt.Rows.Count;
            if (maxrows > 0)
            {
                MessageBox.Show("Welcome " + config.dt.Rows[0].Field<string>("Role"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (config.dt.Rows[0].Field<string>("Role") == "Administrator")
                {
                    Form frm = new Admin_Dashboard();
                    frm.Show();
                }
                else if (config.dt.Rows[0].Field<string>("Role") == "Cashier")
                {
                    Form frm = new Sales_Dashboard();
                    frm.Show();

                }

                txtUsername.Focus();
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account does not exist! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //ENTER IS LOGIN
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }        
    }
}
