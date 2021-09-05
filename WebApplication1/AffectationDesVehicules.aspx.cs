using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
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
                    ClassCon.sqlconnection("select * from service");
                    DataTable ds = new DataTable();
                    ds.Load(ClassCon.reader);
                    DropDownList1.DataSource = ds;
                    DropDownList1.DataTextField = "name_service";
                    DropDownList1.DataValueField = "id_service";
                    DropDownList1.DataBind();
                    ClassCon.con.Close();

                }


            }
            catch
            {

            }
           



        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string req = "insert into TB_G values('" + Immatriculation.Value + "','" + date.Text + "','" + Marque.Value + "','" + Type.Value + "'," + Numero_de_cadre.Value + ",'" + Genre.Value + "'," + Puissance.Value + ",'" + Caburant.SelectedItem.Text + "','" + Organisme.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + "','" + name.Value + "','" + TSVA.Value + "')";

                ClassCon.connect();

                ClassCon.sqlconnection(req);
                Response.Write("<script>alert('Add')</script>");
                ClassCon.con.Close();
            }
            catch
            {

            }
           
     
        }
    }
}