using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Modelo
{
    class ResultadoConsultaIndicador : IResultado
    {
        public int cantidad { get; set; }
        public string nombre { get; set; }
        public string mes { get; set; }
        public int anno { get; set; }

        //Contructor default
        public ResultadoConsultaIndicador()
        {
            cantidad = 0;
            nombre = "";
            mes = "";
            anno = 0;
        }

        //Constructor necesario
        public ResultadoConsultaIndicador(int pCantidad, string pNombre, string pMes, int pAnno)
        {
            cantidad = pCantidad;
            nombre = pNombre;
            mes = pMes;
            anno = pAnno;
        }

        public void getResultado()
        {
            throw new NotImplementedException();
        }
    }
}
