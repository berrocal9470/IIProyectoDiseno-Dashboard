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
        private List<ResultadoTablas> Provincias { get; set; }
        private List<ResultadoTablas> Cantones { get; set; }
        private List<ResultadoTablas> Distritos { get; set; }
        
        //Se puede aprovechar el codigo-nombre para estos
        private ResultadoTablas Indicador { get; set; }
        private ResultadoTablas TipoAfectado { get; set; }
        private ResultadoTablas TipoLesion { get; set; }

        private string Sexo { get; set; }
        private string EdadQuinquenal { get; set; }

        private List<IResultado> resultados { get; set; }

        private EnumTipoConsulta.TipoConsulta tipoConsulta { get; set; }

        public DTO() { }
    }
}
