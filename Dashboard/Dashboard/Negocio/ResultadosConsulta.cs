using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class ResultadosConsulta : IContainer
    {
        public List<IResultado> Resultados { get; set; }

        public Iterator getIterador()
        {
            return new ResultadoIterator(this);
        }

        public ResultadosConsulta(List<IResultado> resultados)
        {
            Resultados = resultados;
        }

        //Clase interna que implementa el Iterador
        private class ResultadoIterator : Iterator
        {
            private ResultadosConsulta resultadosConsulta;
            int index;

            //Recibe un objeto del tipo ResultadoConsulta 
            // para poder utilizar los atributos que tiene esa instancia
            public ResultadoIterator(ResultadosConsulta resultados)
            {
                resultadosConsulta = resultados;
            }

            public Boolean hasNext()
            {
                if(resultadosConsulta.Resultados == null)
                {
                    return false;
                }
                return index < resultadosConsulta.Resultados.Count;
            }

            public Object next()
            {
                if (this.hasNext())
                {
                    return resultadosConsulta.Resultados.ElementAt(index++);
                }
                return null;
            }
        }
    }
}
