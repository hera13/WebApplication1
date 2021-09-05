using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public class ClassCon
    {
        static public SqlConnection con = new SqlConnection();
        static public SqlCommand cmd = new SqlCommand();
        static public SqlDataReader reader;
        static public DataTable dt = new DataTable();


        static  public void connect()
        {
         
            con = new SqlConnection(@"Data Source=DESKTOP-OR5V012;Initial Catalog=s;Integrated Security=True");
           // con  =new SqlConnection(@"Data Source = SQL5061.site4now.net; Initial Catalog = db_a7950b_dbparking; User Id = db_a7950b_dbparking_admin; Password = Mohamedsire99@");
            //con = new SqlConnection(@"Data Source=DESKTOP-OR5V012;Initial Catalog=ss.bacpac;Integrated Security=True");
            con.Open();
        }

        static public void sqlconnection(string req)
        {
            string q = req.Substring(0, 6);
            cmd.CommandText = req;
            cmd.Connection = con;
            if (q.ToLower() != "select")
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                reader = cmd.ExecuteReader();
            }
        }
    }
}