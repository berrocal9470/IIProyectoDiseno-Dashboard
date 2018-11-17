using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos.Negocio
{
    class Controlador
    {
        private GestorUbicaciones gestorUbicaciones;
        private DAOExcel daoExcel;
        private DAOBD daoBD;

        public Controlador()
        {
            daoExcel = new DAOExcel();
            daoBD = new DAOBD();
            gestorUbicaciones = new GestorUbicaciones();
        }

        public void cargarCsv(string direccion)
        {
            DAOcsv csv = new DAOcsv();
            csv.Leer(direccion);
            gestorUbicaciones = csv.gestorUbicaciones;

            //Console.WriteLine(gestorUbicaciones.GetToString());
        }

        public void leerExcel(string archivo)
        {
            daoExcel.gestorUbicaciones = gestorUbicaciones;
            daoExcel.Leer(archivo);
        }

    }
}
