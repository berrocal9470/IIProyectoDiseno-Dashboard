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
using Dashboard.Negocio;
using Dashboard.Modelo;

namespace Dashboard.Vista
{
    public partial class ctrlIndicador : UserControl
    {
        private Controlador controlador = new Controlador();
        private ResultadosConsulta tiposAfectado;
        private ResultadosConsulta tiposLesion;
        private ResultadosConsulta edadQuinquenal;

        public ctrlIndicador()
        {
            InitializeComponent();
        }

        private void cargarAfectados()
        {
            DTO dto = controlador.consultarTabla("Roles");
            tiposAfectado = dto.Resultados;

            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxIndicadorEspecifico.Items.Add(obs.Nombre);
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
                cbxIndicadorEspecifico.Items.Add(obs.Nombre);
            }

        }

        private void cargarEdadQ()
        {
            DTO dto = controlador.consultarTabla("Quinquenal");
            edadQuinquenal = dto.Resultados;

            ResultadoTablas obs;

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoTablas)iter.next();
                cbxIndicadorEspecifico.Items.Add(obs.Nombre);
            }

        }


        private void ctrlIndicador_Load(object sender, EventArgs e)
        {
            cbxIndicador.Items.Add("Tipo de Afectado");
            cbxIndicador.Items.Add("Sexo");
            cbxIndicador.Items.Add("Tipo de Lesion");
            cbxIndicador.Items.Add("Edad quinquenal");


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

        private void cbxIndicador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIndicador.SelectedItem.Equals("Tipo de Afectado")){
                cbxIndicadorEspecifico.Items.Clear();
                cbxIndicadorEspecifico.Items.Add(""); 
                cargarAfectados();
            }
            else if (cbxIndicador.SelectedItem.Equals("Sexo"))
            {
                cbxIndicadorEspecifico.Items.Clear();
                cbxIndicadorEspecifico.Items.Add("");
                cbxIndicadorEspecifico.Items.Add("Hombre");
                cbxIndicadorEspecifico.Items.Add("Mujer");
                cbxIndicadorEspecifico.Items.Add("Desconocido");
            }
            else if (cbxIndicador.SelectedItem.Equals("Tipo de Lesion"))
            {      
                cbxIndicadorEspecifico.Items.Clear();
                cbxIndicadorEspecifico.Items.Add("");
                cargarLesiones();
            }
            else if (cbxIndicador.SelectedItem.Equals("Edad quinquenal"))
            {
                cbxIndicadorEspecifico.Items.Clear();
                cbxIndicadorEspecifico.Items.Add("");
                cargarEdadQ();
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbxIndicador.SelectedItem.Equals("Tipo de Afectado"))
            {
                redirigirConsulta("Tipo de Afectado");
            }
            else if (cbxIndicador.SelectedItem.Equals("Sexo"))
            {
                redirigirConsulta("Sexo");
                procesarGrafico("Sexo");
            }
            else if (cbxIndicador.SelectedItem.Equals("Tipo de Lesion"))
            {
                redirigirConsulta("Tipo de Lesion");
            }
            else if (cbxIndicador.SelectedItem.Equals("Edad quinquenal"))
            {
                redirigirConsulta("Edad quinquenal");
            }
            else {
                MessageBox.Show("Seleccione un indicador plox");
            }
        }

        private void redirigirConsulta(string indicador) {
            DTO dto = controlador.consultarIndicador(indicador);
            string msj = "";
            ResultadoConsultaIndicador obs;
            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoConsultaIndicador)iter.next();

                msj += obs.cantidad + "  ";
                msj += obs.nombre + "  ";
                msj += obs.mes + "  ";
                msj += obs.anno + "\n";
            }
            
            MessageBox.Show(msj);
        }



        //mas alambrado imposible c: 
        private void procesarGrafico(string indicador)
        {
            DTO dto = controlador.consultarIndicador(indicador);
            ResultadoConsultaIndicador obs;

            Dictionary<string, int> hombres2012 = new Dictionary<string, int>();
            Dictionary<int, int> mujeres2012 = new Dictionary<int, int>();
            Dictionary<int, int> desconocido2012 = new Dictionary<int, int>();

            Dictionary<int, int> hombres2013 = new Dictionary<int, int>();
            Dictionary<int, int> mujeres2013 = new Dictionary<int, int>();
            Dictionary<int, int> desconocido2013 = new Dictionary<int, int>();

            Dictionary<int, int> hombres2014 = new Dictionary<int, int>();
            Dictionary<int, int> mujeres2014 = new Dictionary<int, int>();
            Dictionary<int, int> desconocido2014 = new Dictionary<int, int>();

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoConsultaIndicador)iter.next();

                //Conteo de hombres por año
                if (obs.nombre.Equals("Hombre") && obs.anno == 2012)
                {
                    if (hombres2012.ContainsKey(obs.mes))
                        hombres2012[obs.mes] += obs.cantidad;
                    else
                        hombres2012.Add(obs.mes, obs.cantidad);
                }//ggg

                else if (obs.nombre.Equals("Hombre") && obs.anno == 2013)
                {
                    if (hombres2013.ContainsKey(obs.anno))
                        hombres2013[obs.anno] += obs.cantidad;
                    else
                        hombres2013.Add(obs.anno, obs.cantidad);
                }
                else if (obs.nombre.Equals("Hombre") && obs.anno == 2014)
                {
                    if (hombres2014.ContainsKey(obs.anno))
                        hombres2014[obs.anno] += obs.cantidad;
                    else
                        hombres2014.Add(obs.anno, obs.cantidad);
                }

                //Conteo de mujeres por año
                else if (obs.nombre.Equals("Mujer") && obs.anno == 2012)
                {
                    if (mujeres2012.ContainsKey(obs.anno))
                        mujeres2012[obs.anno] += obs.cantidad;
                    else
                        mujeres2012.Add(obs.anno, obs.cantidad);
                }
                else if (obs.nombre.Equals("Mujer") && obs.anno == 2013)
                {
                    if (mujeres2013.ContainsKey(obs.anno))
                        mujeres2013[obs.anno] += obs.cantidad;
                    else
                        mujeres2013.Add(obs.anno, obs.cantidad);
                }
                else if (obs.nombre.Equals("Mujer") && obs.anno == 2014)
                {
                    if (mujeres2014.ContainsKey(obs.anno))
                        mujeres2014[obs.anno] += obs.cantidad;
                    else
                        mujeres2014.Add(obs.anno, obs.cantidad);
                }

                //Conteo de desconocido por año
                else if (obs.nombre.Equals("Desconocido") && obs.anno == 2012)
                {
                    if (desconocido2012.ContainsKey(obs.anno))
                        desconocido2012[obs.anno] += obs.cantidad;
                    else
                        desconocido2012.Add(obs.anno, obs.cantidad);
                }
                else if (obs.nombre.Equals("Desconocido") && obs.anno == 2013)
                {
                    if (desconocido2013.ContainsKey(obs.anno))
                        desconocido2013[obs.anno] += obs.cantidad;
                    else
                        desconocido2013.Add(obs.anno, obs.cantidad);
                }
                else if (obs.nombre.Equals("Desconocido") && obs.anno == 2014)
                {
                    if (desconocido2014.ContainsKey(obs.anno))
                        desconocido2014[obs.anno] += obs.cantidad;
                    else
                        desconocido2014.Add(obs.anno, obs.cantidad);
                }

            }

            ArrayList etiquetas = new ArrayList();
            ArrayList valores = new ArrayList();

            ArrayList etiquetas2 = new ArrayList();
            ArrayList valores2 = new ArrayList();

            ArrayList etiquetas3 = new ArrayList();
            ArrayList valores3 = new ArrayList();
            int total2012H = 0;

            for (int i = 0; i < hombres2012.Count; i++) {
                total2012H += hombres2012.ElementAt(i).Value;

                etiquetas2.Add(hombres2012.ElementAt(i).Key);
                valores2.Add(hombres2012.ElementAt(i).Value);
            }

            etiquetas.Add("Hombres 2012");
            etiquetas.Add("Hombres 2013");
            etiquetas.Add("Hombres 2014");
            etiquetas.Add("Mujeres 2012");
            etiquetas.Add("Mujeres 2013");
            etiquetas.Add("Mujeres 2014");
            etiquetas.Add("Desconocido 2012");
            etiquetas.Add("Desconocido 2013");
            etiquetas.Add("Desconocido 2014");

            valores.Add(total2012H);
            valores.Add(hombres2013[2013]);
            valores.Add(hombres2014[2014]);

            valores.Add(mujeres2012[2012]);
            valores.Add(mujeres2013[2013]);
            valores.Add(mujeres2014[2014]);

            valores.Add(desconocido2012[2012]);
            valores.Add(desconocido2013[2013]);
            valores.Add(desconocido2014[2014]);

            grafGeneral.Series[0].Points.DataBindXY(etiquetas, valores);

            graf2014.Series[0].Points.DataBindXY(etiquetas2, valores2);
        }

        //ordena el Dictionary por Keys para que se muestre bien en el gráfico
        private SortedDictionary<int, int> ordenarDictionary(Dictionary<int, int> dict)
        {
            var sdict = new SortedDictionary<int, int>();
            foreach (KeyValuePair<int, int> k in dict.OrderBy(key => key.Value))
                sdict.Add(k.Key, k.Value);
            return sdict;
        }
        

        
        //intento de reducir el codigo a medio palo :v
        /*private void procesarGrafico2(string indicador)
        {
            DTO dto = controlador.consultarIndicador(indicador);
            ResultadoConsultaIndicador obs;

            Dictionary<int, int> dicc = new Dictionary<int, int>();

            for (Iterator iter = dto.Resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoConsultaIndicador)iter.next();
                int key = obs.anno; //llave año
                    if (dicc.ContainsKey(key))
                        dicc[obs.anno] += obs.cantidad;
                    else
                        dicc.Add(obs.anno, obs.cantidad);
            }

            ArrayList etiquetas = new ArrayList();
            ArrayList valores = new ArrayList();

            int total2012H = 0;

            for (int i = 0; i < dicc.Count; i++)
            {
                total2012H += hombres2012.ElementAt(i).Value;

                etiquetas2.Add(hombres2012.ElementAt(i).Key);
                valores2.Add(hombres2012.ElementAt(i).Value);
            }
            for (int i = 0; i < mujeres2012.Count; i++)
            {
                total2012M += mujeres2012.ElementAt(i).Value;

                etiquetas3.Add(mujeres2012.ElementAt(i).Key);
                valores3.Add(mujeres2012.ElementAt(i).Value);
            }

            grafGeneral.Series[0].Points.DataBindXY(etiquetas, valores);
        }*/

    }
}
