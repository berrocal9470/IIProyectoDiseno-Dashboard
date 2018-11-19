using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class Controlador : Observable, IConsultable
    {
        //Así se usaría el enum en las otras clases
        //EnumTipoConsulta.TipoConsulta tipoConsulta = EnumTipoConsulta.TipoConsulta.Dinamica;

        private DAOBD daoBD;

        public Controlador()
        {
            daoBD = new DAOBD();
        }

        public List<IResultado> consultar(object obj)
        {
            return null;
        }

        public DTO consultaObserver()
        {
            ResultadosConsulta resultado = new ResultadosConsulta(daoBD.consultaObserver());
            DTO dto = new DTO();
            dto.Resultados = resultado;
            return dto;
        }

        public DTO consultarTabla(string nombreTabla)
        {
            //string nombreTabla = "Provincias";
            ResultadosConsulta resultado = new ResultadosConsulta(daoBD.consultarTabla(nombreTabla));
            DTO dto = new DTO();
            dto.Resultados = resultado;
            return dto;
        }

        public string generarConsulta()
        {
            
            IndicadorEnum.TipoIndicador tipoIndicador = IndicadorEnum.TipoIndicador.Provincia;
            ResultadoTablas resultado = new ResultadoTablas("3", "Cartago");

            ConsultaComponente consulta = new Indicador(tipoIndicador, resultado);
            consulta = new WhereDecorator(null, consulta);

            tipoIndicador = IndicadorEnum.TipoIndicador.TipoAfectado;
            resultado = new ResultadoTablas(10, "Peatón");

            ConsultaComponente nuevaConsulta = new Indicador(tipoIndicador, resultado);
            consulta = new WhereDecorator(consulta, nuevaConsulta);

            tipoIndicador = IndicadorEnum.TipoIndicador.TipoLesion;
            resultado = new ResultadoTablas(2, "Ileso");

            nuevaConsulta = new Indicador(tipoIndicador, resultado);
            consulta = new WhereDecorator(consulta, nuevaConsulta);

            tipoIndicador = IndicadorEnum.TipoIndicador.Sexo;
            resultado = new ResultadoTablas(10, "Mujer");

            nuevaConsulta = new Indicador(tipoIndicador, resultado);
            consulta = new WhereDecorator(consulta, nuevaConsulta);

            tipoIndicador = IndicadorEnum.TipoIndicador.Anno;
            resultado = new ResultadoTablas(0, "2012");

            nuevaConsulta = new Indicador(tipoIndicador, resultado);
            consulta = new WhereDecorator(consulta, nuevaConsulta);

            string where = consulta.definirWhere();

            return where.Substring(0, where.Length - 5);
        }


        override
        public void notify()
        {
            //notifica
        }
    }
}
