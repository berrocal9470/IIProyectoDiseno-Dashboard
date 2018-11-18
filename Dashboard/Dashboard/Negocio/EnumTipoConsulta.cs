using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    //Se hace una clase estática con un enum dentro
    // para simular el mismo comportamiento que tendría en Java
    public static class EnumTipoConsulta
    {
        public enum TipoConsulta
        {
            Dinamica, Indicador, Observer
        };
    }
}
