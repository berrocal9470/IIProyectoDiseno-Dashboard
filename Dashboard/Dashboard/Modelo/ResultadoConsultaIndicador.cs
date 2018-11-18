using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Modelo
{
    class ResultadoConsultaIndicador : IResultado
    {
        private string Indicador { get; set; }
        private string Valor { get; set; }

        //Contructor default
        public ResultadoConsultaIndicador()
        {
            Indicador = "";
            Valor = "";
        }

        //Constructor necesario
        public ResultadoConsultaIndicador(string indicador, string valor)
        {
            Indicador = indicador;
            Valor = valor;
        }

        public void getResultado()
        {
            throw new NotImplementedException();
        }
    }
}
