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

            graf2012.Series[0].Name = "2012";
            graf2013.Series[0].Name = "2013";
            graf2014.Series[0].Name = "2014";
        }

        private void cbxIndicador_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxIndicadorEspecifico.Text = "";

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
            if(cbxIndicador.SelectedIndex == -1)
            {
                return;
            }

            if (cbxIndicador.SelectedItem.Equals("Tipo de Afectado"))
            {
                //redirigirConsulta("Tipo de Afectado");
                procesarDatos("Tipo de Afectado");
            }
            else if (cbxIndicador.SelectedItem.Equals("Sexo"))
            {
                //redirigirConsulta("Sexo");
                procesarDatos("Sexo");
                //procesarGrafico("Sexo");
            }
            else if (cbxIndicador.SelectedItem.Equals("Tipo de Lesion"))
            {
                //redirigirConsulta("Tipo de Lesion");
                procesarDatos("Tipo de Lesion");
            }
            else if (cbxIndicador.SelectedItem.Equals("Edad quinquenal"))
            {
                //redirigirConsulta("Edad quinquenal");
                procesarDatos("Edad quinquenal");
            }
            else {
                MessageBox.Show("Seleccione un indicador");
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

        private void procesarDatos(string indicador)
        {
            DTO dto = controlador.consultarIndicador(indicador);
            Dictionary<string, int> datos;
            string indicadorEspecifico = "";

            if(cbxIndicadorEspecifico.SelectedIndex != -1)
            {
                indicadorEspecifico = cbxIndicadorEspecifico.SelectedItem.ToString();
            }

            Boolean isEdadQuinquenal = cbxIndicador.SelectedItem.ToString().Equals("Edad quinquenal");

            datos = getDatosGenerales(dto.Resultados);
            if (isEdadQuinquenal)
                datos = ordenarEdadQuinquenal(datos);
            grafGeneral.Series[0].Points.DataBindXY(datos.Keys, datos.Values);

            //si no ha seleccionado un tipo específico
            if(cbxIndicadorEspecifico.SelectedIndex == -1 || indicadorEspecifico.Equals(""))
            {
                

                datos = getDatosAnno(dto.Resultados, 2012);
                if (isEdadQuinquenal)
                    datos = ordenarEdadQuinquenal(datos);
                graf2012.Series[0].Name = "2012";
                graf2012.Series[0].Points.DataBindXY(datos.Keys, datos.Values);


                datos = getDatosAnno(dto.Resultados, 2013);
                if (isEdadQuinquenal)
                    datos = ordenarEdadQuinquenal(datos);
                graf2013.Series[0].Name = "2013";
                graf2013.Series[0].Points.DataBindXY(datos.Keys, datos.Values);


                datos = getDatosAnno(dto.Resultados, 2014);
                if (isEdadQuinquenal)
                    datos = ordenarEdadQuinquenal(datos);
                graf2014.Series[0].Name = "2014";
                graf2014.Series[0].Points.DataBindXY(datos.Keys, datos.Values);
            }
            //si sí eligen un tipo específico
            else
            {
                datos = getDatosMes(dto.Resultados, 2012, indicadorEspecifico);
                graf2012.Series[0].Name = indicadorEspecifico;
                graf2012.Series[0].Points.DataBindXY(datos.Keys, datos.Values);

                datos = getDatosMes(dto.Resultados, 2013, indicadorEspecifico);
                graf2013.Series[0].Name = indicadorEspecifico;
                graf2013.Series[0].Points.DataBindXY(datos.Keys, datos.Values);

                datos = getDatosMes(dto.Resultados, 2014, indicadorEspecifico);
                graf2014.Series[0].Name = indicadorEspecifico;
                graf2014.Series[0].Points.DataBindXY(datos.Keys, datos.Values);
            }
        }


        //para el primer gráfico
        private Dictionary<string, int> getDatosGenerales(ResultadosConsulta consulta)
        {
            Dictionary<string, int> datos = new Dictionary<string, int>();
            ResultadoConsultaIndicador obs;

            for (Iterator iter = consulta.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoConsultaIndicador)iter.next();

                if (datos.ContainsKey(obs.nombre))
                    datos[obs.nombre] += obs.cantidad;
                else
                    datos.Add(obs.nombre, obs.cantidad);
            }

            return datos;
        }

        //para los otros graficos, cuando el indicador es general
        private Dictionary<string, int> getDatosAnno(ResultadosConsulta consulta, int anno)
        {
            Dictionary<string, int> datos = new Dictionary<string, int>();
            ResultadoConsultaIndicador obs;

            for (Iterator iter = consulta.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoConsultaIndicador)iter.next();

                if (obs.anno == anno)
                {
                    if (datos.ContainsKey(obs.nombre))
                        datos[obs.nombre] += obs.cantidad;
                    else
                        datos.Add(obs.nombre, obs.cantidad);
                }
            }

            return datos;
        }

        //para los otros gráficos, cuando el indicador es específico
        private Dictionary<string, int> getDatosMes(ResultadosConsulta consulta, int anno, string indEspecifico)
        {
            Dictionary<string, int> datos = new Dictionary<string, int>();
            ResultadoConsultaIndicador obs;

            for (Iterator iter = consulta.getIterador(); iter.hasNext();)
            {
                obs = (ResultadoConsultaIndicador)iter.next();

                if (obs.anno == anno && obs.nombre.Equals(indEspecifico))
                {
                    if (datos.ContainsKey(obs.mes))
                        datos[obs.mes] += obs.cantidad;
                    else
                        datos.Add(obs.mes, obs.cantidad);
                }
            }

            return ordenarPorMes(datos);
        }

        //Ordena los meses, por orden de mes xD
        private Dictionary<string, int> ordenarPorMes(Dictionary<string, int> meses)
        {
            Dictionary<string, int> datos = new Dictionary<string, int>();

            for(int i=0; i<12; i++)
            {
                foreach(KeyValuePair<string, int> nodo in meses)
                {
                    switch (i)
                    {
                        case 0:
                            if (nodo.Key.Equals("Enero"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 1:
                            if (nodo.Key.Equals("Febrero"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 2:
                            if (nodo.Key.Equals("Marzo"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 3:
                            if (nodo.Key.Equals("Abril"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 4:
                            if (nodo.Key.Equals("Mayo"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 5:
                            if (nodo.Key.Equals("Junio"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 6:
                            if (nodo.Key.Equals("Julio"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 7:
                            if (nodo.Key.Equals("Agosto"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 8:
                            if (nodo.Key.Equals("Setiembre"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 9:
                            if (nodo.Key.Equals("Octubre"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 10:
                            if (nodo.Key.Equals("Noviembre"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                        case 11:
                            if (nodo.Key.Equals("Diciembre"))
                                datos.Add(nodo.Key, nodo.Value);
                            break;
                    }
                }
            }

            return datos;
        }

        //Ordena las edades quinquenales por rango de edad
        private Dictionary<string, int> ordenarEdadQuinquenal(Dictionary<string, int> edades)
        {
            Dictionary<string, int> datos = new Dictionary<string, int>();
            string[] campos;
            
            //se va avanzando por quiquena
            for(int i=0; i<=75; i += 5)
            {
                foreach (KeyValuePair<string, int> edad in edades)
                {
                    if (!edad.Key.Equals("Desconocida"))
                    {
                        campos = edad.Key.Split(' ');
                        int menor;

                        try //intenta sacar las edades normales
                        {
                            menor = Int32.Parse(campos[1]);
                        }
                        catch (FormatException e) //si falla es porque encontró la de 75 (tiene formato distinto)
                        {
                            menor = Int32.Parse(campos[2]);
                        }

                        if (menor == i)
                        {
                            datos.Add(edad.Key, edad.Value);
                            break;
                        }
                    }
                }
            }
            //Las desconocidas se agregan al final
            foreach (KeyValuePair<string, int> edad in edades)
            {
                if (edad.Key.Equals("Desconocida"))
                {
                    datos.Add(edad.Key, edad.Value);
                }
            }
            return datos;
        }

    }
}
