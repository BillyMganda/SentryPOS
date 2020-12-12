using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace SentryPOS.Classes
{
    class SQLConfig
    {
        public SqlConnection strcon = new SqlConnection(@"Data Source=MGANDAPC\SQLEXPRESS;Database=SentryPOS;trusted_connection=true;");        
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public int result;
        public string sqladd;
        public string sqledit;
        public string sqlselect;
        public string msgadd;
        public string msgedit;
        public string sql;
        public string msg;


        public void SaveUpdate(string sqlselect, string sqladd, string msgadd, string sqledit, string msgedit)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sqlselect;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                int maxrows = dt.Rows.Count;

                if (maxrows > 0)
                {
                    //updating in the database; 
                    cmd = new SqlCommand();
                    cmd.Connection = strcon;
                    cmd.CommandText = sqledit;
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(msgedit);
                    }

                }
                else
                {
                    //adding in the database
                    cmd = new SqlCommand();
                    cmd.Connection = strcon;
                    cmd.CommandText = sqladd;
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(msgadd);
                        //user 
                        if (msgadd == "New User has been saved in the database.")
                        {
                            //auto inc
                            strcon.Close();
                            UpdateAutonumber(2);
                            strcon.Open();
                        }
                        //end user

                        //Product 
                        if (msgadd == "New Product has been saved in the database.")
                        {
                            msg = "New Product has been saved in the database.";

                        }
                        //end Product
                        //Category 
                        if (msgadd == "New Category has been saved in the database.")
                        {
                            //auto inc
                            strcon.Close();
                            UpdateAutonumber(4);
                            strcon.Open();
                        }
                        //end Category
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strcon.Close();
            }

        }
        //LOAD DATA
        public void LoadData(string sqlselect, DataGridView dtg)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sqlselect;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }
        //SAVE DATA
        public void SaveDataMsg(string sql, string msg)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(msg);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }

        }
        //SAVE DATA
        public void SaveData(string sql)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }

        }
        //PASSING AUTO NUMBER
        public void PassingAutonumberLbl(int id, Label txt)
        {
            try
            {
                strcon.Open();

                //cmd = new SqlCommand();
                //cmd.Connection = strcon;
                //cmd.CommandText = "Select AutoStart , AutoEnd FROM tblAutonumber Where CategoryId=" + id;
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);
                //txt.Text = dt.Rows[0].Field<string>("AutoStart") + dt.Rows[0].Field<int>("AutoEnd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }
        //UPDATE PRODUCT AUTO NUMBER
        public void UpdateProductAutonumber(ComboBox id)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = "UPDATE tblAutonumber SET  AutoEnd = AutoEnd + AutoIncrement Where CategoryId=" + id.SelectedValue;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strcon.Close();
            }
        }
        //FILL AUTO NUMBER
        public void FillAutonumber(int id, Label txt)
        {
            try
            {
                //strcon.Open();

                //cmd = new SqlCommand();
                //cmd.Connection = strcon;
                //cmd.CommandText = "Select AutoStart , AutoEnd FROM tblAutonumber Where AutoId=" + id;
                //da = new SqlDataAdapter();
                //da.SelectCommand = cmd;
                //dt = new DataTable();
                //da.Fill(dt);
                //txt.Text = dt.Rows[0].Field<string>("AutoStart") + dt.Rows[0].Field<int>("AutoEnd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }

        //UPDATE AUTO NUMBER
        public void UpdateAutonumber(int id)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = "UPDATE tblAutonumber SET  AutoEnd = AutoEnd + AutoIncrement Where AutoId=" + id;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strcon.Close();
            }
        }

        //FILL COMBOBOX
        public void FillComboBox(string sql, string field, string id, ComboBox cbo)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sql;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.ValueMember = field;
                cbo.DisplayMember = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }

        //SINGLE SELECT
        public void Single_Select(string sqlselect)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sqlselect;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                //txt.Text = dt.Rows[0].Field<string>(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }

        //RESPONSIVE DATAGRID
        public void ResponsiveDtg(DataGridView dtg)
        {
            dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        //DATAGRID COLOR
        public void dtgcolor(DataGridView dtg, int value)
        {
            try
            {

                //DataGridViewRow rw = new DataGridViewRow();
                dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                foreach (DataGridViewColumn c in dtg.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.Programmatic;
                }

                foreach (DataGridViewRow rw in dtg.Rows)
                {
                    if (Convert.ToInt32(rw.Cells[value].Value) < 10)
                    {
                        rw.DefaultCellStyle.BackColor = Color.Red;
                        rw.DefaultCellStyle.SelectionBackColor = Color.Red;
                        rw.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
