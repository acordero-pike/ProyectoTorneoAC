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
using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;

namespace AdminitracionDeTorneosP.View
{
    public partial class Bitacora : Form
    {
        private string connectionString = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL
        public UsuariosDB contextus = new UsuariosDB();
         
        public Bitacora()
        {
            InitializeComponent();
            ListUtilidades.ReadOnly = true;
           List < Ususario>  us = contextus.getuser();
            foreach(var i in us)
            {
                comboBox1.Items.Add(i.Usuario);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Fechini.MaxDate = Fechfn.Value; 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
       
            Fechfn.MinDate = Fechini.Value;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex<0)
            {
                MessageBox.Show("Se Buscara por fehcas mostrando todos los usuarios");
                string fechi =Fechini.Value.Year+"/"+ Fechini.Value.Month+"/" + Fechini.Value.Day+ " 00:00:00";
                string fech2 = Fechfn.Value.Year + "/" + Fechfn.Value.Month + "/" + Fechfn.Value.Day + " 23:59:00";
                string query = "exec bitacoradate '" + fechi + "' , '" + fech2 + "'";
                loadTableData(query);
            }
            else if ( comboBox1.SelectedIndex>=0)
            {
                
                string fechi = Fechini.Value.Year + "/" + Fechini.Value.Month + "/" + Fechini.Value.Day + " 00:00:00";
                string fech2 = Fechfn.Value.Year + "/" + Fechfn.Value.Month + "/" + Fechfn.Value.Day + " 23:59:00";
                string query = "exec bitacora '"+ comboBox1.SelectedItem.ToString() + "','" + fechi + "' , '" + fech2 + "'";
                loadTableData(query);
            }

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

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo realizar la consulta");
                }
            }
        }

        private void Gananciaalquiler_Load(object sender, EventArgs e)
        {

        }
    }
}
