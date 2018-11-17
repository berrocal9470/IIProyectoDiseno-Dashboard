using CargaDatos.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos.Negocio
{
    class GestorUbicaciones
    {
        //ubicaciones divididas por provincias
        Dictionary<string, List<Ubicacion>> ubicaciones;

        public GestorUbicaciones()
        {
            ubicaciones = new Dictionary<string, List<Ubicacion>>();
        }

        //Recibe la línea cruda del csv
        public void procesarLinea(string lineaCsv)
        {
            string[] datos = lineaCsv.Split(',');
            Ubicacion ubicacion = new Ubicacion();

            ubicacion.anadirProvincia(datos[0]);
            ubicacion.anadirCanton(datos[1]);
            ubicacion.anadirDistrito(datos[2]);
            ubicacion.Latitud = datos[3];
            ubicacion.Longitud = datos[4];

            if (!ubicaciones.ContainsKey(ubicacion.CodigoProvincia))
            {
                ubicaciones.Add(ubicacion.CodigoProvincia, new List<Ubicacion>());
            }

            ubicaciones[ubicacion.CodigoProvincia].Add(ubicacion);
        }

        public Ubicacion getUbicacion(string idProvincia, string nombreCanton, string nombreDistrito)
        {
            List<Ubicacion> auxUbicaciones = ubicaciones[idProvincia];
            foreach (Ubicacion u in auxUbicaciones)
            {
                if (u.Canton.Equals(nombreCanton, StringComparison.OrdinalIgnoreCase)
                    && u.Distrito.Equals(nombreDistrito, StringComparison.OrdinalIgnoreCase))
                {
                    return u;
                }
            }
            return null;
        }


        public string GetToString()
        {
            string msj = "";

            for(int i=0; i<ubicaciones.Count; i++)
            {
                List<Ubicacion> lista = ubicaciones.ElementAt(i).Value;

                foreach (Ubicacion u in lista)
                {
                    msj += u.CodigoProvincia + " " + u.Provincia + ", " + u.CodigoCanton + " " + u.Canton +
                        ", " + u.CodigoDistrito + " " + u.Distrito + ", " + u.Latitud + " " + u.Longitud +
                        "\n";
                }
            }

            return msj;
        }
    }
}
