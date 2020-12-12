using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using SentryPOS.Forms;
using CrystalDecisions.Shared;

namespace SentryPOS.Reports
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;
        ReportDocument crystal = new ReportDocument();

        private void Receipt_Load(object sender, EventArgs e)
        {
            label_salesID.Text = Cash_Payment.sales_id;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM Sales WHERE Sales_ID = '" +Convert.ToInt32(label_salesID.Text)+ "' ", con);
                    DataSet dst = new DataSet();
                    sda.Fill(dst, "Sales");
                    crystal.Load(@"C:\Users\Billy Isogol\Desktop\C#\SentryPOS\SentryPOS\CrystalReports\Sales.rpt");
                    crystal.SetDataSource(dst);
                    crystalReportViewer2.ReportSource = crystal;
                    crystal.PrintOptions.PaperOrientation = PaperOrientation.Landscape;
                    //crystal.SummaryInfo.ReportTitle = label_DocNumber.Text;
                    crystal.PrintOptions.PaperSize = PaperSize.Paper10x14;
                    crystal.PrintToPrinter(1, false, 0, 0);
                    //crystal.PrintOptions.PrinterName = label_Printer.Text;
                    crystal.Close();
                    crystal.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
