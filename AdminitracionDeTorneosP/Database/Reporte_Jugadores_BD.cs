using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminitracionDeTorneosP.Model;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AdminitracionDeTorneosP.Database
{
    class Reporte_Jugadores_BD
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;";



        public List<Reporte_Jugadores> Mostrar_Jugadores()
        {
            List<Reporte_Jugadores> Horarioss = new List<Reporte_Jugadores>();
            string query = "Exec BG_Reporte_Jugadores ";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {

                SqlCommand sql = new SqlCommand(query, conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Reporte_Jugadores ContenidoHorario = new Reporte_Jugadores();
                        ContenidoHorario.Identificacion = reader.GetInt64(0);
                        ContenidoHorario.Nombres = reader.GetString(1);
                        ContenidoHorario.Apellidos = reader.GetString(2);
                        ContenidoHorario.Fecha_Nac = reader.GetDateTime(3);
                        ContenidoHorario.Direccion = reader.GetString(4);
                        ContenidoHorario.Nacionalidad = reader.GetString(5);
                        ContenidoHorario.Correo = reader.GetString(6);
                        ContenidoHorario.Telefono = reader.GetString(7);
                     



                        Horarioss.Add(ContenidoHorario);
                    }
                    reader.Close();
                    conexion.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la base de datos" + ex.Message);
                }
            }
            return Horarioss;
        }
    }
}
