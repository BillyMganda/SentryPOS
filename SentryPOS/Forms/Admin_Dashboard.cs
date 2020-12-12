using SentryPOS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SentryPOS.Forms
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_User cnu = new Create_New_User();
            cnu.ShowDialog();
        }

        private void changeUserStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Status us = new User_Status();
            us.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_User du = new Delete_User();
            du.ShowDialog();
        }

        private void createNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Supplier ns = new Create_New_Supplier();
            ns.ShowDialog();
        }

        private void changeSupplierStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Status st = new Supplier_Status();
            st.ShowDialog();
        }

        private void deleteSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Supplier ds = new Delete_Supplier();
            ds.ShowDialog();
        }

        private void createItemGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item_Groups ig = new Item_Groups();
            ig.ShowDialog();
        }

        private void createNewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Item cni = new Create_New_Item();
            cni.ShowDialog();
        }

        private void itemPricingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item_Pricing ip = new Item_Pricing();
            ip.ShowDialog();
        }
        //LOAD STOCK ITEMS
        public void fill_Stock_Items()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Item_Name, Bar_Code, Units, Sum_Quantity, Avg_BP, Avg_SP FROM Stock_Items_View", sqlcon);
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
        //LOAD RECEIVED GOODS
        public void fill_Received_Goods()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Item_Name, Item_Code, Units, Quantity, Unit_Price, Order_ID, Supplier, Received_Date FROM Received_Goods WHERE Quantity <> 0 ORDER BY Received_Date DESC", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGrid_Received.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //LOAD SALES DATA
        public void fill_Sales()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter($"SELECT Item_Name, Bar_Code, Price, To_Pay, Amount_Submited, Balance, Sales_ID, Date, Time FROM Sales WHERE To_Pay <> '' ORDER BY ID DESC", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGrid_Sales.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            fill_Stock_Items();
            fill_Received_Goods();
            fill_Sales();
        }

        private void inventoryMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Order po = new Purchase_Order();
            po.ShowDialog();
        }

        private void receiveOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receive_Orders ro = new Receive_Orders();
            ro.ShowDialog();
        }

        private void inventoryMessageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventory_Message im = new Inventory_Message();
            im.ShowDialog();
        }

        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Details cd = new Company_Details();
            cd.ShowDialog();
        }

        private void inventoryLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_Limits il = new Inventory_Limits();
            il.ShowDialog();
        }

        private void updateItemSellingPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Item_Selling_Price usp = new Update_Item_Selling_Price();
            usp.ShowDialog();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ln = new Login();
            ln.Show();
        }


        //REPORTS

        //PURCHASE REPORTS
        private void purchaseByItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_by_Item by_Item = new Purchase_by_Item();
            by_Item.Show();
        }

        private void purchaseByGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_by_Group by_Group = new Purchase_by_Group();
            by_Group.Show();
        }

        private void purchaseBySupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_by_Supplier by_Supplier = new Purchase_by_Supplier();
            by_Supplier.Show();
        }

        private void totalPuchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_by_Item by_Item = new Purchase_by_Item();
            by_Item.Show();
        }

        //INVENTORY REPORTS
        private void stockOnHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_on_Hand on_Hand = new Stock_on_Hand();
            on_Hand.Show();
        }

        //SALES REPORTS
        private void salesByItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_by_Item by_Item = new Sales_by_Item();
            by_Item.Show();
        }

        private void salesByGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_by_Group by_Group = new Sales_by_Group();
            by_Group.Show();
        }

        private void totalSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Total_Sales total = new Total_Sales();
            total.Show();
        }

        private void salesBalanceForTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Today today = new Sales_Today();
            today.Show();
        }
    }
}
 