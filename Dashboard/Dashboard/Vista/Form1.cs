using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Maximizar();

            Width = ctrlDinamica1.Width + Width - ClientSize.Width;
            Height = ctrlDinamica1.Height + Height - ClientSize.Height;

            //Acomoda los páneles que irán cambiando
            ctrlDinamica1.Visible = true;
            ctrlIndicador1.Visible = false;
            ctrlLibre1.Visible = false;

            //para centrar los user control
            pnlVistas.Anchor = AnchorStyles.None;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDinamica_Click(object sender, EventArgs e)
        {
            ctrlDinamica1.Visible = true;
            ctrlIndicador1.Visible = false;
            ctrlLibre1.Visible = false;

            pnlConsultaSeleccionada.Left = btnDinamica.Left;
        }

        private void btnIndicador_Click(object sender, EventArgs e)
        {
            ctrlDinamica1.Visible = false;
            ctrlIndicador1.Visible = true;
            ctrlLibre1.Visible = false;

            pnlConsultaSeleccionada.Left = btnIndicador.Left;
        }

        private void btnLibre_Click(object sender, EventArgs e)
        {
            ctrlDinamica1.Visible = false;
            ctrlIndicador1.Visible = false;
            ctrlLibre1.Visible = true;
            
            pnlConsultaSeleccionada.Left = btnLibre.Left;
        }

        private void Maximizar()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Maximizar();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
