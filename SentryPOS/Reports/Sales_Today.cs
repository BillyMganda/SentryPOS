using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SentryPOS.Reports
{
    public partial class Sales_Today : Form
    {
        public Sales_Today()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;
        ReportDocument crystal = new ReportDocument();
        private void Sales_Today_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sales WHERE Date = CAST( GETDATE() AS Date) AND Total <> '' ORDER BY ID DESC", con);
                    DataSet dst = new DataSet();
                    sda.Fill(dst, "Sales");
                    crystal.Load(@"C:\Users\Billy Isogol\Desktop\C#\SentryPOS\SentryPOS\CrystalReports\TodaysSales.rpt");
                    crystal.SetDataSource(dst);
                    crystalReportViewer1.ReportSource = crystal;
                    crystal.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
                    //crystal.SummaryInfo.ReportTitle = label_InvoiceNumber.Text;
                    crystal.PrintOptions.PaperSize = PaperSize.PaperA4;
                    //crystal.PrintToPrinter(1, false, 0, 0);
                    //crystal.PrintOptions.PrinterName = label_PrinterName.Text;
                    crystal.Close();
                    crystal.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
