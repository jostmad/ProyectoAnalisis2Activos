using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ActivosMant
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=Pani;Integrated Security=True");
        Mantenimientos obj = new Mantenimientos();

        #region propiedades

        private int _codigo;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _modelo;

        public string modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        private string _marca;

        public string marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private string _so;

        public string so
        {
            get { return _so; }
            set { _so = value; }
        }

        private string _region;

        public string region
        {
            get { return _region; }
            set { _region = value; }
        }

        private string _oficina;

        public string oficina
        {
            get { return _oficina; }
            set { _oficina = value; }
        }

        private string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private int _codAct;

        public int codAct
        {
            get { return _codAct; }
            set { _codAct = value; }
        }

        private string _imagen;

        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        private string _respuesta;

        public string respuesta
        {
            get { return _respuesta; }
            set { _respuesta = value; }
        }

        #endregion

        #region variables privadas

        SqlConnection conexion;
        string sql = string.Empty;
        int numero_error = 0;
        string mensaje_error = string.Empty;

        #endregion

        #region metodos

        public string insertarActivos(string resp)
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
                cmd.Parameters["@id_activos"].Value = _codigo;
                cmd.Parameters["@modelo"].Value = _modelo;
                cmd.Parameters["@marca"].Value = _marca;
                cmd.Parameters["@so"].Value = _so;
                cmd.Parameters["@region"].Value = _region;
                cmd.Parameters["@oficina"].Value = _oficina;
                cmd.Parameters["@usuario"].Value = _usuario;
                cmd.Parameters["@id_tipoact"].Value = _codAct;
                cmd.Parameters["@imagen"].Value = _imagen;
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
                resp = "El activo se ingresó correctamente";
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
