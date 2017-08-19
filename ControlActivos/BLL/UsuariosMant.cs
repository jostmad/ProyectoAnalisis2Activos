using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuariosMant
    {

        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=Pani;Integrated Security=True");
        Mantenimientos obj = new Mantenimientos();


        #region propiedades

        private int _codigo;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _contra;

        public string contra
        {
            get { return _contra; }
            set { _contra = value; }
        }

        private int _tipUsua;

        public int tipUsua
        {
            get { return _tipUsua; }
            set { _tipUsua = value; }
        }

        #endregion

        #region variables privadas

        SqlConnection conexion;
        string sql = string.Empty;
        int numero_error = 0;
        string mensaje_error = string.Empty;

        #endregion

        #region metodos

        public string actualizarActivos(string resp)
        {

            bool respuesta = false;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_actualizaractivos", cn);
                //especificamos que el comando es un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                //creamos los parametros que usaremos
                
                cmd.Parameters.Add("@cedula", SqlDbType.Int);
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@tipo_rol", SqlDbType.Int);
                //asignamos el valor de los textbox a los parametros
                cmd.Parameters["@cedula"].Value = _codigo;
                cmd.Parameters["@nombre"].Value = _nombre;
                cmd.Parameters["@password"].Value = _contra;
                cmd.Parameters["@tipo_rol"].Value = _tipUsua;
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
                resp = "El usuario se modificó correctamente";
            }
            catch (Exception ex)
            {
                respuesta = false;
                resp = "Mensaje de la excepción: " + ex.Message.ToString();
            }
            finally
            {
                cn.Close();
            }
            return resp;
        }




        #endregion
    }
}
