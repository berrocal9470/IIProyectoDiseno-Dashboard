using CargaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;


namespace CargaDatos.Negocio
{
    class DAOExcel : ILectura
    {
        private DAOBD baseDatos;
        public GestorUbicaciones gestorUbicaciones { get; set; }

        //para no mandar a ejecutar todo lo que se encuentra
        private List<string> provincias;
        private List<string> roles;
        private List<string> lesiones;

        public DAOExcel()
        {
            baseDatos = new DAOBD();
            gestorUbicaciones = new GestorUbicaciones();

            provincias = new List<string>();
            roles = new List<string>();
            lesiones = new List<string>();
        }


        public void Leer(string direccion)
        {
            //se asegura de que los Double se manejen con punto decimal, no coma decimal
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Console.WriteLine("Cargando datos a la base, espere...");

            //Crea objetos COM
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(direccion);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;


            baseDatos.abrirConexion();
            inicializarTablas(xlRange); //inserta todo
            baseDatos.cerrarConexion();

            //limpieza
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //libera los objetos COM para matar el proceso de Excel
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //cerrar y liberar
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quitar y liberar
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        //Ingresa los valores en las tablas, por nivel de profundidad
        // (primero las que no tienen relaciones)
        private void inicializarTablas(Excel.Range xlRange)
        {
            //int rowCount = xlRange.Rows.Count;        //este no cuenta bien
            int rowCount = 79526;
            int colCount = xlRange.Columns.Count;
            Console.WriteLine(rowCount);

            //Itera por todas las filas y columnas e imprime su contenidos
            for (int i = 79501; i <= rowCount; i++)
            {
                string idRegistro =     xlRange.Cells[i, 1].Value2.ToString();
                string idProvincia =    xlRange.Cells[i, 2].Value2.ToString();
                string provincia =      xlRange.Cells[i, 3].Value2.ToString();
                string canton =         xlRange.Cells[i, 4].Value2.ToString();
                string distrito =       xlRange.Cells[i, 5].Value2.ToString();
                string dia =            xlRange.Cells[i, 6].Value2.ToString();
                string mes =            xlRange.Cells[i, 7].Value2.ToString();
                string anno =           xlRange.Cells[i, 8].Value2.ToString();
                string idRol =          xlRange.Cells[i, 9].Value2.ToString();
                string rol =            xlRange.Cells[i, 10].Value2.ToString();
                string idLesion =       xlRange.Cells[i, 11].Value2.ToString();
                string lesion =         xlRange.Cells[i, 12].Value2.ToString();
                string edad =           xlRange.Cells[i, 13].Value2.ToString();
                string edadQuinquenal = xlRange.Cells[i, 14].Value2.ToString();
                string idSexo =         xlRange.Cells[i, 15].Value2.ToString();
                string sexo =           xlRange.Cells[i, 16].Value2.ToString();

                if (edad.Equals("Desconocida")) edad = "0";

                Ubicacion ubicacion = gestorUbicaciones.getUbicacion(idProvincia, canton, distrito);

                if(ubicacion == null)
                {
                    Console.WriteLine("Error en el registro: " + idRegistro);
                }
                else
                {
                    string idCanton = ubicacion.CodigoCanton;
                    string idDistrito = ubicacion.CodigoDistrito;

                    double latitud = gradosADecimales(ubicacion.Latitud);
                    double longitud = gradosADecimales(ubicacion.Longitud);

                    // SE INSERTA EL REGISTRO EN LA BASE, DESCOMPONIENDOLO POR TABLAS SEGÚN RELACIONES
                    string values;
                    
                    //PROVINCIAS
                    if (!provincias.Contains(idProvincia))
                    {
                        values = "'" + idProvincia + "','" + provincia + "'";
                        baseDatos.Agregar("Provincias", values);

                        provincias.Add(idProvincia);
                    }

                    //CANTONES
                    values = "'" + idProvincia + "','" + idCanton + "','" + canton + "'";
                    baseDatos.Agregar("Cantones", values);

                    //DISTRITOS
                    values = "'" + idProvincia + "','" + idCanton + "','" + idDistrito + "','" + distrito + "'," +
                        latitud + "," + longitud;
                    baseDatos.Agregar("Distritos", values);

                    //ROLES
                    if (!roles.Contains(idRol))
                    {
                        values = idRol + ",'" + rol + "'";
                        baseDatos.Agregar("Roles", values);

                        roles.Add(idRol);
                    }

                    //LESIONES
                    if (!lesiones.Contains(idLesion))
                    {
                        values = idLesion + ",'" + lesion + "'";
                        baseDatos.Agregar("Lesiones", values);

                        lesiones.Add(idLesion);
                    }

                    //PERSONAS
                    values = idRegistro + "," + edad + ",'" + edadQuinquenal + "','" + sexo + "'," +
                        idLesion + "," + idRol;
                    baseDatos.Agregar("Personas", values);

                    //REGISTROS
                    values = idRegistro + ",'" + idProvincia + "','" + idCanton + "','" +
                        idDistrito + "','" + dia + "','" + mes + "'," + anno + "," + idRegistro;
                    baseDatos.Agregar("Registros", values);
                }


                //ejecuta bloques de 100 en 100
                if (i % 100 == 0 || i==rowCount)
                {
                    baseDatos.ejecutarTodo();
                }
            }
        }

        /**
         * Convierte una coordenada en grados / minutos / segundos 
         *  a coordenada con decimales
         */
        private double gradosADecimales(string coordenada)
        {
            string[] strGrados = coordenada.Split('°');
            string[] strMinutos = strGrados[1].Split('\'');
            string[] strSegundos = strMinutos[1].Split('\"');

            double grados;
            double minutos;
            double segundos;
            try
            {
                grados = Double.Parse(strGrados[0].Substring(1));    //quita el primer "
                minutos = Double.Parse(strMinutos[0]);
                segundos = Double.Parse(strSegundos[0]);
            }
            catch(Exception e)
            {
                return 0;       //si cae en error pone la coordenada en 0
            }
            

            Boolean signo = false;
            if (grados < 1)              //si es negativo se pasa a positivo y levanta una bandera
            {
                signo = true;
                grados = grados * -1;
            }

            double resultado = grados + (minutos / 60) + (segundos / 3600);
            if (signo) resultado = resultado * -1;

            //ajusta la precision para que no sea muy grande
            return Math.Round(resultado, 10);
        }
    }
}
