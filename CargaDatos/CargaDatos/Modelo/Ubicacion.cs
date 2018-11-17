using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos.Modelo
{
    class Ubicacion
    {
        public string CodigoProvincia { get; set; }
        public string Provincia { get; set; }
        public string CodigoCanton { get; set; }
        public string Canton { get; set; }
        public string CodigoDistrito { get; set; }
        public string Distrito { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }


        // PROVINCIA (#)
        public void anadirProvincia(string lineaCsv)
        {
            Provincia = getNombre(lineaCsv);
            CodigoProvincia = getCodigo(lineaCsv);
        }

        // CANTON (#)
        public void anadirCanton(string lineaCsv)
        {
            Canton = getNombre(lineaCsv);
            CodigoCanton = getCodigo(lineaCsv);
        }

        // DISTRITO (#)
        public void anadirDistrito(string lineaCsv)
        {
            Distrito = getNombre(lineaCsv);
            CodigoDistrito = getCodigo(lineaCsv);
        }



        // Linea tipo: NOMBRE_(#)
        private string getNombre(string linea)
        {
            int parentesisAbrir = linea.LastIndexOf("(");
            int ultimoCaracter = 0;

            //no toma en cuenta los espacios en _ de NOMBRE_(#)
            for (int i = (parentesisAbrir-1); i>0; i--)
            {
                if(! linea.ElementAt(i).Equals(' '))
                {
                    ultimoCaracter = i;
                    break;
                }
            }

            return linea.Substring(0, ultimoCaracter + 1);
        }

        // Linea tipo: NOMBRE (#)
        private string getCodigo(string linea)
        {
            int parentesisAbrir = linea.LastIndexOf("(");
            int parentesisCerrar = linea.LastIndexOf(")");
            int tamanoCodigo = parentesisCerrar - parentesisAbrir - 1;

            return linea.Substring(parentesisAbrir + 1, tamanoCodigo);
        }
    }
}
