using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
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
                    ClassCon.sqlconnection("select * from Pieces");
                    ClassCon.dt.Load(ClassCon.reader);
                    DropDownList1.DataSource = ClassCon.dt;
                    DropDownList1.DataTextField = "Article";
                    DropDownList1.DataValueField = "ID_PIECES";
                    DropDownList1.DataBind();
                    ClassCon.con.Close();
                }
                if (!IsPostBack)
                {
                    ClassCon.dt.Clear();
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from fournisseur");
                    DataTable dt = new DataTable();
                    dt.Load(ClassCon.reader);
                    DropDownList2.DataSource = dt;
                    DropDownList2.DataTextField = "name_fournisseur";
                    DropDownList2.DataValueField = "id";
                    DropDownList2.DataBind();
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
                ClassCon.sqlconnection("insert into PIECES values('" + piece.Value + "')");
                Response.Write("<script>alert('Add')</script>");
                Response.Redirect(Request.RawUrl);
            }
            catch
            {

            }
  
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("delete from PIECES where ID_PIECES='" + DropDownList1.SelectedValue + "'");
                Response.Write("<script>alert('Supprimer')</script>");
                ClassCon.con.Close();
                Response.Redirect(Request.RawUrl);
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
                ClassCon.sqlconnection("delete from fournisseur where id='" + DropDownList2.SelectedValue + "'");
                Response.Write("<script>alert('Add')</script>");
                ClassCon.con.Close();
                Response.Redirect(Request.RawUrl);
             
            }
            catch
            {

            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("insert into fournisseur values('" + Text2.Value + "')");
                Response.Write("<script>alert('Add')</script>");
                Response.Redirect(Request.RawUrl);
               
            }
            catch
            {

            }
           
           
        }
    }
}