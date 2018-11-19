using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class GraficoObserver : IObserver
    {
        public void update(string componente, object obj)
        {
            List<IResultado> resultados = (List<IResultado>)obj;
        }
    }
}
