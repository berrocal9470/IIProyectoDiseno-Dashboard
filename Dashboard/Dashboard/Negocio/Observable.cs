using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    public abstract class Observable
    {
        public abstract object notify(object observado, string rol);
    }
}
