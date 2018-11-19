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
        public string EdadQuinquenal { get; set; }

        //Constructor default
        public ResultadoObserver()
        {
            Sexo = "";
            EdadQuinquenal = "";
        }

        //Contructor necesario
        public ResultadoObserver(string sexo, string edadQuinquenal)
        {
            Sexo = sexo;
            EdadQuinquenal = edadQuinquenal;
        }

        public void getResultado()
        {
            throw new NotImplementedException();
        }
    }
}
