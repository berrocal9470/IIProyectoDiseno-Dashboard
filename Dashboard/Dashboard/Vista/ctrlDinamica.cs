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

        private Controlador controlador = new Controlador();
        
        //se mantienen los datos para usar luego al momento de seleccionar alguno para la consulta
        private ResultadosConsulta provincias;
        private ResultadosConsulta cantones;
        private ResultadosConsulta distritos;
        private ResultadosConsulta tiposAfectado;
        private ResultadosConsulta tiposLesion;

        //este es el dto que se irá creando para ser enviado a generar el string de la consulta
        private DTO dtoConsultaDinamica;

        //este es para mantener la selección y poder cargar correctamente los distritos
        private ResultadoTablas provinciaSeleccionada;

        //Coordenadas iniciales de SJ,Costa Rica
        private double LatInicial = 9.86398955624118;
        private double LngInicial = -83.92074288718004;

        public ctrlDinamica()
        {
            InitializeComponent();

            dtoConsultaDinamica = new DTO();
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

            chkSinEdad.Checked = true;
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
                chkSinEdad.Checked = false;
            }
            ajustarEdad();
        }

        private void chkSinEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinEdad.Checked)
            {
                lblEdadQuinquenal.Text = "";
                chkEdadDesconocida.Checked = false;
                dtoConsultaDinamica.EdadQuinquenal = null;
            }
            ajustarEdad();
        }

        private void ajustarEdad()
        {
            if(!chkEdadDesconocida.Checked && !chkSinEdad.Checked)
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

        private void cargarProvincias() {
            DTO dto = controlador.consultarTabla("Provincias");
            provincias = dto.Resultados;

            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxProvincia.Items.Add(obs.Nombre);
            }

        }

        //Este se usa para cargar cantones o distritos, según la provincia o cantón seleccionados
        private ResultadoTablas getElement(ResultadosConsulta resultados, string nombre)
        {
            ResultadoTablas obs;
            for (Iterator iter = resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                if (obs.Nombre.Equals(nombre)) return obs;
            }
            return null;
        }

        private void cargarCantones()
        {
            if (lbxProvincia.Items.Count == 1)
            {
                //provinciaSeleccionada = (ResultadoTablas)provincias.Resultados.ElementAt(cbxProvincia.SelectedIndex);
                provinciaSeleccionada = getElement(provincias, lbxProvincia.Items[0].ToString());

                DTO dto = controlador.consultarCantones(provinciaSeleccionada.Codigo.ToString());
                cantones = dto.Resultados;

                ResultadoTablas obs;

                for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
                {
                    obs = (ResultadoTablas)iter.next();
                    cbxCanton.Items.Add(obs.Nombre);
                }
            }
            else
            {
                //limpia los cantones
                cbxCanton.Text = "";
                cbxCanton.Items.Clear();
                lbxCanton.Items.Clear();
                dtoConsultaDinamica.Cantones = null;

                //limpia los distritos
                cbxDistrito.Text = "";
                cbxDistrito.Items.Clear();
                lbxDistrito.Items.Clear();
                dtoConsultaDinamica.Distritos = null;
            }
            
        }

        private void cargarDistritos()
        {
            if (lbxCanton.Items.Count == 1)
            {
                //ResultadoTablas cant = (ResultadoTablas)cantones.Resultados.ElementAt(cbxCanton.SelectedIndex);
                ResultadoTablas cant = getElement(cantones, lbxCanton.Items[0].ToString());

                DTO dto = controlador.consultarDistritos(provinciaSeleccionada.Codigo.ToString(), cant.Codigo.ToString());
                distritos = dto.Resultados;

                ResultadoTablas obs;

                for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
                {
                    obs = (ResultadoTablas)iter.next();
                    cbxDistrito.Items.Add(obs.Nombre);
                }
            }
            else
            {
                //limpia los distritos
                cbxDistrito.Text = "";
                cbxDistrito.Items.Clear();
                lbxDistrito.Items.Clear();
                dtoConsultaDinamica.Distritos = null;
            }
        }

        private void cargarAfectados()
        {
            DTO dto = controlador.consultarTabla("Roles");
            tiposAfectado = dto.Resultados;

            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxAfectado.Items.Add(obs.Nombre);
            }

        }


        private void cargarLesiones()
        {
            DTO dto = controlador.consultarTabla("Lesiones");
            tiposLesion = dto.Resultados;

            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxLesion.Items.Add(obs.Nombre);
            }

        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            int index = cbxProvincia.SelectedIndex;
            if (index > -1)
            {
                if (!lbxProvincia.Items.Contains(cbxProvincia.SelectedItem))
                {
                    lbxProvincia.Items.Add(cbxProvincia.SelectedItem);

                    if(dtoConsultaDinamica.Provincias == null)
                    {
                        dtoConsultaDinamica.Provincias = new List<ResultadoTablas>();
                    }
                    dtoConsultaDinamica.Provincias.Add((ResultadoTablas)provincias.Resultados.ElementAt(index));

                    cargarCantones();
                }         
            }
            else {
                MessageBox.Show("Debe seleccionar una provincia");
            }
        }

        private void btnQuitarProvincia_Click(object sender, EventArgs e)
        {
            if(lbxProvincia.SelectedIndex > -1)
            {
                string nombreProvincia = lbxProvincia.SelectedItem.ToString();
                lbxProvincia.Items.Remove(lbxProvincia.SelectedItem);

                for (int i = 0; i < dtoConsultaDinamica.Provincias.Count; i++)
                {
                    if (dtoConsultaDinamica.Provincias.ElementAt(i).Nombre.Equals(nombreProvincia))
                    {
                        dtoConsultaDinamica.Provincias.RemoveAt(i);
                        break;
                    }
                }

                cargarCantones();
            }
        }

        private void btnAgregarCanton_Click(object sender, EventArgs e)
        {
            int index = cbxCanton.SelectedIndex;
            if (index > -1)
            {
                if (!lbxCanton.Items.Contains(cbxCanton.SelectedItem))
                {
                    lbxCanton.Items.Add(cbxCanton.SelectedItem);

                    if (dtoConsultaDinamica.Cantones == null)
                    {
                        dtoConsultaDinamica.Cantones = new List<ResultadoTablas>();
                    }
                    dtoConsultaDinamica.Cantones.Add((ResultadoTablas)cantones.Resultados.ElementAt(index));

                    cargarDistritos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cantón");
            }
        }

        private void btnQuitarCanton_Click(object sender, EventArgs e)
        {
            if(lbxCanton.SelectedIndex > -1)
            {
                string nombreCanton = lbxCanton.SelectedItem.ToString();
                lbxCanton.Items.Remove(lbxCanton.SelectedItem);

                for (int i = 0; i < dtoConsultaDinamica.Cantones.Count; i++)
                {
                    if (dtoConsultaDinamica.Cantones.ElementAt(i).Nombre.Equals(nombreCanton))
                    {
                        dtoConsultaDinamica.Cantones.RemoveAt(i);
                        break;
                    }
                }

                cargarDistritos();
            }
        }

        private void btnAgregarDistrito_Click(object sender, EventArgs e)
        {
            int index = cbxDistrito.SelectedIndex;
            if (index > -1)
            {
                if (!lbxDistrito.Items.Contains(cbxDistrito.SelectedItem))
                {
                    lbxDistrito.Items.Add(cbxDistrito.SelectedItem);

                    if (dtoConsultaDinamica.Distritos == null)
                    {
                        dtoConsultaDinamica.Distritos = new List<ResultadoTablas>();
                    }
                    dtoConsultaDinamica.Distritos.Add((ResultadoTablas)distritos.Resultados.ElementAt(index));
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un distrito");
            }
        }

        private void btnQuitarDistrito_Click(object sender, EventArgs e)
        {
            if(lbxDistrito.SelectedIndex > -1)
            {
                string nombreDistrito = lbxDistrito.SelectedItem.ToString();
                lbxDistrito.Items.Remove(lbxDistrito.SelectedItem);

                for (int i = 0; i < dtoConsultaDinamica.Distritos.Count; i++)
                {
                    if (dtoConsultaDinamica.Distritos.ElementAt(i).Nombre.Equals(nombreDistrito))
                    {
                        dtoConsultaDinamica.Distritos.RemoveAt(i);
                        break;
                    }
                }
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!lblEdadQuinquenal.Text.Equals(""))
            {
                dtoConsultaDinamica.EdadQuinquenal = lblEdadQuinquenal.Text;
            }

            int index = cbxAfectado.SelectedIndex;
            if (index > -1)
            {
                dtoConsultaDinamica.TipoAfectado = (ResultadoTablas)tiposAfectado.Resultados.ElementAt(index);
            }

            if (cbxSexo.SelectedIndex > -1)
            {
                dtoConsultaDinamica.Sexo = cbxSexo.SelectedItem.ToString();
            }

            index = cbxLesion.SelectedIndex;
            if (index > -1)
            {
                dtoConsultaDinamica.TipoLesion = (ResultadoTablas)tiposLesion.Resultados.ElementAt(index);
            }

            dtoConsultaDinamica.Annos = new List<int>();
            if (chk2012.Checked) { dtoConsultaDinamica.Annos.Add(2012); }
            if (chk2013.Checked) { dtoConsultaDinamica.Annos.Add(2013); }
            if (chk2014.Checked) { dtoConsultaDinamica.Annos.Add(2014); }


            //string where = controlador.generarConsulta(dtoConsultaDinamica);
            //MessageBox.Show(where);

            DTO dto = controlador.consultarDinamica(dtoConsultaDinamica);
            string msj = "";
            ResultadoConsultaDinamica obs;
            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoConsultaDinamica)iter.next();
                msj += obs.Provincia;
                if(obs.Canton != null && !obs.Canton.Equals(""))
                {
                    msj += " " + obs.Canton;
                }
                if (obs.Distrito != null && !obs.Distrito.Equals(""))
                {
                    msj += " " + obs.Distrito;
                }
                msj += " " + obs.Latitud + " " + obs.Longitud + " " + obs.Cantidad + "\n"; 
            }
            MessageBox.Show(msj);

        }

        
    }
}
