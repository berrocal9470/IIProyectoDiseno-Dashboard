using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    interface IObserver
    {
        //El componente es el objeto de la interfaz que se está observando
        //El rol es para distinguir objetos iguales
        object update(object componente, string rol);
    }
}
