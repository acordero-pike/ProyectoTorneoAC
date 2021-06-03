using System.Windows.Forms;
using AdminitracionDeTorneosP.Model;
using AdminitracionDeTorneosP.Database;
using System;
using System.Collections.Generic;

namespace AdminitracionDeTorneosP.View
{
    public partial class ComenzarPartido : Form
    { public EQUIPO_TORNEODB context = new EQUIPO_TORNEODB();
        public AdministraciónDeJornadasDB jornadaContext = new AdministraciónDeJornadasDB();
        public TorneoDB TorneoContext = new TorneoDB();
        public ComenzarPartido()
        {
            InitializeComponent();
            PartidoContext.Get_Torneos(cmbTorneos);
        }

        public PartidoDB PartidoContext = new PartidoDB();

        public int accion = 1;
       
        private void button1_Click(object sender, EventArgs e)
        {
           if (cmbTorneos.SelectedIndex<0)
            {
                MessageBox.Show("Seleccione un valor del Combo Box Por favor ");
            }
            else
            {
                string[] ssd = cmbTorneos.SelectedItem.ToString().Split('-');
              if (TorneoContext.GetTorneo(Convert.ToInt32(ssd[0])).Proceso == false)
                {
                    if (context.GetEquiposEnTorneo(Convert.ToInt32(ssd[0])).Count > 1)

                    {
                        string Torneo = Convert.ToString(cmbTorneos.SelectedItem);
                        string[] TorneoArray = Torneo.Split('-');
                        //Id de torneo almacenado en la posicion 0

                        int id_torneo = Convert.ToInt32(TorneoArray[0]);

                        List<EQUIPO_TORNEO> listas_eq = PartidoContext.encuentros(id_torneo);
                        foreach (EQUIPO_TORNEO i in listas_eq)
                        {
                            foreach (EQUIPO_TORNEO j in listas_eq)
                            {
                                if (i == j)
                                {

                                }
                                else if (i != j)
                                {

                                    Partidos partidos = new Partidos();
                                    partidos.Id_Torneo = id_torneo;
                                    partidos.Id_EquipoLocal = i.Id_Equipo;
                                    partidos.Id_EquipoVisita = j.Id_Equipo;
                                    PartidoContext.GuardarJornadas(partidos);

                                }
                            }
                        }
                        MessageBox.Show("Lista de partidos guardada ");
                        PartidoContext.UpdateTorneo(Convert.ToInt32(id_torneo));
                    }
                    else
                    {
                        MessageBox.Show("El Torneo no cuenta con equipos necesarios para crearse");
                    }
                }
                else
                {
                    MessageBox.Show("Este Torneo ya cuenta con Jornadas creadas");
                   
                }
            }
        }
    }
}
