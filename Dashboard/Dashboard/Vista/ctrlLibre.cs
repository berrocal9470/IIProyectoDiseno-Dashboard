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
    public partial class ctrlLibre : UserControl
    {
        public ctrlLibre()
        {
            InitializeComponent();
        }

        private void ctrlLibre_Load(object sender, EventArgs e)
        {
            ArrayList etiquetas = new ArrayList();
            ArrayList valores = new ArrayList();

            etiquetas.Add("Hombres");
            etiquetas.Add("Mujeres");
            etiquetas.Add("Indecisos");

            valores.Add(130);
            valores.Add(40);
            valores.Add(150);

            grafGeneral.Series[0].Points.DataBindXY(etiquetas, valores);
        }

        private void trckEdadQuinquenal_Scroll(object sender, EventArgs e)
        {
            int trackValue = trckEdadQuinquenal.Value;
            int salto = 5;      //tamaño del salto cada que cambia de valor

            if (trackValue % 5 != 0)
            {
                trackValue = (trackValue / salto) * salto;
                trckEdadQuinquenal.Value = trackValue;
            }

            ajustarEdad();
        }

        private void chkEdadDesconocida_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdadDesconocida.Checked)
            {
                lblEdadQuinquenal.Text = "Desconocida";
            }
            else
            {
                ajustarEdad();
            }
        }

        private void ajustarEdad()
        {
            int trackValue = trckEdadQuinquenal.Value;
            string edadQuinquenal;

            if (trackValue == 75)
            {
                edadQuinquenal = "Mayor a " + trackValue + " años";
            }
            else
            {
                edadQuinquenal = "De " + trackValue + " a " + (trackValue + 4) + " años";
            }

            lblEdadQuinquenal.Text = edadQuinquenal;
        }
    }
}
