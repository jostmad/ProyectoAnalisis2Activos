using System;
  using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 using System.Data;
 using System.Data.SqlClient;
 
 namespace BLL
 {
     public class login
     {
         SqlConnection conexion = new SqlConnection();
 
         SqlConnection cn = new SqlConnection("Data Source=HAPPY\\SQL2016;Initial Catalog=Pani;Integrated Security=True");
 
 
         #region propiedades
         private int _cedu;
 
         public int cedu
         {
             get { return _cedu; }
             set { _cedu = value; }
         }
         private string _pass;
 
         public string pass
         {
             get { return _pass; }
             set { _pass = value; }
         }
 
         #endregion
         #region metodos
         public void verifica()
         {
 /*
             SqlCommand query = new SqlCommand("usp_busclogin", cn);
             query.Parameters.AddWithValue("@cedu", _cedu );
             query.Parameters.AddWithValue("@pass", _pass );
             SqlDataAdapter sda = new SqlDataAdapter(query);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             cn.Open();
             int i = query.ExecuteNonQuery();
             cn.Close();
             if (dt.Rows.Count > 0)
             {
                 Session["id"] = cedula;
                 Response.Redirect("Default.aspx");
                 Session.RemoveAll();
             }
             else
             {
                 Label1.Text = "You're username and word is incorrect";
                 Label1.ForeColor = System.Drawing.Color.Red;
 
             }
             */
 
         }
         #endregion
 
 
     }
 }