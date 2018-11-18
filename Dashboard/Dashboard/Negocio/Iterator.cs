using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    interface Iterator
    {
        Boolean hasNext();
        Object next();
    }
}
