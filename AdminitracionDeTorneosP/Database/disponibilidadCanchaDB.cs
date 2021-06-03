﻿using AdminitracionDeTorneosP.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.Database
{
    public class disponibilidadCanchaDB
    {
        //ruta de conexión
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL
        //método para obtener la disponibilidad de las canchas
        public List<disponibilidadCanchas> getDisponibilidadCancha()
        {
            List<disponibilidadCanchas> disCanchas = new List<disponibilidadCanchas>();
            //query para obtner datos 
            string query = "Select * from Reporte_Uso_canchas ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    //crear lector de datos 
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        //lectura de datos 
                        disponibilidadCanchas dc = new disponibilidadCanchas();
                        dc.numeroCancha = reader.GetInt32(0);
                        dc.nombre = reader.GetString(1);
                        dc.disponibilidad = reader.GetString(2);
                        dc.id_Juego = reader.GetInt32(3);
                        dc.horaInicio = reader.GetTimeSpan(4);
                        dc.horaFinal = reader.GetTimeSpan(5);

                        disCanchas.Add(dc);
                    }
                    reader.Close();
                    connection.Close();
                }
                //informar de algún problema 
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos desde la base de datos. " + ex.Message);
                }
            }
            //retornar lista obtenida
            return disCanchas;
        }

    }
}
