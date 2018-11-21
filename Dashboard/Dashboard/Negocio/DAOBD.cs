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
                                    .ConnectionStrings["Dashboard.Properties.Settings.Proyecto2DisennoConnectionString1"]
                                    .ConnectionString);
        }


        public List<IResultado> consultar(object obj)
        {
            if(obj is string)
            {
                string selectStatement = (string)obj;
                List<ResultadoTablas> resultado = new List<ResultadoTablas>();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conexionSQL;
                cmd.CommandText = selectStatement;

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
                catch (SqlException e)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        //se usa para apoyar el método de la consulta dinámica, retorna los count de cada query
        public int consultarCantidad(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conexionSQL;
            cmd.CommandText = query;

            try
            {
                conexionSQL.Open();
                int cantidad = -1;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();      //lee solo la primera línea
                    cantidad = rd.GetInt32(0);
                }
                conexionSQL.Close();

                return cantidad;
            }
            catch (SqlException e)
            {
                return -1;
            }
        }

        public IResultado consultarCoordenadas(string idProvincia, string idCanton, string idDistrito)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conexionSQL;
            cmd.CommandText = "select latitud, longitud from distritos d where " +
                "d.id_provincia = '"+ idProvincia +"' and d.id_canton = '"+ idCanton +"' and d.id_distrito = '"+ idDistrito +"'";

            try
            {
                conexionSQL.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();      //Lee solo la primera línea

                ResultadoConsultaDinamica resultado = new ResultadoConsultaDinamica();
                resultado.Latitud = Convert.ToDouble(reader[0].ToString());
                resultado.Longitud = Convert.ToDouble(reader[1].ToString());

                conexionSQL.Close();

                return resultado;
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public List<IResultado> consultarTabla(string nombreTabla)
        {
            string selectStatement = "SELECT * FROM " + nombreTabla + " ;";
            return consultar(selectStatement);
        }

        public List<IResultado> consultarCantones(string idProvincia)
        {
            string selectStatement = "SELECT id_canton, nombre FROM cantones where id_provincia = " + idProvincia + " ;";
            return consultar(selectStatement);
        }

        public List<IResultado> consultarDistritos(string idProvincia, string idCanton)
        {
            string selectStatement = "SELECT id_distrito, nombre FROM distritos " +
                "where id_provincia = " + idProvincia + " and id_canton = " + idCanton + ";";
            return consultar(selectStatement);
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
                        tabla.Edad = Int32.Parse(reader[1].ToString());

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
