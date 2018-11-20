using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class Indicador : ConsultaComponente
    {
        public IndicadorEnum.TipoIndicador tipoIndicador { get; set; }
        public ResultadoTablas resultadoConsulta { get; set; }

        public Indicador(IndicadorEnum.TipoIndicador tipo, IResultado resultado)
        {
            tipoIndicador = tipo;
            resultadoConsulta = (ResultadoTablas)resultado;
        }

        public override string definirWhere()
        {
            string campo="";
            switch (tipoIndicador)
            {
                case IndicadorEnum.TipoIndicador.TipoAfectado:
                    campo = "p.rol = " + resultadoConsulta.Codigo;
                    break;
                case IndicadorEnum.TipoIndicador.Sexo:
                    campo = "p.sexo = '" + resultadoConsulta.Nombre + "'";
                    break;
                case IndicadorEnum.TipoIndicador.TipoLesion:
                    campo = "p.lesion = " + resultadoConsulta.Codigo;
                    break;
                case IndicadorEnum.TipoIndicador.EdadQuinquenal:
                    campo = "p.edadQuinquenal = '" + resultadoConsulta.Nombre + "'";
                    break;
                case IndicadorEnum.TipoIndicador.Provincia:
                    campo = "d.id_provincia = '" + resultadoConsulta.Codigo + "'";
                    break;
                case IndicadorEnum.TipoIndicador.Canton:
                    campo = "d.id_canton = '" + resultadoConsulta.Codigo + "'";
                    break;
                case IndicadorEnum.TipoIndicador.Distrito:
                    campo = "d.id_distrito = '" + resultadoConsulta.Codigo + "'";
                    break;
                case IndicadorEnum.TipoIndicador.Anno:
                    campo = "r.anno = " + resultadoConsulta.Codigo;
                    break;
            }
            return campo;
        }
    }
}
