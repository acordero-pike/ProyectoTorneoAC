using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;



namespace AdminitracionDeTorneosP.View
{

    public partial class Reporte_Jugadores1 : Form
    {
         Reporte_Jugadores_BD JugadoressContext = new Reporte_Jugadores_BD();

        public Reporte_Jugadores1()
        {
            InitializeComponent();
            MostrarJugadores();
        }
        public void MostrarJugadores()
        {
            Listajugadores.DataSource = JugadoressContext.Mostrar_Jugadores();
        }
            
        private void Reporte_Jugadores1_Load(object sender, EventArgs e)
        {

        }
    }
}
