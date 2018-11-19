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

        override
        public void notify()
        {
            //notifica
        }
    }
}
