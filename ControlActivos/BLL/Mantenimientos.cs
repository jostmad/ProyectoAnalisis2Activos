using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Mantenimientos
    {
        SqlConnection conexion = new SqlConnection();

        string motrarError;
        public string MotrarError
        {
            get { return motrarError; }
            set { motrarError = value; }
        }

        private bool ConectarServer()
        {
            bool respuesta = false;
            string cadenaConexion = @"Data Source=.;Initial Catalog=Pani;Integrated Security=True";
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                respuesta = true;

            }
            catch (Exception ex)
            {
                respuesta = false;
                MotrarError = "No se ha podido conectar con el servidor. Mensaje de la exepción: " + ex.Message.ToString();
            }
            return respuesta;
        }

        public bool Registrar(string tabla, string campos, string valores)
        {
            bool respuesta = false;

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;

                comando.CommandText = "INSERT INTO " + tabla + "(" + campos + ") VALUES(" + valores + ");";
                if (ConectarServer())
                {
                    if (comando.ExecuteNonQuery() == 1)
                        respuesta = true;
                    else
                        respuesta = false;
                }
                else
                {
                    respuesta = false;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                MotrarError = "Mensaje de la excepción: " + ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

            return respuesta;
        }

        public bool Modificar(string tabla, string campos, string condicion)
        {
            bool respuesta = false;

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;

                comando.CommandText = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion + ";";
                if (ConectarServer())
                {
                    if (comando.ExecuteNonQuery() == 1)
                        respuesta = true;
                    else
                        respuesta = false;
                }
                else
                {
                    respuesta = false;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                MotrarError = "Mensaje de la excepción: " + ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

            return respuesta;
        }

        public bool Eliminar(string tabla, string condicion)
        {
            bool respuesta = false;

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;

                comando.CommandText = "DELETE FROM " + tabla + " WHERE " + condicion + ";";
                if (ConectarServer())
                {
                    if (comando.ExecuteNonQuery() == 1)
                        respuesta = true;
                    else
                        respuesta = false;
                }
                else
                {
                    respuesta = false;
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                MotrarError = "Mensaje de la excepción: " + ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }

            return respuesta;
        }

        public DataSet MostrarRegistros(string tabla)
        {
            DataSet respuesta = new DataSet();
            try
            {

                string instruccionSQL = "SELECT * FROM " + tabla + ";";
                SqlDataAdapter adaptador = new SqlDataAdapter(instruccionSQL, conexion);
                if (ConectarServer())
                {
                    adaptador.Fill(respuesta, tabla);
                }
            }
            catch (Exception ex)
            {
                MotrarError = "Mensaje de la exepción: " + ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }


        

    }
}