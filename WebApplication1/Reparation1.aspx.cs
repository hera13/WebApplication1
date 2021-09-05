using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebApplication1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["count"] == null)
            {
                Session["count"] = 0;
            }
            if (Session["nn"] == null)
            {
                Session["nn"] = "";
            }
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
                    ClassCon.sqlconnection("select N,Immatriculation from VEHICULE");
                    DataTable dt = new DataTable();
                    dt.Load(ClassCon.reader);
                    ClassCon.dt.Load(ClassCon.reader);
                    DropDownList3.DataSource = dt;
                    DropDownList3.DataTextField = "Immatriculation";
                    DropDownList3.DataValueField = "N";
                    DropDownList3.DataBind();
                    DropDownList2.DataSource = dt;
                    DropDownList2.DataTextField = "Immatriculation";
                    DropDownList2.DataValueField = "N";
                    DropDownList2.DataBind();
                    ClassCon.con.Close();
                }
                if (!IsPostBack)
                {
                    ClassCon.dt.Clear();
                    ClassCon.connect();
                    ClassCon.sqlconnection("select * from fournisseur");
                    DataTable dt4 = new DataTable();
                    dt4.Load(ClassCon.reader);
                    ClassCon.dt.Load(ClassCon.reader);
                    DropDownList4.DataSource = dt4;
                    DropDownList4.DataTextField = "name_fournisseur";
                    DropDownList4.DataValueField = "id";
                    DropDownList4.DataBind();
                    ClassCon.con.Close();
                }
                if (!IsPostBack)
                {
                    ClassCon.dt.Clear();
                    ClassCon.connect();
                    ClassCon.sqlconnection("select N,Article  from PV");
                    ClassCon.dt.Load(ClassCon.reader);
                    DropDownList1.DataSource = ClassCon.dt;
                    DropDownList1.DataTextField = "Article";
                    DropDownList1.DataValueField = "N";
                    DropDownList1.DataBind();
                    ClassCon.con.Close();
                }
                if (!IsPostBack)
                {

                    ClassCon.connect();
                    string req = "select Immatriculation,kilometrage,convert(varchar,date_entree,23) as date_entree,designation,fournisseur from test2";

                    ClassCon.sqlconnection(req);
                    DataTable dtG = new DataTable();
                    dtG.Clear();
                    dtG.Load(ClassCon.reader);
                    GridView1.DataSource = dtG;
                    GridView1.DataBind();
                    ClassCon.con.Close();
                }
                if (!IsPostBack)
                {

                    ClassCon.connect();
                    string req = "SELECT * FROM print_services";
                    ClassCon.sqlconnection(req);
                    DataTable dt5 = new DataTable();
                    dt5.Clear();
                    dt5.Load(ClassCon.reader);
                    DropDownList5.DataSource = dt5;
                    DropDownList5.DataTextField = "name_services";
                    DropDownList5.DataValueField = "id_print_services";
                    DropDownList5.DataBind();
                    ClassCon.con.Close();
                }
            }
            catch
            {

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Session["count"]
            string s = "";
            foreach (var item in ListBox1.Items)
            {
                s = s + item + ",";
            }
            ClassCon.connect();
            ClassCon.sqlconnection("insert into test2 values('" + DropDownList3.SelectedItem.Text + "','" + Kilomitrage.Text + "','" + DropDownList4.SelectedItem.Text + "','" + date_entree.Text + "','" + s + "','" + Session["count"] + "','" + Session["nn"].ToString() + "')");
            ClassCon.con.Close();
            TextBox2.Text = s;

            //try
            //{
            //    ClassCon.connect();
            //    ClassCon.sqlconnection("select * from test1 where matricule='" + DropDownList2.SelectedItem.Text + "' and designation='" + DropDownList1.SelectedItem.Text + "'");
            //    DataTable dt1 = new DataTable();
            //    dt1.Load(ClassCon.reader);
            //    ClassCon.con.Close();
            //    if (dt1.Rows.Count > 0)
            //    {
            //        ClassCon.connect();
            //        //ClassCon.sqlconnection("  update test1 SET Numbers += '" + Convert.ToInt32(TextBox1.Text) + "' where matricule = '" + DropDownList2.SelectedItem.Text + "' and designation='" + DropDownList1.SelectedItem.Text + "'");
            //        ClassCon.con.Close();

            //    }
            //    else
            //    {
            //        ClassCon.connect();
            //   //     ClassCon.sqlconnection("insert into test1 values('" + DropDownList3.SelectedItem.Text + "','" + Kilomitrage.Text + "','" + DropDownList4.SelectedItem.Text + "','" + date_entree.Text + "','" + DropDownList1.SelectedItem.Text + "','" + TextBox1.Text + "')");
            //        ClassCon.con.Close();




            //    }
            //    Response.Write("<script>alert('Add')</script>");
            //}
            //catch
            //{

            //}









        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                int r = e.NewSelectedIndex;
                DropDownList3.SelectedItem.Text = GridView1.Rows[r].Cells[1].Text;
                Kilomitrage.Text = GridView1.Rows[r].Cells[2].Text;
           
                DropDownList4.SelectedItem.Text = GridView1.Rows[r].Cells[5].Text;
                // TextBox1.Text = GridView1.Rows[r].Cells[7].Text;
                DropDownList2.SelectedItem.Text = GridView1.Rows[r].Cells[1].Text;
                // date_entree.Text = GridView1.Rows[r].Cells[5].Text;
                //date_entree.Text = "01-02-2010";
                date_entree.Text = DateTime.Now.ToString(GridView1.Rows[r].Cells[3].Text);
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
                string req = "delete  from test2 where Immatriculation='" + DropDownList3.SelectedItem + "'";
                ClassCon.sqlconnection(req);
                ClassCon.con.Close();
                Response.Write("<script>alert('Supprimé')</script>");
            }
            catch
            {

            }






        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {



        }

        protected void Button7_Click1(object sender, EventArgs e)
        {
            try
            {
                if (DropDownList5.SelectedItem.Text == "LE PRESIDENT DE LA COMMUNE DE RABAT")
                {
                    Response.Redirect("LPDLC.aspx?ID=" + DropDownList2.SelectedItem.Text);



                }
                else if (DropDownList5.SelectedItem.Text == "ORDRE SERVICE")
                {
                    Response.Redirect("Order_Service.aspx?ID=" + DropDownList2.SelectedItem.Text);

                }
                else if (DropDownList5.SelectedItem.Text == "COMPTE RENDU PROVISOIRE DE RECEPTION")
                {
                    Response.Redirect("CRPDR.aspx?ID=" + DropDownList2.SelectedItem.Text);


                }
                else if (DropDownList5.SelectedItem.Text == "COMPT RENDU DE DIAGNOSTIQUE TECHNIQUE")
                {

                    Response.Redirect("WebForm1.aspx?ID=" + DropDownList2.SelectedItem.Text);
                }
            }
            catch
            {

            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ClassCon.connect();
            //    string req = "insert into fiche_signa select matricule,kilometrage,fournisseur,date_entree,designation,Numbers, '" + date_S.Text + "',nn from test1 where matricule='" + DropDownList3.SelectedItem.Text + "'";
            //    ClassCon.sqlconnection(req);
            //    ClassCon.con.Close();
            //    ClassCon.connect();
            //    string req1 = "delete  from test1 where matricule='" + DropDownList3.SelectedItem.Text + "'";
            //    ClassCon.sqlconnection(req1);
            //}
            //catch
            //{

            //}


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCon.connect();
                // string req = "update test1 set kilometrage='" + Kilomitrage.Text + "',designation='" + DropDownList1.SelectedItem.Text + "',Numbers='" + TextBox1.Text + "',fournisseur='" + DropDownList4.SelectedItem.Text + "'";
                //ClassCon.sqlconnection(req);
                Response.Write("<script>alert('Modifer')</script>");
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
                string req = "select * from test1 where matricule='" + DropDownList3.SelectedItem.Text + "'";

                ClassCon.sqlconnection(req);
                DataTable dtG = new DataTable();
                dtG.Clear();
                dtG.Load(ClassCon.reader);
                GridView1.DataSource = dtG;
                GridView1.DataBind();
                ClassCon.con.Close();
            }
            catch
            {

            }

        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            Session["count"] = null;
            //TextBox1.Text = "";
            TextBox2.Text = "";
            ListBox1.Items.Clear();
            Kilomitrage.Text = "";


        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            int count1 = Convert.ToInt32(TextBox2.Text);
            Session["count"] = (int)Session["count"] + count1;
            Session["nn"] = Session["nn"].ToString() + TextBox2.Text + ".";
            ListBox1.Items.Add(DropDownList1.SelectedItem.Text);
            Label1.Text = Session["count"].ToString();

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            
                ClassCon.connect();
                string req = "insert into fiche_signa select Immatriculation,kilometrage,fournisseur,date_entree,designation,Numbers, '" + date_S.Text + "',nn from test2 where Immatriculation='" + DropDownList3.SelectedItem.Text + "'";
                ClassCon.sqlconnection(req);
                ClassCon.con.Close();
                ClassCon.connect();
                string req1 = "delete  from test2 where Immatriculation='" + DropDownList3.SelectedItem.Text + "'";
                ClassCon.sqlconnection(req1);
         


        }
    
}
}