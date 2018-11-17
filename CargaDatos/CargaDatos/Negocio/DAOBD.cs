using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CargaDatos.Negocio
{
    class DAOBD
    {
        SqlConnection conexionSQL;
        string completeQuery;

        public DAOBD()
        {
            conexionSQL = new SqlConnection(System.Configuration.ConfigurationManager
                                    .ConnectionStrings["CargaDatos.Properties.Settings.Proyecto2DisennoConnectionString"]
                                    .ConnectionString);
            completeQuery = "";
        }

        public void abrirConexion()
        {
            conexionSQL.Open();
        }

        public void cerrarConexion()
        {
            conexionSQL.Close();
        }

        public void Agregar(string tabla, string datos)
        {
            completeQuery += "INSERT " + tabla + " VALUES (" + datos + "); ";
        }

        public bool ejecutarTodo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "INSERT " + tabla + " VALUES (" + datos + ")";
            cmd.CommandText = completeQuery;
            cmd.Connection = conexionSQL;

            try
            {
                //conexionSQL.Open();
                cmd.ExecuteNonQuery();  //ejecuta la peticion
                //conexionSQL.Close();
            }
            catch (SqlException e)
            {
                //Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                //siempre limpia el query
                completeQuery = "";
            }

            return true;
        }
    }
}
