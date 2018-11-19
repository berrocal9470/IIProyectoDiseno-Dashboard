using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Negocio
{
    class WhereDecorator : ConsultaDecorator
    {
        public WhereDecorator(ConsultaComponente componente, ConsultaComponente nuevoComponente)
            : base(componente, nuevoComponente) { }

        public override string definirWhere()
        {
            if(GetConsultaComponente() == null){
                return nuevoComponente.definirWhere() + " and ";
            }
            else{
                return GetConsultaComponente().definirWhere() + nuevoComponente.definirWhere() + " and ";
            }
        }
    }
}
