using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Modelo
{
    class ResultadoObserver : IResultado
    {
        public string Sexo { get; set; }
        public int Edad { get; set; }

        //Constructor default
        public ResultadoObserver()
        {
            Sexo = "";
            Edad = 0;
        }

        //Contructor necesario
        public ResultadoObserver(string sexo, int edad)
        {
            Sexo = sexo;
            Edad = edad;
        }

        public void getResultado()
        {
            throw new NotImplementedException();
        }
    }
}
