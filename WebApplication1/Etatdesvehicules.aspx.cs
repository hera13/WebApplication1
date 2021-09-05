using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["uuser"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            try
            {

                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select matricule,N from TB_G ");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    DropDownList1.DataSource = ds;
                    DropDownList1.DataTextField = "matricule";
                    DropDownList1.DataValueField = "N";
                    DropDownList1.DataBind();
                    ClassCon.con.Close();
                }


                ClassCon.connect();
                ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G  order by N");
                DataTable ds2 = new DataTable();
                ds2.Rows.Clear();
                ds2.Load(ClassCon.reader);
                GridView1.DataSource = ds2;
                GridView1.DataBind();
                ClassCon.con.Close();

            }
            catch
            {

            }



            



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G where matricule='" + DropDownList1.SelectedItem.Text + "' order by N");
                DataTable ds2 = new DataTable();
                ds2.Load(ClassCon.reader);
                GridView1.DataSource = ds2;

                GridView1.DataBind();
                ClassCon.con.Close();
            }
            catch
            {

            }
            
     

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G  order by N");
                DataTable ds2 = new DataTable();
                ds2.Load(ClassCon.reader);
                GridView1.DataSource = ds2;

                GridView1.DataBind();
                ClassCon.con.Close();
            }
            catch
            {

            }
          
         

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrintVehicules.aspx");

        }
    }
}