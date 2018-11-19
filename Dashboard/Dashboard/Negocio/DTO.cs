using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class DTO
    {
        public List<ResultadoTablas> Provincias { get; set; }
        public List<ResultadoTablas> Cantones { get; set; }
        public List<ResultadoTablas> Distritos { get; set; }

        //Se puede aprovechar el codigo-nombre para estos
        public ResultadoTablas Indicador { get; set; }
        public ResultadoTablas TipoAfectado { get; set; }
        public ResultadoTablas TipoLesion { get; set; }

        public string Sexo { get; set; }
        public string EdadQuinquenal { get; set; }

        public ResultadosConsulta Resultados { get; set; }

        public EnumTipoConsulta.TipoConsulta tipoConsulta { get; set; }

        public DTO() { }
    }
}
