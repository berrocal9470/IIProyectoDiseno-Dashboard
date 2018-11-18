using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Modelo
{
    class ResultadoConsultaDinamica : IResultado
    {
        private string Provincia { get; set; }
        private string Canton { get; set; }
        private string Distrito { get; set; }
        private double Latitud { get; set; }
        private double Longitud { get; set; }

        //Constructor default
        public ResultadoConsultaDinamica()
        {
            Provincia = "";
            Canton = "";
            Distrito = "";
            Latitud = 0;
            Longitud = 0;
        }

        //Constructor necesario
        public ResultadoConsultaDinamica(string provincia, string canton, string distrito,
            double latitud, double longitud)
        {
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            Latitud = latitud;
            Longitud = longitud;
        }

        public void getResultado()
        {
            throw new NotImplementedException();
        }
    }
}
