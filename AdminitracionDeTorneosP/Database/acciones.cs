using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.Database
{
    public class acciones
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL

        public void add(int id, string ac )
        {

            string query = "  exec  acciones @id,@ac,@fecha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@ac", ac );
                command.Parameters.AddWithValue("@fecha", DateTime.Now );
            
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                   
                }
                catch (Exception error)
                {
                   
                }
            }
        }

    }
}
