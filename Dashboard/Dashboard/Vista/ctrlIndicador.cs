using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Dashboard.Vista
{
    public partial class ctrlIndicador : UserControl
    {
        public ctrlIndicador()
        {
            InitializeComponent();
        }

        private void ctrlIndicador_Load(object sender, EventArgs e)
        {
            ArrayList etiquetas = new ArrayList();
            ArrayList valores = new ArrayList();

            etiquetas.Add("Etiqueta 1");
            etiquetas.Add("Etiqueta 2");
            etiquetas.Add("Etiqueta 3");

            valores.Add(130);
            valores.Add(40);
            valores.Add(150);

            grafGeneral.Series[0].Points.DataBindXY(etiquetas, valores);

            graf2012.Series[0].Points.DataBindXY(etiquetas, valores);
            graf2013.Series[0].Points.DataBindXY(etiquetas, valores);
            graf2014.Series[0].Points.DataBindXY(etiquetas, valores);
        }
    }
}
