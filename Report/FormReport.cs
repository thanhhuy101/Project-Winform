using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Report
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'huynhhuu_foodDataSet.vw_Report' table. You can move, or remove it, as needed.
            //this.vw_ReportTableAdapter.Fill(this.huynhhuu_foodDataSet.vw_Report);

            this.reportViewer1.RefreshReport();        
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            LocalReport report = reportViewer1.LocalReport;
            report.DataSources.Clear();

            //dataset
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016;User Id=huynhhuu_food; Password=123456; database=huynhhuu_food";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from vw_Report where ID_order = '" + txt_orderID.Text + "' ", con);
            try
            {
                con.Open();
                adapter.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {

            }

            //add ds
            ReportDataSource dsFood = new ReportDataSource();
            dsFood.Name = "DSFood";
            dsFood.Value = ds.Tables[0];
            // add rp into report
            report.DataSources.Add(dsFood);
            //refresh
            this.reportViewer1.RefreshReport();
        }
    }
}
