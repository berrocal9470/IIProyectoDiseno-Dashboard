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
        private DTO dto;

        public ctrlLibre()
        {
            InitializeComponent();
            Controlador = new Controlador();

            cbxSexo.Items.Add("Hombre");
            cbxSexo.Items.Add("Mujer");
            cbxSexo.Items.Add("Desconocido");
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

        //Consulta los datos a la tabla
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dto = Controlador.consultaObserver();

            procesarGrafico(dto.Resultados);

            //MessageBox.Show(result);
        }

        public void notify()
        {

        }

        private void procesarGrafico(ResultadosConsulta resultados)
        {
            string result = "";
            ResultadoObserver obs;

            for (Iterator iter = resultados.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoObserver)iter.next();
                result += obs.Sexo + " " + obs.Edad + "\n";
            }



        }
    }
}
