using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebApplication1
{
    public partial class WebForm12 : System.Web.UI.Page
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
                    ClassCon.dt.Clear();
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from Organisme");
                    ClassCon.dt.Load(ClassCon.reader);
                    organisme.DataSource = ClassCon.dt;
                    organisme.DataTextField = "name_Organisme";
                    organisme.DataValueField = "id";
                    organisme.DataBind();
                    ClassCon.con.Close();
                }


            
             
             
         
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select N,Puissance_fiscale from VEHICULE");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    puissance.DataSource = ds;
                    puissance.DataTextField = "Puissance_fiscale";
                    puissance.DataValueField = "N";
                    puissance.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select id,name_type from type_j");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    puissance.DataSource = ds;
                    puissance.DataTextField = "name_type";
                    puissance.DataValueField = "id";
                    puissance.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from tsva");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    TSVA.DataSource = ds;
                    TSVA.DataTextField = "tsva";
                    TSVA.DataValueField = "id";
                    TSVA.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select N,Immatriculation from VEHICULE");
                    DataTable ds4 = new DataTable();
                    ds4.Load(ClassCon.reader);
                    velo.DataSource = ds4;
                    velo.DataTextField = "Immatriculation";
                    velo.DataValueField = "N";
                    velo.DataBind();
                    ClassCon.con.Close();

                }
            }
            catch
            {

            }

            try
            {
                //ClassCon.connect();
                //ClassCon.sqlconnection("select tb2.N,tb2.matricule,tb2.nom,tb2.Organisme,tb1.fournisseur,tb1.designation, tb2.Marque,tb2.Genre,tb2.TSVA,convert(varchar,tb1.DATE_s,23) as date_Sorte from fiche_signa tb1,TB_G tb2 where tb1.matricule=tb2.matricule ");
                //DataTable dtf = new DataTable();

                //dtf.Load(ClassCon.reader);
                //GridView1.DataSource = dtf;
                //GridView1.DataBind();
                //ClassCon.con.Close();

                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select distinct matricule from TB_G");
                    DataTable dss = new DataTable();
                    dss.Load(ClassCon.reader);
                    matricule.DataSource = dss;
                    matricule.DataTextField = "matricule";

                    matricule.DataBind();
                    ClassCon.con.Close();

                }
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
                ClassCon.sqlconnection("select * from fiche_signa where matricule='" + matricule.SelectedItem.Text + "'");
                ClassCon.dt.Rows.Clear();
                ClassCon.dt.Load(ClassCon.reader);
                GridView1.DataSource = ClassCon.dt;
                GridView1.DataBind();
                ClassCon.con.Close();
            }
            catch
            {

            }
    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("print_f_s.aspx?ID=" + matricule.SelectedItem.Text);
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClassCon.connect();
            ClassCon.sqlconnection("select tb2.N,tb2.matricule,tb2.nom,tb2.Organisme,tb1.fournisseur,tb1.designation, tb2.Marque,tb2.Genre,tb2.TSVA,convert(varchar,tb1.DATE_s,23) as date_Sorte from fiche_signa tb1,TB_G tb2 where tb1.matricule=tb2.matricule");
            ClassCon.dt.Rows.Clear();
            ClassCon.dt.Load(ClassCon.reader);
            GridView1.DataSource = ClassCon.dt;
            GridView1.DataBind();
            ClassCon.con.Close();
            velo.Enabled = false;
            matricule.Enabled = true;


        }

        protected void rdv_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select * from Marque_j");
                DataTable ds = new DataTable();
                ds.Load(ClassCon.reader);
                Marque.DataSource = ds;
                Marque.DataTextField = "name_marque";
                Marque.DataValueField = "id";
                Marque.DataBind();
                ClassCon.con.Close();

            }
            velo.Enabled = true;
            matricule.Enabled = false;
            ClassCon.connect();
            DataTable dtv  = new DataTable();
            ClassCon.sqlconnection("select tb2.N,tb2.Immatriculation,tb2.Nom_Prenom,tb2.Organisme,tb1.fournisseur,tb1.designation, tb2.Marque,tb2.Genre,tb2.TSVA,convert(varchar,tb1.DATE_s,23) as date_Sorte from fiche_signa tb1,VEHICULE tb2 where tb1.matricule=tb2.Immatriculation ");
            dtv.Rows.Clear();
            dtv.Load(ClassCon.reader);
            GridView1.DataSource = dtv;
            GridView1.DataBind();
            ClassCon.con.Close();
        }

        protected void TSVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ts = "";
                string req = "";
                if (matricule.Enabled==false)
                {
                    if (TSVA.SelectedItem.Text != "a tsva")
                    {
                        req = "select tb2.N,tb2.Immatriculation,tb2.Nom_Prenom,tb2.Organisme,tb1.fournisseur,tb1.designation, tb2.Marque,tb2.Genre,tb2.TSVA,convert(varchar,tb1.DATE_s,23) as date_Sorte from fiche_signa tb1,VEHICULE tb2 where tb1.matricule=tb2.Immatriculation and TSVA  is null";

                    }
                    else
                    {
                        req = "select tb2.N,tb2.Immatriculation,tb2.Nom_Prenom,tb2.Organisme,tb1.fournisseur,tb1.designation, tb2.Marque,tb2.Genre,tb2.TSVA,convert(varchar,tb1.DATE_s,23) as date_Sorte from fiche_signa tb1,VEHICULE tb2 where tb1.matricule=tb2.Immatriculation and TSVA  is not null";

                    }

                }
                 
                 
                    
                    Response.Write(req);
                    ClassCon.connect();
                    DataTable dtv = new DataTable();
                    ClassCon.sqlconnection(req);
                    dtv.Rows.Clear();
                    dtv.Load(ClassCon.reader);
                    GridView1.DataSource = dtv;
                    GridView1.DataBind();
                    ClassCon.con.Close();
                
            }
            catch
            {

            }

        }

    
    }
}