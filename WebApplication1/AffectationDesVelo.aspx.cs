using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    ClassCon.dt.Clear();
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from Organisme");
                    ClassCon.dt.Load(ClassCon.reader);
                    Organisme.DataSource = ClassCon.dt;
                    Organisme.DataTextField = "name_Organisme";
                    Organisme.DataValueField = "id";
                    Organisme.DataBind();
                    ClassCon.con.Close();
                }


                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from Carburant");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    Caburant.DataSource = ds;
                    Caburant.DataTextField = "name_Carburant";
                    Caburant.DataValueField = "id";
                    Caburant.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from type_j");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    type.DataSource = ds;
                    type.DataTextField = "name_type";
                    type.DataValueField = "id";
                    type.DataBind();
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
                    ClassCon.sqlconnection("select * from genere_J");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    Genre.DataSource = ds;
                    Genre.DataTextField = "name_genere";
                    Genre.DataValueField = "id";
                    Genre.DataBind();
                    ClassCon.con.Close();

                }
                if (!IsPostBack)
                {
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from service");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    Service.DataSource = ds;
                    Service.DataTextField = "name_service";
                    Service.DataValueField = "id_service";
                    Service.DataBind();
                    ClassCon.con.Close();

                }


            }
            catch
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassCon.connect();
            string req = "insert into VEHICULE values('" + Immatriculation.Value + "','" + date.Text + "','"+Marque.Text+"','" + type.SelectedItem.Text + "','" + Numero_de_cadre.Value + "','" + Genre.SelectedItem.Text + "','" + puissance.Text + "','" + Caburant.SelectedItem.Text + "','" + Organisme.SelectedItem.Text + "','" + Service.SelectedItem.Text + "','" + Compte.Value + "','" + TSVA.Value + "')";
            ClassCon.sqlconnection(req);
            ClassCon.con.Close();
            Response.Write("<script>alert('Add')</script>");
        }
    }
}