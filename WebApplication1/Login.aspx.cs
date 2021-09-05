using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("select * from admin where nom ='" + fff.Value + "' and mot_passe='" + lok.Value + "'");
                if (ClassCon.reader.HasRows)
                {
                    Session["uuser"] = "admin";
                    Response.Redirect("AffectationDesVehicules.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Password Or Email inncorrect')</script>");
                }
                ClassCon.con.Close();
            }
            catch
            {

            }
         
        }
    }
}