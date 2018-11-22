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



        public List<IResultado> consultarEdadQ(object obj)
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
                    tabla.Codigo = 0;
                    tabla.Nombre = reader[0].ToString();

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
            if (nombreTabla.Equals("Quinquenal"))
            {
                string selectStatement = "select distinct edadQuinquenal from Personas order by 1 asc";
                return consultarEdadQ(selectStatement);
            }
            else {
                string selectStatement = "SELECT * FROM " + nombreTabla + " ;";
                return consultar(selectStatement);
            }
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





        //Consulta indicador 
        public List<IResultado> consultaIndicador(object obj)
        {
            if (obj is string)
            {
                string selectStatement = (string)obj;
                List<ResultadoConsultaIndicador> resultado = new List<ResultadoConsultaIndicador>();

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
                        ResultadoConsultaIndicador tabla = new ResultadoConsultaIndicador();
                        tabla.cantidad = Int32.Parse(reader[0].ToString());
                        tabla.nombre = reader[1].ToString();
                        tabla.mes = reader[2].ToString();
                        tabla.anno = Int32.Parse(reader[3].ToString());

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

        public List<IResultado> consultaIndicador_roles()
        {
            string selectStatement = "select count(r.identificador) as cantidad, r1.tipo, mes, anno "+
                            "from Registros r join Personas p on r.identificador = p.identificador "+
                                "join roles r1 on p.rol = r1.codigo " +
                            "group by r1.tipo, r.mes, r.anno" + ";";
            return consultaIndicador(selectStatement);
        }

        public List<IResultado> consultaIndicador_Lesiones()
        {
            string selectStatement = "select count(r.identificador) as cantidad, l.tipo, mes, anno " +
                            "from Registros r join Personas p on r.identificador = p.identificador " +
                                "join Lesiones l on p.lesion = l.codigo " +
                            "group by l.tipo, r.mes, r.anno" + ";";
            return consultaIndicador(selectStatement);
        }

        public List<IResultado> consultaIndicador_Sexo()
        {
            string selectStatement = "select count(r.identificador) as cantidad, p.sexo,r.mes, anno " +
                            "from Registros r join Personas p on r.identificador = p.identificador " +
                            "group by p.sexo, r.mes, r.anno" + ";";
            return consultaIndicador(selectStatement);
        }


        public List<IResultado> consultaIndicador_EdadQ()
        {
            string selectStatement = "select count(r.identificador) as cantidad, p.edadQuinquenal,r.mes, anno " +
                            "from Registros r join Personas p on r.identificador = p.identificador " +
                            "group by p.edadQuinquenal, r.mes, r.anno" + ";";
            return consultaIndicador(selectStatement);
        }

    }
}
