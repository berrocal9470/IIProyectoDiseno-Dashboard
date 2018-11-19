using Dashboard.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class ConsultaDecorator : ConsultaComponente
    {
        protected ConsultaComponente componente;
        protected ConsultaComponente nuevoComponente { get; set; }

        public ConsultaDecorator(ConsultaComponente comp, ConsultaComponente nuevoComp) {
            componente = comp;
            nuevoComponente = nuevoComp;
        }

        public ConsultaComponente GetConsultaComponente()
        {
            return this.componente;
        }

        public override string definirWhere()
        {
            return GetConsultaComponente().definirWhere();
        }
    }
}
