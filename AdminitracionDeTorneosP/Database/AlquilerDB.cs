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

    public class AlquilerDB
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL

        public void Add(Alquilermodel alq)
        {
            string query = "  exec  insalquiler @id,@pr,@fe,@hinicio,@ffinal,@dpi,@name,@app,@tel,@corr";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@id", alq.ID_Cancha);
                command.Parameters.AddWithValue("@pr", alq.Precio_por_hora);
                command.Parameters.AddWithValue("@fe", alq.Fecha_Alquiler);
                command.Parameters.AddWithValue("@hinicio", alq.hora_inicio);
                command.Parameters.AddWithValue("@ffinal", alq.hora_final);
                command.Parameters.AddWithValue("@dpi", alq.DPI);
                command.Parameters.AddWithValue("@name", alq.Nombres);
                command.Parameters.AddWithValue("@app", alq.Apellidos);
                command.Parameters.AddWithValue("@tel", alq.Telefono);
                command.Parameters.AddWithValue("@corr", alq.Correo);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Alquiler Registrado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Guardar  " + error.Message, "ERROR");
                }
            }
        }


        public void upd(Alquilermodel alq)
        {
            string query = "  exec  updtalqui @iden, @id,@pr,@fe,@hinicio,@ffinal,@dpi,@name,@app,@tel,@corr";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@iden", alq.ID);
                command.Parameters.AddWithValue("@id", alq.ID_Cancha);
                command.Parameters.AddWithValue("@pr", alq.Precio_por_hora);
                command.Parameters.AddWithValue("@fe", alq.Fecha_Alquiler);
                command.Parameters.AddWithValue("@hinicio", alq.hora_inicio);
                command.Parameters.AddWithValue("@ffinal", alq.hora_final);
                command.Parameters.AddWithValue("@dpi", alq.DPI);
                command.Parameters.AddWithValue("@name", alq.Nombres);
                command.Parameters.AddWithValue("@app", alq.Apellidos);
                command.Parameters.AddWithValue("@tel", alq.Telefono);
                command.Parameters.AddWithValue("@corr", alq.Correo);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Alquiler Actualizado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Acutalizar  " + error.Message, "ERROR");
                }
            }
        }
        public List<Alquilermodel> Getalquiler()
        {
            List<Alquilermodel> alq = new List<Alquilermodel>();
            string query = " exec listaalqui";
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
                        Alquilermodel arq = new Alquilermodel();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        arq.ID = reader.GetInt32(0);
                        arq.ID_Cancha = reader.GetInt32(1);
                        arq.Precio_por_hora = reader.GetDouble(10);
                        arq.Fecha_Alquiler = reader.GetDateTime(2);
                        arq.hora_inicio = reader.GetDateTime(3);
                        arq.hora_final = reader.GetDateTime(4);
                        arq.DPI = reader.GetInt64(5);
                        arq.Nombres = reader.GetString(6);
                        arq.Apellidos = reader.GetString(7);
                        arq.Telefono = reader.GetInt32(8);
                        arq.Correo = reader.GetString(9);
                        arq.Sub_Total_Cancha = reader.GetDouble(11);
                        arq.Sub_Total_Arbitraje = reader.GetDouble(12);
                        arq.Total_Alquiler = reader.GetDouble(13);

                        alq.Add(arq);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return alq;
        }

        public Alquilermodel Getalquilerid(int? id)
        {
            Alquilermodel arq = new Alquilermodel();
            string query = " exec datoalqui @id";
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

                        //Obtiene los datos de la tabla y se guardan en un lista
                        arq.ID = reader.GetInt32(0);
                        arq.ID_Cancha = reader.GetInt32(1);
                        arq.Precio_por_hora = reader.GetDouble(10);
                        arq.Fecha_Alquiler = reader.GetDateTime(2);
                        arq.hora_inicio = reader.GetDateTime(3);
                        arq.hora_final = reader.GetDateTime(4);
                        arq.DPI = reader.GetInt64(5);
                        arq.Nombres = reader.GetString(6);
                        arq.Apellidos = reader.GetString(7);
                        arq.Telefono = reader.GetInt32(8);
                        arq.Correo = reader.GetString(9);


                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return arq;
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

        public List<disponible> getocupadas(string fecha)
        {
            List<disponible> cancha = new List<disponible>();
            string query = " exec mostrarocupadas @fecha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@fecha", fecha);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        disponible d = new disponible();
                        d.nombre = reader.GetString(0);
                        d.fecha = reader.GetDateTime(1);
                        d.HInicio = reader.GetTimeSpan(2);
                        d.HFin = reader.GetTimeSpan(3);
                        cancha.Add(d);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return cancha;
        }
        public List<disponible> getocupadasal(string fecha)
        {
            List<disponible> cancha = new List<disponible>();
            string query = " exec mostrarocupadasalq @fecha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@fecha", fecha);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        disponible d = new disponible();
                        d.nombre = reader.GetString(0);
                        d.fecha = reader.GetDateTime(1);
                        d.HInicio = reader.GetDateTime(2).TimeOfDay;
                        d.HFin = reader.GetDateTime(3).TimeOfDay;
                        cancha.Add(d);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return cancha;
        }

        public void delete(int? id)
        {
            string query = "Exec dtlalqui @id";
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

        public List<string> names(string date , TimeSpan ti , TimeSpan tf)
        {
            List<string> nombres = new List<string>();
            string query = "exec   arbitroocupado @date , @in ,@fin";
             
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@date",date );
                sql.Parameters.AddWithValue("@in", ti);
                sql.Parameters.AddWithValue("@fin", tf);
                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    
                    string a = reader["HoraInicio"].ToString();
                    string b = reader["HoraFinal"].ToString();
                    if (reader["HoraInicio"].ToString() == "00:00:00" && reader["HoraFinal"].ToString() == "00:00:00")
                    {
                        nombres.Add(reader["Nombres"].ToString());
                    }
                }
                connection.Close();
            }
            return nombres;
        }

        public List<string> namesal(string date, DateTime ti, DateTime tf)
        {
            List<string> nombres = new List<string>();
            string query = "exec   arbitroocupadoal  @date , @in ,@fin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@date", date);
                sql.Parameters.AddWithValue("@in", ti);
                sql.Parameters.AddWithValue("@fin", tf);
                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    TimeSpan ins = reader.GetDateTime(1).TimeOfDay;
                    TimeSpan fin = reader.GetDateTime(2).TimeOfDay;
                    if (ins.ToString() == "00:00:00" && fin.ToString() == "00:00:00")
                    {
                        nombres.Add(reader["Nombres"].ToString());
                    }
                }
                connection.Close();
            }
            return nombres;
        }
    }

}
