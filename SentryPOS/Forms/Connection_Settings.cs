﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace SentryPOS.Forms
{
    public partial class Connection_Settings : Form
    {
        string cs = "";
        //used to store the sql connection string 
        string osb = "";
        //used to store the oledb connection string 
        string dbname = "";
        //used o store the name of the database 
        
        bool goodCon = false;
        public Connection_Settings()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        /// <summary>
        /// Returns a list of SQL servers
        /// </summary>
        /// <returns></returns>
        private string[] GetSQLServerList()
        {
            SqlDataSourceEnumerator dse = SqlDataSourceEnumerator.Instance;
            DataTable dt = dse.GetDataSources();
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            string[] SQLServers = new string[dt.Rows.Count];
            int f = -1;
            foreach (DataRow r in dt.Rows)
            {
                string SQLServer = r["ServerName"].ToString();
                string Instance = r["InstanceName"].ToString();
                if (Instance != null && !string.IsNullOrEmpty(Instance))
                {
                    SQLServer += "\\" + Instance;
                }
                SQLServers[System.Math.Max(System.Threading.Interlocked.Increment(ref f), f - 1)] = SQLServer;
            }
            Array.Sort(SQLServers);
            return SQLServers;
        }
        /// <summary>
        /// Returns a list of user databases on the specified server instance 
        /// </summary>
        /// <param name="serverInstanceName">Name of server and if applicable the instance name: ADMIN\SQLEXPRESS or MYSQLSERVER</param>
        /// <param name="useWindowsAuthentication">true if SSPI should be used; otherwise the username and password must be specified.</param>
        /// <param name="username">username of an SQL server user account</param>
        /// <param name="password">password for the SQL account specified by the username above fixed string array containing the list of user databases </param>
        /// <returns></returns>
        /// 
        private string[] GetSQLDatabaseList(string serverInstanceName, bool useWindowsAuthentication, string username, string password)
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = serverInstanceName;
            //cmbServers.Text 'cboSrcDB.Text 
            csb.IntegratedSecurity = useWindowsAuthentication;
            //csb.TrustServerCertificate = useWindowsAuthentication 
            csb.InitialCatalog = "master";
            if (!useWindowsAuthentication)
            {
                csb.UserID = username;
                csb.Password = password;
            }


            SqlConnection conn = new SqlConnection(csb.ToString());


            // The 'where name like 'f%_' will filter out just those databases begining with "F" or "f" 
            SqlDataAdapter da = new SqlDataAdapter("Select name from sysdatabases ", conn);
            //removed the following from above query so that all databases would be shown 
            // where name like 'f%_' 
            try
            {
                DataTable dt = new DataTable("Databases");
                int rowsAffected = da.Fill(dt);
                if (dt == null || rowsAffected <= 0)
                {
                    return null;
                }

                int f = -1;
                string[] databases = new string[dt.Rows.Count];
                foreach (DataRow r in dt.Rows)
                {
                    databases[System.Math.Max(System.Threading.Interlocked.Increment(ref f), f - 1)] = r["name"].ToString();
                }
                da.Dispose();
                Array.Sort(databases);
                return databases;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cannot obtain database list:\n" + ex.Message, "Migration Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        private void BuildConnection()
        {
            if (String.IsNullOrEmpty(cmbServers.Text) || String.IsNullOrEmpty(cmbDatabases.Text))
                return;

            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

            if (chkUseWindowsSecurity.Checked)
            {
                csb.DataSource = cmbServers.Text;
                csb.IntegratedSecurity = chkUseWindowsSecurity.Checked;
                csb.InitialCatalog = cmbDatabases.Text;
                cs = csb.ToString();


                osb = "Provider = SQLOLEDB.1;Integrated Security = SSPI;Persist Security Info = False; Initial Catalog = " + cmbDatabases.Text + ";Data Source = " + cmbServers.Text;
            }
            else
            {

                csb.DataSource = cmbServers.Text;
                csb.IntegratedSecurity = chkUseWindowsSecurity.Checked;
                csb.InitialCatalog = cmbDatabases.Text;
                csb.UserID = txtUserName.Text;
                csb.Password = txtPassword.Text;
                cs = csb.ToString();

                osb = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID= " + txtUserName.Text + ";Initial Catalog= " + cmbDatabases.Text + ";Data Source = " + cmbServers.Text;

                dbname = cmbDatabases.Text;
            }
        }
        //LOAD DATA TO FORM
        public void loadAllDataToForm()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(connectionstring);
                DataTable dt = new DataTable();
                sqlcon.Open();
                SqlDataReader myReader = null;
                string query = "SELECT Server FROM ServerSettings";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                myReader = sqlcmd.ExecuteReader();
                while (myReader.Read())
                {
                    cmbServers.Text = (myReader["Server"].ToString());
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //FORM LOAD
        private void Connection_Settings_Load(object sender, EventArgs e)
        {
            loadAllDataToForm();
            if (cmbServers.Text == "")
            {
                //do nothing
            }
            else
            {
                Login vpf = new Login();
                vpf.ShowDialog();
                this.Hide();
                this.ShowInTaskbar = false;
            }
            
        }

        private void cmbServers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chkUseWindowsSecurity.Checked)
            {
                cmbDatabases.Items.AddRange(GetSQLDatabaseList(cmbServers.Text, true, txtUserName.Text, txtPassword.Text));
                //now disable the find databses button if we have a list 
                if (cmbDatabases.Items.Count != 0)
                {
                    btnFindDatabases.Enabled = false;
                }
                else
                {
                    btnFindDatabases.Enabled = true;
                }
            }
            else
            {

            }
        }

        private void btnFindServers_Click(object sender, EventArgs e)
        {
            try
            {
                //it's possible to duplicate the list so we need to ensure that there isn't one already
                if (cmbServers.Items.Count != 0)
                {
                }
                else
                {
                    cmbServers.Items.AddRange(GetSQLServerList());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /*Windows Security*/
        private void chkUseWindowsSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseWindowsSecurity.Checked)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                chkBlankPassAllowed.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                chkBlankPassAllowed.Enabled = true;
            }
        }

        private void chkUseWindowsSecurity_CheckStateChanged(object sender, EventArgs e)
        {
            //by default the button is checked if this is fire then the user intends using user authentification 
            //firstly reinstate the enabled state of the browse for databases button if its disabled 
            if (btnFindDatabases.Enabled == false)
            {
                btnFindDatabases.Enabled = true;
            }
        }
        /*Select Database*/
        private void cmbDatabases_Click(object sender, EventArgs e)
        {
            if (chkUseWindowsSecurity.Checked == false)
            {
                if (chkBlankPassAllowed.Checked == false)
                {


                    if (string.IsNullOrEmpty(txtUserName.Text))
                    {
                        string msg = "You have unchecked the 'Use Windows Security' checkbox.\n" + "Consequently you must enter a user name";
                        MessageBox.Show(msg, "No User Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserName.Focus();

                        return;
                    }
                    else if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        string msg = "A password is required.\n" + "If you know the password is blank, check the 'Blank Password Allowed' box.";

                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //don't worry no password was deliberate. 
                        //it's possible to get caught in a loop here so add a check to say cancel has been pressed 


                        txtPassword.Focus();
                        return;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtUserName.Text))
                    {
                        string msg = "You have unchecked the 'Use Windows Security' checkbox.\n" + "Consequently you must enter a user name";
                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserName.Focus();
                        return;
                    }
                }

                //we have info so process it 
                try
                {


                    cmbDatabases.Items.AddRange(GetSQLDatabaseList(cmbServers.Text, false, txtUserName.Text, txtPassword.Text));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("There has been an error trying to connect to the database with the parameters you entered.\n" + ex.Message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

            }
        }

        private void btnFindDatabases_Click(object sender, EventArgs e)
        {
            //it's possible to duplicate the list so we need to ensure that there isn't one already 
            if (cmbDatabases.Items.Count != 0)
            {
            }
            else
            {
                if (chkUseWindowsSecurity.Checked)
                {

                    //we just need to do a check with no details 

                    cmbDatabases.Items.AddRange(GetSQLDatabaseList(cmbServers.Text, true, txtUserName.Text, txtPassword.Text));
                }
                else
                {
                    //we need to do a check with details 


                    cmbDatabases.Items.AddRange(GetSQLDatabaseList(cmbServers.Text, false, txtUserName.Text, txtPassword.Text));
                }
            }
        }
        /*Form Buttons*/
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            BuildConnection();
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                MessageBox.Show("Connection to database was successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                goodCon = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to the database\n" + ex.Message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cs))
            {
                //we have a connection string 
                if (goodCon == true)
                {
                    //it was validated so we can go ahead and save it 
                    //firstly as xml 
                    //string fname = Path.GetDirectoryName(Application.LocalUserAppDataPath) + "\\ConnectionStrings.xml";
                    string fname = "C:\\SentryPOS\\ConnectionStrings.xml";
                    XmlTextWriter writer = new XmlTextWriter(fname, null);
                    writer.Formatting = Formatting.Indented;
                    WriteConnectionStrings(writer, cs, osb);
                    writer.Close();
                    save_database();
                    this.Close();
                    //In order to use the new connection string you have just created the application needs to close.
                    //When you restart the application you should load the connection string from the xml file.
                    //Application.Exit();
                    
                }
                else
                {
                    //connection wasn't validated so just close 
                    this.Close();
                }
            }
        }
        public void WriteConnectionStrings(XmlWriter writer, string sqlcon, string oledbcon)
        {
            writer.WriteStartElement("ConnectionStrings");
            writer.WriteElementString("SqlConnectionString", sqlcon);
            writer.WriteElementString("DatabaseName", dbname);
            writer.WriteEndElement();
        }
        public void save_database()
        {
            try
            {
                if(cmbServers.Text == ""|| cmbDatabases.Text == "")
                {
                    MessageBox.Show("Fill all database entries to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection sqlcon = new SqlConnection(cs))
                    {
                        if (sqlcon.State == ConnectionState.Closed)
                            sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("PROC_ServerSettings", sqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Server", cmbServers.Text);
                        cmd.Parameters.AddWithValue("@SQL_Database", cmbDatabases.Text);                        
                        cmd.ExecuteNonQuery();                        
                        Hide();

                        Login log = new Login();
                        log.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error saving entered values, check connection to database.\n" + ex.Message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
