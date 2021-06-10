﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class listadoArbitrosGit : Form
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL

        public listadoArbitrosGit()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string query = "EXEC SP_GET_ARBITROS_GIT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter sql = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();

                    sql.Fill(data);

                    listArbitros.DataSource = data;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al obtener los registros");
                }
            }
        }

        private void listadoArbitrosGit_Load(object sender, EventArgs e)
        {

        }
    }
}
