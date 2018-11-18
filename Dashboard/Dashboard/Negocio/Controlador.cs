using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class Controlador : IConsultable
    {
        //Así se usaría el enum en las otras clases
        EnumTipoConsulta.TipoConsulta tipoConsulta = EnumTipoConsulta.TipoConsulta.Dinamica;

        public List<IResultado> consultar(object obj)
        {
            return null;
        }
    }
}
