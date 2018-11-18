using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Modelo
{
    class ResultadoTablas : IResultado
    {
        //este object puede ser int o string, dependiendo de la tabla
        private object Codigo { get; set; }
        private string Nombre { get; set; }

        //Constructor default
        public ResultadoTablas()
        {
            Codigo = "";
            Nombre = "";
        }

        //Constructor necesario
        public ResultadoTablas(object codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public void getResultado()
        {
            throw new NotImplementedException();
        }
    }
}
