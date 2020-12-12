﻿using System;
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
    public partial class Purchase_by_Supplier : Form
    {
        public Purchase_by_Supplier()
        {
            InitializeComponent();
        }
        static string connectionstring = ConfigurationManager.ConnectionStrings["SentryPOS.Properties.Settings.myConnection"].ConnectionString;
        ReportDocument crystal = new ReportDocument();
        private void Purchase_by_Supplier_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Received_Goods WHERE Quantity <> 0 ORDER BY ID DESC", con);
                    DataSet dst = new DataSet();
                    sda.Fill(dst, "Received_Goods");
                    crystal.Load(@"C:\Users\Billy Isogol\Desktop\C#\SentryPOS\SentryPOS\CrystalReports\PurchaseBySupplier.rpt");
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
