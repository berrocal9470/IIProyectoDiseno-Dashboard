using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    interface IConsultable
    {
        List<IResultado> consultar(object obj);
    }
}
