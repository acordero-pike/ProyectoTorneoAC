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
    public class Arbitroalquiler
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL

        public List<Arbitrajemodel> listaarb(int id)
        {
            List<Arbitrajemodel> arb = new List<Arbitrajemodel>();
            string query = "exec verar @id ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Arbitrajemodel ar = new Arbitrajemodel();
                        ar.id = reader.GetInt32(0);
                        ar.Arbitro = reader.GetInt64(1);
                        ar.alquiler = reader.GetInt32(2);
                        ar.tiempo = reader.GetInt32(3);
                        ar.precio = reader.GetDouble(4);
                        arb.Add(ar);

                    }


                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }

            }
            return arb;
        }

        public Arbitrajemodel getar(int? id)
        {
            Arbitrajemodel ar = new Arbitrajemodel();
            string query = "exec getar @id ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {

                        ar.id = reader.GetInt32(0);
                        ar.Arbitro = reader.GetInt64(1);
                        ar.alquiler = reader.GetInt32(2);
                        ar.tiempo = reader.GetInt32(3);
                        ar.precio = reader.GetDouble(4);


                    }


                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }

            }
            return ar;
        }

        public void delete(int? id)
        {
            string query = "Exec dtlar @id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Se a eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error en eliminar " + ex.Message);
                }

            }
        }
        public void Add(Arbitrajemodel alq)
        {
            string query = "  exec  arbitroalq  @arb, @alq, @time, @pg";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@arb", alq.Arbitro);
                command.Parameters.AddWithValue("@alq", alq.alquiler);
                command.Parameters.AddWithValue("@time", alq.tiempo);
                command.Parameters.AddWithValue("@pg", alq.precio);

                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Arbitraje Registrado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Guardar  " + error.Message, "ERROR");
                }
            }
        }

        public void edtarb(Arbitrajemodel alq)

        {
            string query = "  exec  updar  @id,  @arb, @alq, @time, @pg";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@id", alq.id);
                command.Parameters.AddWithValue("@arb", alq.Arbitro);
                command.Parameters.AddWithValue("@alq", alq.alquiler);
                command.Parameters.AddWithValue("@time", alq.tiempo);
                command.Parameters.AddWithValue("@pg", alq.precio);

                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Arbitraje Registrado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Guardar  " + error.Message, "ERROR");
                }
            }
        }

       

    }

}


 



