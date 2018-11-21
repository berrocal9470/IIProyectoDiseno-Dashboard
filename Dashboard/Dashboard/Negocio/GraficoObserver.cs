using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class GraficoObserver : IObserver
    {
        //atributos que modelan el estado
        public ResultadosConsulta Datos { get; set; }
        private string sexo;
        private int edadMenor;
        private int edadMayor;

        public GraficoObserver()
        {
            //valores por defecto
            sexo = "";
            edadMayor = 110;
            edadMenor = 0;
        }

        public object update(object observado, string rol)
        {
            if (Datos != null)
            {
                //Sexo
                if (observado is System.Windows.Forms.ComboBox)
                {
                    //resultado con el sexo cambiado
                    sexo = ((System.Windows.Forms.ComboBox)observado).SelectedItem.ToString();
                    return generarSalida();
                }
                else if (observado is System.Windows.Forms.NumericUpDown)
                {
                    if (rol.Equals("Mayor"))
                    {
                        //resultado con la edad mayor cambiada
                        edadMayor = Convert.ToInt32(((System.Windows.Forms.NumericUpDown)observado).Value);
                        return generarSalida();
                    }
                    else if (rol.Equals("Menor"))
                    {
                        //resultado con la edad maenor cambiada
                        edadMenor = Convert.ToInt32(((System.Windows.Forms.NumericUpDown)observado).Value);
                        return generarSalida();
                    }
                }
                else
                {
                    //resultado general pa' todos
                    return Datos;
                }
            }

            //cualquier otra cosa devuelve datos vacíos
            return new ResultadosConsulta(new List<IResultado>());
        }

        private ResultadosConsulta generarSalida()
        {
            List<IResultado> salida = new List<IResultado>();
            ResultadoObserver aux;

            if (sexo.Equals("") || sexo.Equals("Todos"))
            {
                //no se toma en cuenta el sexo
                for (Iterator iter = Datos.getIterador(); iter.hasNext();)
                {
                    aux = (ResultadoObserver)iter.next();
                    if ((aux.Edad >= edadMenor) && (aux.Edad <= edadMayor))
                        salida.Add(aux);
                }
            }
            else
            {
                //se diferencia por sexo
                for (Iterator iter = Datos.getIterador(); iter.hasNext();)
                {
                    aux = (ResultadoObserver)iter.next();
                    if ((aux.Sexo.Equals(sexo)) && (aux.Edad >= edadMenor) && (aux.Edad <= edadMayor))
                        salida.Add(aux);
                }
            }

            return new ResultadosConsulta(salida);
        }
    }
}
