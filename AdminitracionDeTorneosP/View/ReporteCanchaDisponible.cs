using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Model;
using AdminitracionDeTorneosP.Database;
using System.Data.SqlClient;

namespace AdminitracionDeTorneosP.View
{
    public partial class ReporteCanchaDisponible : Form
    {
        public int idalquiler;
        AlquilerDB contextalq = new AlquilerDB();

        private string connectionstring = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL
        ErrorProvider error = new ErrorProvider();
        ErrorProvider error2 = new ErrorProvider();
        detallesPartidoDB db = new detallesPartidoDB();
        refereeDB refg = new refereeDB();
        public ReporteCanchaDisponible()
        {
            InitializeComponent();
            getNames();
            dataGridView1.ReadOnly = true;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
           
            int inn = 0;
            int aper = 0;
            int cierre = 0;
           if(cmbCanchas.SelectedIndex>=0)
            {
                List<string> horario = new List<string>();
                for (DateTime fech = Fechini.Value; fech.Date <= Fechfn.Value.Date;)
                {

                    dataGridView1.Columns.Add("Disponibilidad", fech.Date.ToShortDateString());

                    string dia = diasemana(fech.Date.DayOfWeek.ToString());

                    if (inn == 0)
                    {

                        aper = contextalq.GetHorarios(dia).Apertura.Hour;
                        cierre = contextalq.GetHorarios(dia).Cierre.Hour;
                    }

                    if (aper > contextalq.GetHorarios(dia).Apertura.Hour)
                    {
                        aper = contextalq.GetHorarios(dia).Apertura.Hour;
                    }
                    if (cierre < contextalq.GetHorarios(dia).Cierre.Hour)
                    {
                        cierre = contextalq.GetHorarios(dia).Cierre.Hour;
                    }

                    fech = fech.Date.AddDays(1);
                    inn = inn + 1;

                }
                for (int i = aper; i < cierre; i++)
                {
                    int j = i + 1;

                    horario.Add(i + "-" + j);


                }
                int s = 0;
                int col = dataGridView1.Columns.Count;
                for (int a = 0; a < col; a++)
                {
                    s = 0;
                    DateTime val = Convert.ToDateTime(dataGridView1.Columns[a].HeaderText);
                    string day = diasemana(val.DayOfWeek.ToString());
                    string fechab = val.Year + "/" + val.Month + "/" + val.Day;
                    int vuleta = 1;
                    List<string> alq = namesal(fechab, cmbCanchas.SelectedItem.ToString());
                    List<string> tor = names(fechab, cmbCanchas.SelectedItem.ToString());
                    for (int isd =0; isd<horario.Count;isd++)
                    {
                        if (a == 0 && isd == 0)
                        {
                            foreach (var llenado in horario)
                            {
                                dataGridView1.Rows.Add("");
                                vuleta = vuleta + 1;
                            }
                        }
                        int sa = vuleta;
                        string[] inicio = horario.ElementAt(isd).Split('-');
                        int ini = Convert.ToInt32(inicio[0]);
                        int fin = Convert.ToInt32(inicio[1]);
                        if (contextalq.GetHorarios(day).Apertura.Hour > ini || fin > contextalq.GetHorarios(day).Cierre.Hour)
                        {

                            dataGridView1.Rows[isd].Cells[a].Value = ("Horario Fuera de Rango");

                        }
                        else
                        {
                             if(alq.Count==0 && tor.Count==0)
    
                            {
                                dataGridView1.Rows[isd].Cells[a].Value = ("Disponible");

                            }
                           else
                            {
                                tor.AddRange(alq);

                                foreach(var h in tor)
                                {
                                    string[] horavalidar = h.Split('-');
                                    int oini = Convert.ToInt32(horavalidar[0]);
                                    int ofin = Convert.ToInt32(horavalidar[1]);
                                    if (oini==ini  && ofin!=fin)
                                    {
                                        while(  fin< ofin)
                                        {
                                             
                                             
                                                dataGridView1.Rows[isd].Cells[a].Value = ("No Disponible");
                                            inicio = horario.ElementAt(isd).Split('-');
                                             ini = Convert.ToInt32(inicio[0]);
                                            fin = Convert.ToInt32(inicio[1]);
                                            dataGridView1.Rows[isd].HeaderCell.Value = horario.ElementAt(isd);
                                            isd = isd + 1;
                                        }
                                        inicio = horario.ElementAt(isd).Split('-');
                                        ini = Convert.ToInt32(inicio[0]);
                                        fin = Convert.ToInt32(inicio[1]);

                                    }
                                    else if (oini == ini && ofin == fin)
                                    {
                                        dataGridView1.Rows[isd].Cells[a].Value = ("No Disponible");

                                    }
                                    else
                                    {
                                        dataGridView1.Rows[isd].Cells[a].Value = (" Disponible");
                                    }
                                   
                                }
                            }

                            dataGridView1.Rows[isd].HeaderCell.Value = horario.ElementAt(isd);

                           
                           
                            
                        }
                    }

                }
            }else
            {
                MessageBox.Show("Seleccione una cancha para poder buscar");
            }
        }

        public string diasemana(string dia)
        {
            switch (dia)
            {
                case "Monday":
                    dia = "Lunes";
                    break;
                case "Tuesday":
                    dia = "Lunes";
                    break;
                case "Wednesday":
                    dia = "Lunes";
                    break;
                case "Thursday":
                    dia = "Lunes";
                    break;
                case "Friday":
                    dia = "Viernes";
                    break;
                case "Saturday":
                    dia = "Sabado";
                    break;
                case "Sunday":
                    dia = "Domingo";
                    break;
            }
            return dia;
        }

        public List<string> names(string date, string name)
        {
            List<string> horas = new List<string>();
            string query = "exec   canchastorneouso @date ,@name";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@date", date);
                sql.Parameters.AddWithValue("@name", name);
               
                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {

                    string[] a = reader["HoraInicio"].ToString().Split(':');
                    string[] b = reader["HoraFinal"].ToString().Split(':');

                    if (reader["HoraInicio"].ToString() == "00:00:00" && reader["HoraFinal"].ToString() == "00:00:00")
                    {
                        
                    }
                    else
                    {
                        horas.Add(a[0] + "-" + b[0]);
                    }
                }
                connection.Close();
            }
            return horas;
        }

        public List<string> namesal(string date, string name)
        {
            List<string> horas = new List<string>();
            string query = "exec   alquileruso @date ,@name";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@date", date);
                sql.Parameters.AddWithValue("@name", name);
                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    TimeSpan ins = reader.GetDateTime(2).TimeOfDay;
                    TimeSpan fin = reader.GetDateTime(3).TimeOfDay;
                    if (ins.ToString() == "00:00:00" && fin.ToString() == "00:00:00")
                    {
                       
                    }
                    else
                    {
                        horas.Add(ins.Hours+"-"+fin.Hours);
                    }
                }
                connection.Close();
            }
            return horas;
        }

        public void getNames()
        {
            string query = "exec LA_obtenerNombreCanchas";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {

                    cmbCanchas.Items.Add(reader["nombre"].ToString());
                }
                connection.Close();
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

        private void ReporteCanchaDisponible_Load(object sender, EventArgs e)
        {

        }
    }
}
