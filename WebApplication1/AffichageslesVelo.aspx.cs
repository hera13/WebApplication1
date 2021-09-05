using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
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
                    ClassCon.sqlconnection("select distinct Genre from VEHICULE");
                    DataTable ds22 = new DataTable();
                    ds22.Load(ClassCon.reader);
                    genre_M.DataSource = ds22;
                    genre_M.DataTextField = "Genre";
                   
                    genre_M.DataBind();
                    ClassCon.con.Close();

                }

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
                    ClassCon.sqlconnection("select N,Immatriculation from VEHICULE");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    Matricule.DataSource = ds;
                    Matricule.DataTextField = "Immatriculation";
                    Matricule.DataValueField = "N";
                    Matricule.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select distinct Organisme from VEHICULE ");
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
                    ClassCon.sqlconnection("select Immatriculation,convert(varchar,Date_mise_en_service,23) as date_mise_en_service, Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Dvision_Service,Nom_Prenom,TSVA,N  from VEHICULE");
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
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select Immatriculation,convert(varchar,Date_mise_en_service,23) as date_mise_en_service, Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Dvision_Service,Nom_Prenom,TSVA,N  from VEHICULE where Immatriculation  = '" + Matricule.SelectedItem.Text + "'");
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
                ClassCon.sqlconnection("select Immatriculation,convert(varchar,Date_mise_en_service,23) as date_mise_en_service, Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Dvision_Service,Nom_Prenom,TSVA,N  from VEHICULE where Organisme  = '" + Organisme.SelectedItem.Text + "'");
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

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select Immatriculation,convert(varchar,Date_mise_en_service,23) as date_mise_en_service, Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Dvision_Service,Nom_Prenom,TSVA,N  from VEHICULE ");
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

        protected void immat_TextChanged(object sender, EventArgs e)
        {

        }

        protected void date_TextChanged(object sender, EventArgs e)
        {

        }

        protected void marque_M_TextChanged(object sender, EventArgs e)
        {

        }

        protected void type_M_TextChanged(object sender, EventArgs e)
        {

        }

        protected void NDG_M_TextChanged(object sender, EventArgs e)
        {

        }

        protected void genre_M_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PF_M_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Carbulant_M_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Organisme_M_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void serv_M_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                ClassCon.connect();
                string req = "update VEHICULE set Date_mise_en_service='" + date.Text + "',Marque='" + marque_M.Text + "',Numéro_de_cadre='" + NDG_M.Text + "',Genre='" + genre_M.Text + "',Puissance_fiscale='" + PF_M.Text + "',Carburant='" + Carbulant_M.SelectedItem.Text + "',Organisme='" + Organisme_M.SelectedItem.Text + "',Dvision_Service='" + serv_M.SelectedItem.Text + "',TSVA='" + tsva_M.Text + "' where Immatriculation='" + immat.Text + "'";
                ClassCon.sqlconnection(req);
                ClassCon.con.Close();
                Response.Write("<script>alert('updated')</script>");
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("delete from VEHICULE where Immatriculation='" + immat.Text + "'");
                ClassCon.con.Close();
                Response.Write("<script>alert('deleted')</script>");
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

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                int r = e.NewSelectedIndex;
                immat.Text = GridView1.Rows[r].Cells[1].Text;
                date.Text = GridView1.Rows[r].Cells[2].Text;
                marque_M.Text = GridView1.Rows[r].Cells[3].Text;
                type_M.Text = GridView1.Rows[r].Cells[4].Text;
                NDG_M.Text = GridView1.Rows[r].Cells[5].Text;
                genre_M.SelectedItem.Text = GridView1.Rows[r].Cells[6].Text;
                PF_M.Text = GridView1.Rows[r].Cells[7].Text;
                Carbulant_M.SelectedItem.Text = GridView1.Rows[r].Cells[8].Text;
                Organisme_M.Text = GridView1.Rows[r].Cells[9].Text;
                if (GridView1.Rows[r].Cells[10].Text == "&nbsp;" )
                {
                    serv_M.SelectedItem.Text = "";
                }
                else
                {
                    serv_M.SelectedItem.Text = GridView1.Rows[r].Cells[10].Text;
                }
                if (GridView1.Rows[r].Cells[12].Text == "&nbsp;")
                {
                    tsva_M.Text = "";
                }
                else
                {
                    tsva_M.Text = GridView1.Rows[r].Cells[12].Text;
                }


              
            }
            catch
            {

            }
        }

        protected void Marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select Immatriculation,convert(varchar,Date_mise_en_service,23) as date_mise_en_service, Marque,Type,Numéro_de_cadre,Genre,Puissance_fiscale,Carburant,Organisme,Dvision_Service,Nom_Prenom,TSVA,N  from VEHICULE where Marque  = '" + Marque.SelectedItem.Text + "'");
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
    }
}