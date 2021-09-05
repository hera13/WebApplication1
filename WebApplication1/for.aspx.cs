using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _for : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                ClassCon.sqlconnection("update admin set nom ='" + username.Value + "' , mot_passe ='" + passowrd.Value + "' where CIN='" + cin.Value + "'  ");
                Response.Redirect("Login.aspx");
                ClassCon.con.Close();
                Response.Write("<script>alert('Updated')</script>");
            }
            catch
            {

            }
          
        }
    }
}