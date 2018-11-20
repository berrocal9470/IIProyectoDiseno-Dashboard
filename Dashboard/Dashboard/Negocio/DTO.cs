using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class DTO
    {
        public List<ResultadoTablas> Provincias { get; set; }
        public List<ResultadoTablas> Cantones { get; set; }
        public List<ResultadoTablas> Distritos { get; set; }

        //Se puede aprovechar el codigo-nombre para estos
        public ResultadoTablas Indicador { get; set; }
        public ResultadoTablas TipoAfectado { get; set; }
        public ResultadoTablas TipoLesion { get; set; }

        public string Sexo { get; set; }
        public string EdadQuinquenal { get; set; }
        public List<int> Annos { get; set; }

        public ResultadosConsulta Resultados { get; set; }

        public EnumTipoConsulta.TipoConsulta tipoConsulta { get; set; }

        public DTO() { }

        //genera una copia del actual estado del DTO
        public DTO DeepCopy()
        {
            DTO copia = (DTO)this.MemberwiseClone();
            if(this.Provincias != null)
            {
                copia.Provincias = new List<ResultadoTablas>();
                foreach (ResultadoTablas rt in this.Provincias) copia.Provincias.Add(new ResultadoTablas(rt.Codigo, rt.Nombre));
            }
            if(this.Cantones != null)
            {
                copia.Cantones = new List<ResultadoTablas>();
                foreach (ResultadoTablas rt in this.Cantones) copia.Cantones.Add(new ResultadoTablas(rt.Codigo, rt.Nombre));
            }
            if(this.Distritos != null)
            {
                copia.Distritos = new List<ResultadoTablas>();
                foreach (ResultadoTablas rt in this.Distritos) copia.Distritos.Add(new ResultadoTablas(rt.Codigo, rt.Nombre));
            }
            if(this.TipoAfectado != null)
            {
                copia.TipoAfectado = new ResultadoTablas(this.TipoAfectado.Codigo, this.TipoAfectado.Nombre);
            }
            if(this.TipoLesion != null)
            {
                copia.TipoLesion = new ResultadoTablas(this.TipoLesion.Codigo, this.TipoLesion.Nombre);
            }
            if(this.Sexo != null)
            {
                copia.Sexo = String.Copy(this.Sexo);
            }
            if(this.EdadQuinquenal != null)
            {
                copia.EdadQuinquenal = String.Copy(this.EdadQuinquenal);
            }
            if(this.Annos != null)
            {
                copia.Annos = new List<int>();
                foreach (int i in this.Annos) copia.Annos.Add(i);
            }

            return copia;
        }
    }
}
