using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Model;

namespace AdminitracionDeTorneosP.Database
{
    public class horarioDB
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL

        public List<Horarioview> getdias()
        {
            List<Horarioview> h = new List<Horarioview>();
            string query = " exec verh";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Horarioview hs = new Horarioview();
                        hs.Dia = reader.GetString(1);
                        hs.Apertura = reader.GetDateTime(2).TimeOfDay;
                        hs.Cierre = reader.GetDateTime(3).TimeOfDay;
                        h.Add(hs);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }



            }
            return h;
        }

        public Horario GetHorarios(string dia)
        {
            Horario a = new Horario();
            string query = "exec verdias @name";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@name", dia);
                try
                {
                    connection.Open();
                    //Ejecuta el query y lee lo q esta en la tabla
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    //Se guarda lo que esta en la tabla en el modelo
                    a.Dia = reader.GetString(1);
                    a.Apertura = reader.GetDateTime(2);
                    a.Cierre = reader.GetDateTime(3);


                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return a;
            }
        }
        public void upd(Horario h)
        {
            string query = "  exec  updhora  @dia,@ap,@cr";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@dia", h.Dia);
                command.Parameters.AddWithValue("@ap", h.Apertura);
                command.Parameters.AddWithValue("@cr", h.Cierre);
           
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Horario Actualizado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Acutalizar  " + error.Message, "ERROR");
                }
            }
        }

    }
}
