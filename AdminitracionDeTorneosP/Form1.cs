using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdminitracionDeTorneosP.View;
using AdminitracionDeTorneosP.Database;

namespace AdminitracionDeTorneosP
{
    public partial class Form1 : Form
    {

        public acciones ac = new acciones();
        public string names = "";
        public int us = 0;
        public Form1(string name, string tipe, int id)
        {
            InitializeComponent();
            label1.Text = name;
            us = id;
            names = name;
            if (tipe == "Administrador")
            {

            }
            else if (tipe == "Operador")
            {
                btnUser.Enabled = false;
                button15.Enabled = false;
                button2.Enabled = false;
                button26.Enabled = false;
                Horarios.Enabled = false;
            }
            else if (tipe == "Reporteria")
            {
                btnUser.Enabled = false;
                button15.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                button10.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button13.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button5.Enabled = false;
                    button9.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                Horarios.Enabled = false;

            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            ac.add(us, "LogOFF");
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Bienvenida());
            ac.add(us, "Reporteria");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Torneo2());
            ac.add(us, "Torneos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.MenuIncripcionEquipo());
            ac.add(us, "Inscripcion de Equipos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.MenuIncripcionJugador());
            ac.add(us, "Inscripcion Jugadores");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.CRUD_AMONESTACION());
            ac.add(us, "Crud Tarjetas");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.JornadasPartido());
            ac.add(us, "Jornadas");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.ComenzarPartido());
            ac.add(us, "crear jornadas");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.CRUD_ENTRENADOR());
            ac.add(us, "Entrenadores");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.CRUD_EQUIPO());
            ac.add(us, "Equipos");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.refereeView());
            ac.add(us, "Arbitros");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.CRUD_JUGADORES());
            ac.add(us, "Jugadores");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.vISTA_ENCUENTROS_WIN());
            ac.add(us, "Encuentros");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.VISTA_PAGOS_TARGETAS());
            ac.add(us, "Pago de Tarjetas");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.disponibilidad_Cancha());
            ac.add(us, "Disponibilidad Cancha");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Agregar_Cancha());
            ac.add(us, "Canchas");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.VISTA_REPORTE_LOCAL());
            ac.add(us, "Tabla Local");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.VISTA_PORTERO_MENOS_VENCIDO());
            ac.add(us, "Portero Menos vencido");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Reporte_Tabla_Visitante());
            ac.add(us, "Tabla Visitante");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.GOLEADOR());
            ac.add(us, "Goleador");

        }

        private void button22_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.reporteJuegosAfectados());
            ac.add(us, "Juegos Afectados");

        }

        private void button19_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.TARJETAS());
            ac.add(us, "Amonestaciones en partidos");

        }

        private void button20_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.reportePlanillaArbitro());
            ac.add(us, "Plantilla de Arbitros");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.tiempoUsoCanchas());
            ac.add(us, "Uso de Canchas");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.ReporteEstadisticasDelEquipo());
            ac.add(us, "Estadisticas del equipo");

        }

        private void button24_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Reporte_Utilidades());
            ac.add(us, "Utilidades");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Reporte_punteo_general());
            ac.add(us, "Tabla General");

        }

        private void button26_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Bienvenida());
            ac.add(us, "Reporteria");
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Alquiler());
            ac.add(us, "Alquiler de Canchas");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Usuarios());
            ac.add(us, "Usuarios");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Pronto "+ names);
            ac.add(us, "LogOFF");
            this.Hide();
            LogIn lg = new LogIn();
            lg.Show();
            
        }

        private void Horarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new View.Horarios());
            ac.add(us, "Horarios");
        }
    }
}
