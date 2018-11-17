using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos.Negocio
{
    class DAOcsv : ILectura
    {
        public GestorUbicaciones gestorUbicaciones { get; set; }

        public DAOcsv()
        {
            gestorUbicaciones = new GestorUbicaciones();
        }

        public void Leer(string direccion)
        {
            try
            {
                using (var reader = new StreamReader(direccion))
                {
                    Console.WriteLine("Cargando csv, espere...");

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        gestorUbicaciones.procesarLinea(line);
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.Write("No se encuentra el archivo.");
            }
        }

    }
}
