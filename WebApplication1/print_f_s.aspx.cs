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
	public partial class print_f_s : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Request.QueryString["ID"] == null)
            {
                Response.Redirect("reparation.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ID = Request["ID"].ToString();
            ClassCon.connect();
            string str = "select tb2.matricule,tb2.N,tb2.Nom,tb1.designation,tb1.Numbers,tb2.Marque,tb2.Type,tb1.fournisseur from fiche_signa tb1,TB_G tb2 where tb1.matricule = tb2.matricule  and tb1.matricule='"+ID+"'";
            ClassCon.sqlconnection(str);
            DataTable dt = new DataTable();
            dt.Load(ClassCon.reader);
            ClassCon.con.Close();
            ReportDataSource datasource = new ReportDataSource("DataSet3", dt);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
            ReportViewer1.LocalReport.Refresh();

        }
    }
}