using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Reporte_Tabla_Visitante abrirForm = new Reporte_Tabla_Visitante();

            abrirForm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VISTA_PORTERO_MENOS_VENCIDO abrirForm = new VISTA_PORTERO_MENOS_VENCIDO();

            abrirForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VISTA_REPORTE_LOCAL abrirForm = new VISTA_REPORTE_LOCAL();

            abrirForm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GOLEADOR abrirForm = new GOLEADOR();

            abrirForm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TARJETAS abrirForm = new TARJETAS();

            abrirForm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            reportePlanillaArbitro abrirForm = new reportePlanillaArbitro();

            abrirForm.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tiempoUsoCanchas abrirForm = new tiempoUsoCanchas();

            abrirForm.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            reporteJuegosAfectados abrirForm = new reporteJuegosAfectados();

            abrirForm.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ReporteEstadisticasDelEquipo abrirForm = new ReporteEstadisticasDelEquipo();

            abrirForm.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Reporte_Utilidades abrirForm = new Reporte_Utilidades();

            abrirForm.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Reporte_punteo_general abrirForm = new Reporte_punteo_general();

            abrirForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disponibilidad_Cancha abrirForm = new disponibilidad_Cancha();

            abrirForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitacora gan = new Bitacora();
            gan.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngresoAlquileres ing = new IngresoAlquileres();
            ing.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GananciasArbitrajealquiler gan = new GananciasArbitrajealquiler();
            gan.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteCanchaDisponible ds = new ReporteCanchaDisponible();
            ds.Show();
        }
 
 
        private void button7_Click(object sender, EventArgs e)
        {
            reportecanchasgit reportecanchasgit = new reportecanchasgit();
            reportecanchasgit.Show();
 }
 
        private void reporteArbitrosGit_Click(object sender, EventArgs e)
        {
            listadoArbitrosGit listadoArbitrosGit = new listadoArbitrosGit();
            listadoArbitrosGit.Show();
 
 
        private void button7_Click(object sender, EventArgs e)
        {
            ReporteEquipo re = new ReporteEquipo();
            re.Show();
 
 
 
        }
            private void button7_Click(object sender, EventArgs e)
            {
                ReporteEquipo re = new ReporteEquipo();
                re.Show();

            }

        private void ReporteEquipo_Click(object sender, EventArgs e)
        {
            ReporteEquipo re = new ReporteEquipo();
            re.Show();
        }
    }
}
