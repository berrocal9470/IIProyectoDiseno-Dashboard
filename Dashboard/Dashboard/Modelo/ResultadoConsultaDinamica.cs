using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Modelo
{
    class ResultadoConsultaDinamica : IResultado
    {
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int Cantidad { get; set; }

        //Constructor default
        public ResultadoConsultaDinamica()
        {
            Provincia = "";
            Canton = "";
            Distrito = "";
            Latitud = 0;
            Longitud = 0;
            Cantidad = 0;
        }

        //Constructor necesario
        public ResultadoConsultaDinamica(string provincia, string canton, string distrito,
            double latitud, double longitud, int cantidad)
        {
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            Latitud = latitud;
            Longitud = longitud;
            Cantidad = cantidad;
        }

        public string GetToString()
        {
            string msj = Provincia + ", " + Canton + ", " + Distrito + ", " +
                Latitud + ", " + Longitud + ".";
            return msj;
        }
    }
}
