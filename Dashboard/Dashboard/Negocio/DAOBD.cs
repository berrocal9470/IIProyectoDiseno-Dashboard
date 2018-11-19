using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class DAOBD : IConsultable
    {
        private SqlConnection conexionSQL;

        public DAOBD()
        {
            conexionSQL = new SqlConnection(System.Configuration.ConfigurationManager
                                    .ConnectionStrings["Dashboard.Properties.Settings.Proyecto2DisennoConnectionString"]
                                    .ConnectionString);
        }


        public List<IResultado> consultar(object obj)
        {
            return null;
        }

        public List<IResultado> consultarTabla(string nombreTabla)
        {
            List<ResultadoTablas> resultado = new List<ResultadoTablas>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conexionSQL;
            cmd.CommandText = "SELECT * FROM "+nombreTabla+" ;";

            try
            {
                conexionSQL.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ResultadoTablas tabla = new ResultadoTablas();
                    tabla.Codigo = reader[0].ToString();
                    tabla.Nombre = reader[1].ToString();

                    resultado.Add(tabla);
                }
                conexionSQL.Close();
                return resultado.Cast<IResultado>().ToList();
            }
            catch(SqlException e)
            {

                return null;
            }
        }

        public List<IResultado> consultaObserver()
        {
            List<ResultadoObserver> resultado = new List<ResultadoObserver>();

            using (SqlCommand cmd = new SqlCommand("consultaLibre", conexionSQL))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    conexionSQL.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ResultadoObserver tabla = new ResultadoObserver();
                        tabla.Sexo = reader[0].ToString();
                        tabla.EdadQuinquenal = reader[1].ToString();

                        resultado.Add(tabla);
                    }
                    conexionSQL.Close();

                    return resultado.Cast<IResultado>().ToList();
                }
                catch (SqlException e)
                {
                    return null;
                }
            }
        }
    }
}
