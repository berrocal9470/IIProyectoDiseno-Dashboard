using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Dashboard.Vista
{
    public partial class ctrlDinamica : UserControl
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        //Coordenadas iniciales de SJ,Costa Rica
        double LatInicial = 9.86398955624118;
        double LngInicial = -83.92074288718004;

        public ctrlDinamica()
        {
            InitializeComponent();
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

        private void ctrlDinamica_Load(object sender, EventArgs e)
        {
            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.Position = new PointLatLng(LatInicial, LngInicial);
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 14;
            mapa.AutoScroll = true;
        }
    }
}
