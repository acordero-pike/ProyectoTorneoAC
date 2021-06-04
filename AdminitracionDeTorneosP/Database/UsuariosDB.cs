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
    public class UsuariosDB
    {
        private string connectionString = "Server=LAPTOP-0A8H41G8;Database=PROYECTO_TORNEOS; User Id = capacitation;Password=manager;"; // Conectando a la base de datos SQL

        public void Add(Ususario us)
        {
            string query = "  exec  insertuser @dpi ,@name ,@app ,@dir,@tel,@corr,@pus,@us ,@cl";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@dpi", us.DPI);
                command.Parameters.AddWithValue("@name", us.Nombres);
                command.Parameters.AddWithValue("@app", us.Apellidos);
                command.Parameters.AddWithValue("@dir", us.Direccion);
                command.Parameters.AddWithValue("@tel", us.Telefono);
                command.Parameters.AddWithValue("@corr", us.Correo);
                command.Parameters.AddWithValue("@pus", us.puesto );
                command.Parameters.AddWithValue("@us", us.Usuario);
                command.Parameters.AddWithValue("@cl", us.Contraseña);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Usuario Registrado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Guardar  " + error.Message, "ERROR");
                }
            }
        }

        public void UPDATE(Ususario us)
        {
            string query = "  exec  updtus @id, @dpi ,@name ,@app ,@dir,@tel,@corr,@pus,@us ,@cl";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //Envia parametros al Proceso Almacenado
                command.Parameters.AddWithValue("@id", us.id);
                command.Parameters.AddWithValue("@dpi", us.DPI);
                command.Parameters.AddWithValue("@name", us.Nombres);
                command.Parameters.AddWithValue("@app", us.Apellidos);
                command.Parameters.AddWithValue("@dir", us.Direccion);
                command.Parameters.AddWithValue("@tel", us.Telefono);
                command.Parameters.AddWithValue("@corr", us.Correo);
                command.Parameters.AddWithValue("@pus", us.puesto);
                command.Parameters.AddWithValue("@us", us.Usuario);
                command.Parameters.AddWithValue("@cl", us.Contraseña);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Usuario Actualizado Correctamente");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al Guardar  " + error.Message, "ERROR");
                }
            }
        }

        public List<Ususario> getuser()
        {
            List<Ususario> listuse = new List<Ususario>();
            string query = " exec verusers";
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
                        Ususario us = new Ususario();
                        //Obtiene los datos de la tabla y se guardan en un lista
                        us.id = reader.GetInt32(0);
                        us.DPI = reader.GetInt64(1);
                        us.Nombres = reader.GetString(2);
                        us.Apellidos = reader.GetString(3);
                        us.Direccion = reader.GetString(4);
                        us.Telefono = reader.GetInt32(5);
                        us.Correo = reader.GetString(6);
                        us.puesto = reader.GetString(7);
                        us.Usuario = reader.GetString(8);
                        us.Contraseña = reader.GetString(9);
                     
                        listuse.Add(us);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return listuse;
        }

        public Ususario getus(int? id)
        {
            Ususario us = new Ususario();
            string query = " exec veruser @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    //Ejecuta el query
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        //Obtiene los datos de la tabla y se guardan en un lista
                        us.id = reader.GetInt32(0);
                        us.DPI = reader.GetInt64(1);
                        us.Nombres = reader.GetString(2);
                        us.Apellidos = reader.GetString(3);
                        us.Direccion = reader.GetString(4);
                        us.Telefono = reader.GetInt32(5);
                        us.Correo = reader.GetString(6);
                        us.puesto = reader.GetString(7);
                        us.Usuario = reader.GetString(8);
                        us.Contraseña = reader.GetString(9);


                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
            }
            return us;
        }


        public void delete(int? id)
        {
            string query = "Exec dtluser @id";
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



    }
}
