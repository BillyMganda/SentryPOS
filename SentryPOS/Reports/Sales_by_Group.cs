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
    public partial class Sales_by_Group : Form
    {
        public Sales_by_Group()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;
        ReportDocument crystal = new ReportDocument();
        private void Sales_by_Group_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sales_by_Group_View", con);
                    DataSet dst = new DataSet();
                    sda.Fill(dst, "Sales_by_Group_View");
                    crystal.Load(@"C:\Users\Billy Isogol\Desktop\C#\SentryPOS\SentryPOS\CrystalReports\SalesByGroup.rpt");
                    crystal.SetDataSource(dst);
                    crystalReportViewer1.ReportSource = crystal;
                    crystal.PrintOptions.PaperOrientation = PaperOrientation.Landscape;
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
