using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace ControlActivos
{
    public partial class Login : System.Web.UI.Page
    {
        login obj_login = new login();
        SqlConnection conexion = new SqlConnection();

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Pani;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_ingresar_Click(object sender, EventArgs e)
        {
            String clave = txt_pass.Text;
            int cedula = Convert.ToInt32(txt_cedula.Text);

            SqlCommand query = new SqlCommand("usp_busclogin", cn);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("@cedu", SqlDbType.Int).Value=cedula;
            query.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = clave ;
            SqlDataAdapter sda = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cn.Open();
            int i = query.ExecuteNonQuery();
            cn.Close();

            if (dt.Rows.Count > 0)
            {
                Session["cedu"] = cedula;
                Response.Redirect("Default.aspx");
                Session.RemoveAll();
            }
            else
            {
                Label1.Text = "Incorrecto";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    
    }
}