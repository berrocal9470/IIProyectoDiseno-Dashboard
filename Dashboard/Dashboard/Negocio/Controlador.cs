using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class Controlador : Observable
    {
        //Así se usaría el enum en las otras clases
        //EnumTipoConsulta.TipoConsulta tipoConsulta = EnumTipoConsulta.TipoConsulta.Dinamica;

        private DAOBD daoBD;

        public Controlador()
        {
            daoBD = new DAOBD();
        }

        public DTO consultarDinamica(object obj)
        {
            if(obj is DTO)
            {
                List<string> querys = new List<string>();
                List<int> cantidades = new List<int>();
                List<ResultadoConsultaDinamica> resultados = new List<ResultadoConsultaDinamica>();

                DTO entrada = (DTO)obj;
                DTO salida = new DTO();

                //copia el DTO de la entrada
                DTO dtoGenerable = entrada.DeepCopy();

                //si tiene distritos, entonces se hace un query para cada uno de esos
                if (entrada.Distritos != null && entrada.Distritos.Count != 0)
                {
                    foreach (ResultadoTablas rt in entrada.Distritos)
                    {
                        dtoGenerable.Distritos = new List<ResultadoTablas>();
                        dtoGenerable.Distritos.Add(rt);

                        string consultaGenerada = generarConsulta(dtoGenerable);
                        querys.Add(consultaGenerada);
                        cantidades.Add(daoBD.consultarCantidad(consultaGenerada));
                    }

                    ResultadoTablas provincia = entrada.Provincias.ElementAt(0);
                    ResultadoTablas canton = entrada.Cantones.ElementAt(0);
                    for (int i=0; i< entrada.Distritos.Count; i++)
                    {
                        ResultadoTablas distrito = entrada.Distritos.ElementAt(i);

                        ResultadoConsultaDinamica result = (ResultadoConsultaDinamica)daoBD.consultarCoordenadas(provincia.Codigo.ToString(),
                            canton.Codigo.ToString(), distrito.Codigo.ToString());

                        result.Provincia = provincia.Nombre;
                        result.Canton = canton.Nombre;
                        result.Distrito = distrito.Nombre;
                        result.Cantidad = cantidades.ElementAt(i);

                        resultados.Add(result);
                    }
                }
                //si tiene cantones, entonces se hace un query para cada uno de esos
                else if (entrada.Cantones != null && entrada.Cantones.Count != 0)
                {
                    foreach (ResultadoTablas rt in entrada.Cantones)
                    {
                        dtoGenerable.Cantones = new List<ResultadoTablas>();
                        dtoGenerable.Cantones.Add(rt);

                        string consultaGenerada = generarConsulta(dtoGenerable);
                        querys.Add(consultaGenerada);
                        cantidades.Add(daoBD.consultarCantidad(consultaGenerada));
                    }

                    ResultadoTablas provincia = entrada.Provincias.ElementAt(0);
                    for (int i = 0; i < entrada.Cantones.Count; i++)
                    {
                        ResultadoTablas canton = entrada.Cantones.ElementAt(i);

                        ResultadoConsultaDinamica result = (ResultadoConsultaDinamica)daoBD.consultarCoordenadas(provincia.Codigo.ToString(),
                            canton.Codigo.ToString(), "01");

                        result.Provincia = provincia.Nombre;
                        result.Canton = canton.Nombre;
                        result.Distrito = null;
                        result.Cantidad = cantidades.ElementAt(i);

                        resultados.Add(result);
                    }
                }
                //si tiene provincias, entonces se hace un query para cada uno de esos
                else if (entrada.Provincias != null && entrada.Provincias.Count != 0)
                {
                    foreach (ResultadoTablas rt in entrada.Provincias)
                    {
                        dtoGenerable.Provincias = new List<ResultadoTablas>();
                        dtoGenerable.Provincias.Add(rt);

                        string consultaGenerada = generarConsulta(dtoGenerable);
                        querys.Add(consultaGenerada);
                        cantidades.Add(daoBD.consultarCantidad(consultaGenerada));
                    }

                    for (int i = 0; i < entrada.Provincias.Count; i++)
                    {
                        ResultadoTablas provincia = entrada.Provincias.ElementAt(i);

                        ResultadoConsultaDinamica result = (ResultadoConsultaDinamica)daoBD.consultarCoordenadas(provincia.Codigo.ToString(), "01", "01");

                        result.Provincia = provincia.Nombre;
                        result.Canton = null;
                        result.Distrito = null;
                        result.Cantidad = cantidades.ElementAt(i);

                        resultados.Add(result);
                    }
                }
                //se hace a nivel general del país
                else
                {
                    dtoGenerable.Provincias = dtoGenerable.Cantones = dtoGenerable.Distritos = null;

                    string consultaGenerada = generarConsulta(dtoGenerable);
                    querys.Add(consultaGenerada);
                    int cantidad = daoBD.consultarCantidad(consultaGenerada);
                    cantidades.Add(cantidad);

                    ResultadoConsultaDinamica result = (ResultadoConsultaDinamica)daoBD.consultarCoordenadas("1", "01", "01");

                    result.Provincia = "País";
                    result.Canton = null;
                    result.Distrito = null;
                    result.Cantidad = cantidad;

                    resultados.Add(result);
                }

                //return querys;
                //return cantidades;
                salida.Resultados = new ResultadosConsulta(resultados.Cast<IResultado>().ToList());
                return salida;
            }

            return null;
        }

        private DTO generarDTO(ResultadosConsulta resultado)
        {
            DTO dto = new DTO();
            dto.Resultados = resultado;
            return dto;
        }

        public DTO consultaObserver()
        {
            ResultadosConsulta resultado = new ResultadosConsulta(daoBD.consultaObserver());
            return generarDTO(resultado);
        }

        public DTO consultarTabla(string nombreTabla)
        {
            ResultadosConsulta resultado = new ResultadosConsulta(daoBD.consultarTabla(nombreTabla));
            return generarDTO(resultado);
        }

        public DTO consultarCantones(string idProvincia)
        {
            ResultadosConsulta resultado = new ResultadosConsulta(daoBD.consultarCantones(idProvincia));
            return generarDTO(resultado);
        }

        public DTO consultarDistritos(string idProvincia, string idCanton)
        {
            ResultadosConsulta resultado = new ResultadosConsulta(daoBD.consultarDistritos(idProvincia, idCanton));
            return generarDTO(resultado);
        }


        public string generarConsulta(DTO dto)
        {
            //El "encabezado" SIEMPRE es el mismo
            string encabezado = "select count(r.identificador) " +
                "from registros r " +
                "join distritos d on r.id_provincia = d.id_provincia and r.id_canton = d.id_canton and r.id_distrito = d.id_distrito " +
                "join personas p on r.identificador = p.identificador where ";

            IndicadorEnum.TipoIndicador tipoIndicador;
            ResultadoTablas resultado;
            ConsultaComponente consulta = null;
            ConsultaComponente nuevaConsulta;

            if (dto.Provincias != null && dto.Provincias.Count != 0)
            {
                foreach (ResultadoTablas prov in dto.Provincias)
                {
                    tipoIndicador = IndicadorEnum.TipoIndicador.Provincia;

                    if(consulta == null)
                    {
                        consulta = new Indicador(tipoIndicador, prov);
                        consulta = new WhereDecorator(null, consulta);
                    }
                    else
                    {
                        nuevaConsulta = new Indicador(tipoIndicador, prov);
                        consulta = new WhereDecorator(consulta, nuevaConsulta);
                    }
                }
            }

            if (dto.Cantones != null && dto.Cantones.Count != 0)
            {
                foreach (ResultadoTablas cant in dto.Cantones)
                {
                    tipoIndicador = IndicadorEnum.TipoIndicador.Canton;

                    //si llega a este caso la consulta nunca va a ser null
                    nuevaConsulta = new Indicador(tipoIndicador, cant);
                    consulta = new WhereDecorator(consulta, nuevaConsulta);
                }
            }

            if (dto.Distritos != null && dto.Distritos.Count != 0)
            {
                foreach (ResultadoTablas dist in dto.Distritos)
                {
                    tipoIndicador = IndicadorEnum.TipoIndicador.Distrito;

                    //si llega a este caso la consulta nunca va a ser null
                    nuevaConsulta = new Indicador(tipoIndicador, dist);
                    consulta = new WhereDecorator(consulta, nuevaConsulta);
                }
            }

            if(dto.TipoAfectado != null)
            {
                tipoIndicador = IndicadorEnum.TipoIndicador.TipoAfectado;

                if (consulta == null)
                {
                    consulta = new Indicador(tipoIndicador, dto.TipoAfectado);
                    consulta = new WhereDecorator(null, consulta);
                }
                else
                {
                    nuevaConsulta = new Indicador(tipoIndicador, dto.TipoAfectado);
                    consulta = new WhereDecorator(consulta, nuevaConsulta);
                }
            }

            if(dto.Sexo != null)
            {
                tipoIndicador = IndicadorEnum.TipoIndicador.Sexo;
                resultado = new ResultadoTablas(-1, dto.Sexo);

                if (consulta == null)
                {
                    consulta = new Indicador(tipoIndicador, resultado);
                    consulta = new WhereDecorator(null, consulta);
                }
                else
                {
                    nuevaConsulta = new Indicador(tipoIndicador, resultado);
                    consulta = new WhereDecorator(consulta, nuevaConsulta);
                }
            }

            if (dto.TipoLesion != null)
            {
                tipoIndicador = IndicadorEnum.TipoIndicador.TipoLesion;

                if (consulta == null)
                {
                    consulta = new Indicador(tipoIndicador, dto.TipoLesion);
                    consulta = new WhereDecorator(null, consulta);
                }
                else
                {
                    nuevaConsulta = new Indicador(tipoIndicador, dto.TipoLesion);
                    consulta = new WhereDecorator(consulta, nuevaConsulta);
                }
            }

            if(dto.Annos != null && dto.Annos.Count != 0)
            {
                foreach(int anno in dto.Annos)
                {
                    tipoIndicador = IndicadorEnum.TipoIndicador.Anno;
                    resultado = new ResultadoTablas(anno, "");

                    if (consulta == null)
                    {
                        consulta = new Indicador(tipoIndicador, resultado);
                        consulta = new WhereDecorator(null, consulta);
                    }
                    else
                    {
                        nuevaConsulta = new Indicador(tipoIndicador, resultado);
                        consulta = new WhereDecorator(consulta, nuevaConsulta);
                    }
                }
            }

            if(dto.EdadQuinquenal != null)
            {
                tipoIndicador = IndicadorEnum.TipoIndicador.EdadQuinquenal;
                resultado = new ResultadoTablas(-1, dto.EdadQuinquenal);

                if (consulta == null)
                {
                    consulta = new Indicador(tipoIndicador, resultado);
                    consulta = new WhereDecorator(null, consulta);
                }
                else
                {
                    nuevaConsulta = new Indicador(tipoIndicador, resultado);
                    consulta = new WhereDecorator(consulta, nuevaConsulta);
                }
            }

            //si al llegar aquí sigue siendo null es porque no seleccionaron nada
            if(consulta == null)
            {
                //quita el where
                return encabezado.Substring(0, encabezado.Length - 7);
            }

            string where = consulta.definirWhere();
            //quita el último and
            return encabezado + where.Substring(0, where.Length - 5);
        }


        public override void notify()
        {
            //notifica
        }
    }
}
