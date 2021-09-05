using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.Reporting.WebForms;

namespace WebApplication1
{
    public partial class PrintVehicules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //String ID = Request["ID"].ToString();

            ClassCon.connect();
            string str = "select * from TB_G";


            ClassCon.sqlconnection(str);




            DataTable dt = new DataTable();
            dt.Load(ClassCon.reader);
            ClassCon.con.Close();
            ReportDataSource datasource = new ReportDataSource("DataSet2", dt);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
            ReportViewer1.LocalReport.Refresh();
        }
    }
}