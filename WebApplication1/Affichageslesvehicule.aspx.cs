using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebApplication1
{
    public partial class Affichageslesvehicule1 : System.Web.UI.Page
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
                    ClassCon.sqlconnection("select * from Carburant");
                    DataTable dsc = new DataTable();
                    dsc.Load(ClassCon.reader);
                    Carbulant_M.DataSource = dsc;
                    Carbulant_M.DataTextField = "name_Carburant";
                    Carbulant_M.DataValueField = "id";
                    Carbulant_M.DataBind();
                    ClassCon.con.Close();

                }

                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select matricule,N from TB_G");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    Matricule.DataSource = ds;
                    Matricule.DataTextField = "matricule";
                    Matricule.DataValueField = "N";
                    Matricule.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select distinct Organisme from TB_G ");
                    DataTable ds1 = new DataTable();
                    ds1.Load(ClassCon.reader);
                    Organisme.DataSource = ds1;
                    Organisme.DataTextField = "Organisme";

                    Organisme.DataBind();
                    Organisme_M.DataSource = ds1;
                    Organisme_M.DataTextField = "Organisme";
                    Organisme_M.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from service");
                    DataTable dss = new DataTable();
                    dss.Load(ClassCon.reader);
                    serv_M.DataSource = dss;
                    serv_M.DataTextField = "name_service";
                    serv_M.DataValueField = "id_service";
                    serv_M.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G order by N");
                    DataTable ds2 = new DataTable();
                    ds2.Load(ClassCon.reader);
                    GridView1.DataSource = ds2;

                    GridView1.DataBind();
                    ClassCon.con.Close();

                }

            }
            catch
            {

            }
           
        }

        protected void Matricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Response.Redirect(Matricule.SelectedItem.Text);
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G where matricule  = '" + Matricule.SelectedItem.Text + "'");
                DataTable ds5 = new DataTable();
                ds5.Load(ClassCon.reader);
                GridView1.DataSource = ds5;
                GridView1.DataBind();
                ClassCon.con.Close();

            }
            catch
            {

            }
          
             
            


        }

        protected void Organisme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G where Organisme  = '" + Organisme.SelectedItem.Text + "'");
                DataTable ds6 = new DataTable();
                ds6.Load(ClassCon.reader);
                GridView1.DataSource = ds6;
                GridView1.DataBind();
                ClassCon.con.Close();
            }
            catch
            {

            }
       

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G where Marque='" + Marque.Value + "'");
                DataTable ds8 = new DataTable();
                ds8.Load(ClassCon.reader);
                GridView1.DataSource = ds8;
                GridView1.DataBind();
                ClassCon.con.Close();
            }
            catch
            {

            }
     
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();

                ClassCon.sqlconnection("select N,Matricule,Nom,convert(varchar,Date_mise_en_service, 23) as Date_Mise_En_Service   ,Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Service,TSVA from TB_G");
                DataTable ds9 = new DataTable();
                ds9.Clear();
                ds9.Load(ClassCon.reader);
                GridView1.DataSource = ds9;
                GridView1.DataBind();
                ClassCon.con.Close();
            }
            catch
            {

            }
            
           

       
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                int r = e.NewSelectedIndex;
                immat.Text = GridView1.Rows[r].Cells[2].Text;
                date.Text = GridView1.Rows[r].Cells[4].Text;
                marque_M.Text = GridView1.Rows[r].Cells[5].Text;
                type_M.Text = GridView1.Rows[r].Cells[6].Text;
                NDG_M.Text = GridView1.Rows[r].Cells[7].Text;
                genre_M.Text = GridView1.Rows[r].Cells[8].Text;
                PF_M.Text = GridView1.Rows[r].Cells[9].Text;
                Carbulant_M.SelectedItem.Text = GridView1.Rows[r].Cells[10].Text;
                Organisme_M.Text = GridView1.Rows[r].Cells[11].Text;
                serv_M.SelectedItem.Text = GridView1.Rows[r].Cells[12].Text;
                tsva_M.Text = GridView1.Rows[r].Cells[13].Text;
            }
            catch
            {

            }
       
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("delete from TB_G where Matricule='" + immat.Text + "'");
                ClassCon.con.Close();
            }
            catch
            {

            }
        
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            immat.Text = "";
          
            marque_M.Text = "";
            type_M.Text = "";
            NDG_M.Text = "";
            genre_M.Text = "";
            PF_M.Text = "";
            tsva_M.Text = "";



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                string req = "update TB_G set Date_mise_en_service='" + date.Text + "',Marque='" + marque_M.Text + "',Numéro_de_cadre='" + NDG_M.Text + "',Genre='" + genre_M.Text + "',Puissance_fiscale='" + PF_M.Text + "',Carburant='" + Carbulant_M.SelectedItem.Text + "',Organisme='" + Organisme_M.SelectedItem.Text + "',Service='" + serv_M.SelectedItem.Text + "',TSVA='" + tsva_M.Text + "' where matricule='" + immat.Text + "'";
                ClassCon.sqlconnection(req);
                ClassCon.con.Close();
            }
            catch
            {

            }
        
        }
    }
}