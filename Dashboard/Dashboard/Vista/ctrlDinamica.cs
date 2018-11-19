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
using Dashboard.Negocio;
using Dashboard.Modelo;

namespace Dashboard.Vista
{
    public partial class ctrlDinamica : UserControl
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        Controlador controlador = new Controlador();

        DTO dto = new DTO();

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

        private void cargarProvincias() {
            dto = controlador.consultarTabla("Provincias");
            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxProvincia.Items.Add(obs.Nombre);
            }

        }

        private void cargarAfectados()
        {
            dto = controlador.consultarTabla("Roles");
            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxAfectado.Items.Add(obs.Nombre);
            }

        }


        private void cargarLesiones()
        {
            dto = controlador.consultarTabla("Lesiones");
            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxLesion.Items.Add(obs.Nombre);
            }

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

            cbxSexo.Items.Add("Hombre");
            cbxSexo.Items.Add("Mujer");
            cbxSexo.Items.Add("Desconocido");

            cargarProvincias();
            cargarAfectados();
            cargarLesiones();
        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            if (cbxProvincia.SelectedIndex > -1)
            {
                if (!lbxProvincia.Items.Contains(cbxProvincia.SelectedItem))
                {
                    lbxProvincia.Items.Add(cbxProvincia.SelectedItem);
                }         
            }
            else {
                MessageBox.Show("Debe seleccionar una provincia");
            }
        }

        private void btnQuitarProvincia_Click(object sender, EventArgs e)
        {
            
            lbxProvincia.Items.Remove(lbxProvincia.SelectedItem);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string where = controlador.generarConsulta();

            MessageBox.Show(where);

        }
    }
}
