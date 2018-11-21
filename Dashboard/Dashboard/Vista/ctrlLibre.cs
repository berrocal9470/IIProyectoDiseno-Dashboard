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
    public partial class ctrlLibre : UserControl
    {
        private Controlador Controlador { get; set; }

        public ctrlLibre()
        {
            InitializeComponent();
            Controlador = new Controlador();

            cbxSexo.Items.Add("Hombre");
            cbxSexo.Items.Add("Mujer");
            cbxSexo.Items.Add("Desconocido");
            cbxSexo.Items.Add("Todos");
        }

        private void ctrlLibre_Load(object sender, EventArgs e)
        {
            grafGeneral.Series.Clear();
            grafGeneral.Series.Add("Hombre");
            grafGeneral.Series.Add("Mujer");
            grafGeneral.Series.Add("Desconocido");
        }        
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cbxSexo.Text = "";
            edadMenor.Value = 0;
            edadMayor.Value = 110;

            Controlador.consultaObserver();
            notify(null, null);
        }

        public void notify(object observado, string rol)
        {
            ResultadosConsulta resultados = (ResultadosConsulta)Controlador.update(observado, rol);
            procesarGrafico(resultados);
        }

        private void procesarGrafico(ResultadosConsulta resultados)
        {
            ResultadoObserver obs;
            Dictionary<int, int> edadesHombre = new Dictionary<int, int>();
            Dictionary<int, int> edadesMujer = new Dictionary<int, int>();
            Dictionary<int, int> edadesDesconocido = new Dictionary<int, int>();

            for (Iterator iter = resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoObserver)iter.next();
                if (obs.Sexo.Equals("Hombre"))
                {
                    if (edadesHombre.ContainsKey(obs.Edad))
                        edadesHombre[obs.Edad] += 1;
                    else
                        edadesHombre.Add(obs.Edad, 1);
                    
                }
                else if (obs.Sexo.Equals("Mujer"))
                {
                    if (edadesMujer.ContainsKey(obs.Edad))
                        edadesMujer[obs.Edad] += 1;
                    else
                        edadesMujer.Add(obs.Edad, 1);
                }
                else //Desconocido
                {
                    if (edadesDesconocido.ContainsKey(obs.Edad))
                        edadesDesconocido[obs.Edad] += 1;
                    else
                        edadesDesconocido.Add(obs.Edad, 1);
                }
            }

            grafGeneral.Series.Clear();
            grafGeneral.Series.Add("Hombre");
            grafGeneral.Series.Add("Mujer");
            grafGeneral.Series.Add("Desconocido");
            
            grafGeneral.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            grafGeneral.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            grafGeneral.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            grafGeneral.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            grafGeneral.Series[1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            grafGeneral.Series[2].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

            SortedDictionary<int, int> ordenado = ordenarDictionary(edadesHombre);
            grafGeneral.Series[0].Points.DataBindXY(ordenado.Keys, ordenado.Values);
            ordenado = ordenarDictionary(edadesMujer);
            grafGeneral.Series[1].Points.DataBindXY(ordenado.Keys, ordenado.Values);
            ordenado = ordenarDictionary(edadesDesconocido);
            grafGeneral.Series[2].Points.DataBindXY(ordenado.Keys, ordenado.Values);
        }

        //ordena el Dictionary por Keys para que se muestre bien en el gráfico
        private SortedDictionary<int, int> ordenarDictionary(Dictionary<int, int> dict)
        {
            var sdict = new SortedDictionary<int, int>();
            foreach (KeyValuePair<int, int> k in dict.OrderBy(key => key.Value))
                sdict.Add(k.Key, k.Value);
            return sdict;
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            notify(cbxSexo, "Sexo");
        }

        private void edadMenor_ValueChanged(object sender, EventArgs e)
        {
            if (edadMenor.Value <= edadMayor.Value)
            {
                notify(edadMenor, "Menor");
            }
            else
            {
                MessageBox.Show("La edad inicial no puede ser mayor a la final");
                edadMenor.Value = edadMayor.Value;
            }
        }

        private void edadMayor_ValueChanged(object sender, EventArgs e)
        {
            if (edadMenor.Value <= edadMayor.Value)
            {
                notify(edadMayor, "Mayor");
            }
            else
            {
                MessageBox.Show("La edad final no puede ser menor a la inicial");
                edadMayor.Value = edadMenor.Value;
            }
        }
    }
}
