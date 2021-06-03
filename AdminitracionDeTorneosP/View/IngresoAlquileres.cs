using System;
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
    public partial class IngresoAlquileres : Form
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL

        public IngresoAlquileres()
        {
            InitializeComponent();
            ListUtilidades.ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fechi = Fechini.Value.Year + "/" + Fechini.Value.Month + "/" + Fechini.Value.Day;
            string fech2 = Fechfn.Value.Year + "/" + Fechfn.Value.Month + "/" + Fechfn.Value.Day;
            string query = "exec ganaciaalqui '" + fechi + "' , '" + fech2 + "'";
            loadTableData(query);
        }

        private void loadTableData(string query)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Adaptador para almacenar consulta



                    SqlDataAdapter sqll = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();

                    //Cargar tabla con la informacion de la consulta
                    sqll.Fill(data);
                    //Cargar datos en lista

                    ListUtilidades.DataSource = data;
                    if (ListUtilidades.Rows.Count == 0)
                    {
                        MessageBox.Show("Conexion Exitosa pero en las fechas Seleccionadas no se encuentran datos ");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo realizar la consulta");
                }
            }
        }

        private void Fechini_ValueChanged(object sender, EventArgs e)
        {
            Fechfn.MinDate = Fechini.Value;
        }

        private void Fechfn_ValueChanged(object sender, EventArgs e)
        {
            Fechini.MaxDate = Fechfn.Value;
        }

        private void IngresoAlquileres_Load(object sender, EventArgs e)
        {

        }
    }
}
