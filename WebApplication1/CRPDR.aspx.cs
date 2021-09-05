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
    public partial class CRPDR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.AsyncRendering = false;
            ReportViewer1.SizeToReportContent = true;
            ReportViewer1.ZoomMode = ZoomMode.FullPage;
            if (Request.QueryString["ID"] == null)
            {
                Response.Redirect("reparation.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ID = Request["ID"].ToString();
            ClassCon.connect();
            string str = "select t2.Nom,t2.matricule,t2.Marque,t2.Type,t2.Carburant,t2.Organisme,t2.Service,t1.designation,t1.Numbers,t1.kilometrage,t1.nn";
            str = str + "  from test1 t1,TB_G t2 where t1.matricule=t2.matricule and t1.matricule='" + ID + "'";


            ClassCon.sqlconnection(str);




            DataTable dt = new DataTable();
            dt.Load(ClassCon.reader);
            ClassCon.con.Close();
            ReportDataSource datasource = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
            ReportViewer1.LocalReport.Refresh();
        }
    }
}