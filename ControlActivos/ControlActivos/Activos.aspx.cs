using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.SqlClient;
using System.Data;

namespace ControlActivos
{
    public partial class Activos : Page
    {
        SqlConnection cn = new SqlConnection("Data Source=HAPPY\\SQL2016;Initial Catalog=Pani;Integrated Security=True");
        Mantenimientos obj = new Mantenimientos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_agregar_Click(object sender, EventArgs e)
        {
            bool respuesta = false;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_insertaractivos", cn);
                //especificamos que el comando es un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                //creamos los parametros que usaremos
                cmd.Parameters.Add("@id_activos", SqlDbType.Int);
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar);
                cmd.Parameters.Add("@marca", SqlDbType.VarChar);
                cmd.Parameters.Add("@so", SqlDbType.VarChar);
                cmd.Parameters.Add("@region", SqlDbType.VarChar);
                cmd.Parameters.Add("@oficina", SqlDbType.VarChar);
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cmd.Parameters.Add("@id_tipoact", SqlDbType.Int);
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar);
                //asignamos el valor de los textbox a los parametros
                cmd.Parameters["@id_activos"].Value = Convert.ToInt32(txt_codigo.Text).ToString();
                cmd.Parameters["@modelo"].Value = txt_modelo.Text;
                cmd.Parameters["@marca"].Value = txt_marca.Text;
                cmd.Parameters["@so"].Value = txt_so.Text;
                cmd.Parameters["@region"].Value = txt_region.Text;
                cmd.Parameters["@oficina"].Value = txt_oficina.Text;
                cmd.Parameters["@usuario"].Value = txt_usuario.Text;
                cmd.Parameters["@id_tipoact"].Value = Convert.ToInt32(txt_tipoactivo.Text).ToString();
                cmd.Parameters["@imagen"].Value = txt_garantia.Text;
                //abrimos conexion
                cn.Open();
                //ejecutamos la instruccion con ExcecuteNonQuerry indicando que no retorna registros.


                if (cmd.ExecuteNonQuery() == 1)
                {
                    respuesta = true;
                    
                }
                else
                {
                    respuesta = false;
                }
                Label1.Text = "El activo se ingresó correctamente";
            }
            catch (Exception ex)
            {
                respuesta = false;
                Label1.Text = "Mensaje de la excepción: " + ex.Message.ToString();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}