using CargaDatos.Modelo;
using CargaDatos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace CargaDatos
{
    class Program
    {

        static void Main(string[] args)
        {
            Controlador controlador = new Controlador();
            controlador.cargarCsv("C:\\Users\\greiv\\Desktop\\Pato\\Temp TEC\\Diseño\\Proyecto 2\\costa-rica-geolocated-districts-master\\cr-districts.csv");
            controlador.leerExcel("C:\\Users\\greiv\\Desktop\\Pato\\Temp TEC\\Diseño\\Proyecto 2\\acc.xlsx");
            

            Console.WriteLine("Listo!");
            Console.ReadLine();
        }
    }
}
