using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    interface IObserver
    {
        void update(string componente, object resultados);
    }
}
