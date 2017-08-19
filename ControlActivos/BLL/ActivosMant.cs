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
        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=Pani;Integrated Security=True");
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

        private DateTime _fechaven;

        public DateTime fechaven
        {
            get { return _fechaven; }
            set { _fechaven = value; }
        }

        private string _imagen;

        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        private DateTime _fecha;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private string _estado;

        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private int _garantia;

        public int garantia
        {
            get { return _garantia; }
            set { _garantia = value; }
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
                cmd.Parameters.Add("@codigo_activos", SqlDbType.Int);
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar);
                cmd.Parameters.Add("@marca", SqlDbType.VarChar);
                cmd.Parameters.Add("@so", SqlDbType.VarChar);
                cmd.Parameters.Add("@region", SqlDbType.VarChar);
                cmd.Parameters.Add("@garantia", SqlDbType.Int);
                cmd.Parameters.Add("@oficina", SqlDbType.VarChar);
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cmd.Parameters.Add("@fecha_compra", SqlDbType.Date);
                cmd.Parameters.Add("@fecha_vencerse", SqlDbType.Date);
                cmd.Parameters.Add("@estado", SqlDbType.VarChar);
                //asignamos el valor de los textbox a los parametros
                cmd.Parameters["@codigo_activos"].Value = _codigo;
                cmd.Parameters["@modelo"].Value = _modelo;
                cmd.Parameters["@marca"].Value = _marca;
                cmd.Parameters["@so"].Value = _so;
                cmd.Parameters["@region"].Value = _region;
                cmd.Parameters["@oficina"].Value = _oficina;
                cmd.Parameters["@usuario"].Value = _usuario;
                cmd.Parameters["@fecha_compra"].Value = _fecha;
                cmd.Parameters["@fecha_vencerse"].Value = _fechaven;
                cmd.Parameters["@garantia"].Value = _garantia;
                cmd.Parameters["@estado"].Value = _estado;
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

        public string modificarActivos(string resp)
        {

            bool respuesta = false;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_actualizactivos", cn);
                //especificamos que el comando es un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                //creamos los parametros que usaremos
                cmd.Parameters.Add("@codigo_activo", SqlDbType.Int);
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar);
                cmd.Parameters.Add("@marca", SqlDbType.VarChar);
                cmd.Parameters.Add("@so", SqlDbType.VarChar);
                cmd.Parameters.Add("@region", SqlDbType.VarChar);
                cmd.Parameters.Add("@garantia", SqlDbType.Int);
                cmd.Parameters.Add("@oficina", SqlDbType.VarChar);
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
                cmd.Parameters.Add("@fecha_compra", SqlDbType.Date);
                cmd.Parameters.Add("@fecha_vencerse", SqlDbType.Date);
                //asignamos el valor de los textbox a los parametros
                cmd.Parameters["@codigo_activo"].Value = _codigo;
                cmd.Parameters["@modelo"].Value = _modelo;
                cmd.Parameters["@marca"].Value = _marca;
                cmd.Parameters["@so"].Value = _so;
                cmd.Parameters["@region"].Value = _region;
                cmd.Parameters["@oficina"].Value = _oficina;
                cmd.Parameters["@usuario"].Value = _usuario;
                cmd.Parameters["@fecha_compra"].Value = _fecha;
                cmd.Parameters["@fecha_vencerse"].Value = _fechaven;
                cmd.Parameters["@garantia"].Value = _garantia;
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
