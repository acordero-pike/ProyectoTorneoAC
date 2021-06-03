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
using AdminitracionDeTorneosP.Model;
using AdminitracionDeTorneosP.Database;
namespace AdminitracionDeTorneosP.View
{

    public partial class Alquiler : Form
    {
        public int accion = 0;
        public int idalquiler;
        AlquilerDB contextalq = new AlquilerDB();

        private string connectionstring = "Server=DESKTOP-IFKEU1D\\SQLEXPRESS   ;Database=PROYECTO_TORNEOS;User Id=sa;Password=albin123;"; // Conectando a la base de datos SQL
        ErrorProvider error = new ErrorProvider();
        ErrorProvider error2 = new ErrorProvider();
        detallesPartidoDB db = new detallesPartidoDB();
        refereeDB refg = new refereeDB();
        public Alquiler()
        {
            InitializeComponent();
            getNames();
            getalqui();
            comboNombreCanchas.SelectedIndex = 0;
            ListaAlquiler.Columns[0].Visible = false;
           ListaAlquiler.ReadOnly = false;
        }
        private int? GetID()
        {
            try
            {
                return int.Parse(
                    ListaAlquiler.Rows[ListaAlquiler.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return null;
            }
        }
        public void getalqui()
        {
            ListaAlquiler.DataSource = contextalq.Getalquiler();
            if (ListaAlquiler.Rows.Count>0)
            {
                button1.Enabled = true;
            }
           
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
                    
                    comboNombreCanchas.Items.Add(reader["nombre"].ToString());
                }
                connection.Close();
            }
        }

        public string getname(int id)
        {
            string query = "exec   BG_Muestra_Cancha";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    if (id==Convert.ToInt32(reader["NumeroCancha"].ToString()))
                    {
                        return reader["nombre"].ToString();
                    }
                }
                connection.Close();
            }
            return null;
        }
        private void Alquiler_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            HInicio.MaxDate = Convert.ToDateTime("31/12/9998");
            Hfinal.MaxDate = Convert.ToDateTime("31/12/9998");
            HInicio.MinDate = Convert.ToDateTime("31/12/1900");
            Hfinal.MinDate = Convert.ToDateTime("31/12/1900");

            if (fecha.Value.Date<DateTime.Now.Date)
            {
                MessageBox.Show("La fecha para reservar un alquiler no puede ser menor a la del dia de hoy ");
                fecha.Value = DateTime.Now.Date;
            }
            else
            {
                HInicio.MaxDate = fecha.Value;
                Hfinal.MaxDate = fecha.Value;
                Hfinal.MinDate = fecha.Value.Date;
                HInicio.MinDate = fecha.Value.Date;
                
                HInicio.Value = fecha.Value.Date;
                Hfinal.Value = fecha.Value.Date;
                fecha.Value = Convert.ToDateTime(fecha.Value.Day + "/" + fecha.Value.Month + "/" + fecha.Value.Year + " 23:59:59");
              
            } 
        }

        private void textDPI_Validating(object sender, CancelEventArgs e)
        {
            // validacion para alertas no nulas
            if (textDPI.Text == "")
            {
                error.SetError(textDPI, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textDPI, "");

            }

        }
        private void textName_Validating(object sender, CancelEventArgs e)
        {
            // validacion para alertas no nulas
            if (textName.Text == "")
            {
                error.SetError(textName, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textName, "");

            }

        }

        private void textLastName_Validating(object sender, CancelEventArgs e)
        {
            // validacion para alertas no nulas
            if (textLastName.Text == "")
            {
                error.SetError(textLastName, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textLastName, "");

            }
        }

        private void textPhone_Validating(object sender, CancelEventArgs e)
        {
            // validacion para alertas no nulas
            if (textPhone.Text == "")
            {
                error.SetError(textPhone, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textPhone, "");

            }

        }

        private void textDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregar solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de solo nombres en el texbox
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de solo nombres en el texbox
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion para solo numeros
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregar solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void textMail_Validating(object sender, CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textMail.Text == "")
            {
                error.SetError(textMail, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textMail, "");

            }

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int validar = 0;
            int validar1 = 0;
            int thinicio = 0;
            int alqinicio = 0;
            int alqfin = 0;
            int thfin = 0;
            string fech = fecha.Value.Year + "/" + fecha.Value.Month + "/" + fecha.Value.Day;

            List<disponible> datos = contextalq.getocupadas(fech);

            List<disponible> datosalq = contextalq.getocupadasal(fech);


            string dia = fecha.Value.Date.DayOfWeek.ToString();
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

            DateTime aper = contextalq.GetHorarios(dia).Apertura;
            DateTime cierre = contextalq.GetHorarios(dia).Cierre;
            foreach (var i in datosalq)
            {
                if (i.nombre == comboNombreCanchas.SelectedItem.ToString())
                {
                    if (i.HInicio == HInicio.Value.TimeOfDay || HInicio.Value.TimeOfDay >= i.HInicio && HInicio.Value.TimeOfDay < i.HFin)
                    {
                        validar1 = 1;

                        alqinicio = 1;
                    }
                    if (i.HFin == Hfinal.Value.TimeOfDay || Hfinal.Value.TimeOfDay <= i.HFin && Hfinal.Value.TimeOfDay > i.HInicio)
                    {
                        validar = 1;
                        alqfin = 1;
                    }
                }
            }


                foreach (var i in datos)
            {
                if (i.nombre == comboNombreCanchas.SelectedItem.ToString())
                {
                    if (i.nombre == comboNombreCanchas.SelectedItem.ToString() && i.HInicio == HInicio.Value.TimeOfDay || HInicio.Value.TimeOfDay >= i.HInicio && HInicio.Value.TimeOfDay < i.HFin)
                    {
                        validar1 = 1;
                        thinicio = 1;
                    }
                    if (i.nombre == comboNombreCanchas.SelectedItem.ToString() && i.HFin == Hfinal.Value.TimeOfDay || Hfinal.Value.TimeOfDay <= i.HFin && Hfinal.Value.TimeOfDay > i.HInicio)
                    {
                        validar = 1;
                        thfin = 1;
                    }
                }
            }

            if (accion == 1)
            {
                List<Alquilermodel> ls = contextalq.Getalquiler();
                foreach (var i in ls)
                {
                    if (idalquiler == i.ID)
                    {
                       if(i.Fecha_Alquiler==fecha.Value.Date)
                        {
                            if (getname(i.ID_Cancha) == comboNombreCanchas.SelectedItem.ToString())
                            {
                                if (i.hora_inicio.TimeOfDay == HInicio.Value.TimeOfDay)
                                {
                                    validar1 = 0;
                                    alqinicio = 0;

                                }
                                if (i.hora_final.TimeOfDay == Hfinal.Value.TimeOfDay)
                                {
                                    validar = 0;
                                    alqfin = 0;

                                }
                            }
                        }
                    }
                }

            }

            if (aper.TimeOfDay > HInicio.Value.TimeOfDay)
            {
                MessageBox.Show("La Hora de inicio de Partido seleccionada es menor a la hora de Apertura  Recuerde que Nuestro Horario de Atencion en el dia " + dia + " es de " + aper.TimeOfDay.ToString() + " am  a  " + cierre.TimeOfDay.ToString() + " pm.");
                btnGuardar.Enabled = false;
                validar = 1;
            }
            else if (cierre.TimeOfDay < Hfinal.Value.TimeOfDay)
            {
                MessageBox.Show("La Hora de Finalizacion de Partido seleccionada es Mayor a la hora de Cierre , Recuerde que Nuestro Horario de Atencion en el dia " + dia + " es de " + aper.TimeOfDay.ToString() + " am  a  " + cierre.TimeOfDay.ToString() + " pm.");
                btnGuardar.Enabled = false;
                validar = 1;

            }

            if (textDPI.Text == "" || textLastName.Text == "" || textMail.Text == "" || textName.Text == "" || textPhone.Text == "" || comboNombreCanchas.SelectedIndex<0 || precio.Value==0)
                    {
                validar = 1;
                MessageBox.Show(" Todos los Datos son necesarios para continuar , asegurese de llenar todos los datos para continuar");
            }

            if (thinicio==1) { MessageBox.Show("La hora de inicio seleccionada es invalida ya que ya se esta usando la cancha en un Torneo "); }
            if (thfin==1) { MessageBox.Show("La hora de Fin seleccionada es invalida ya que ya se esta usando la cancha en un Torneo"); }
            if (alqinicio == 1) { MessageBox.Show("La hora de Inicio seleccionada es invalida ya que ya se ha alquilado en el horario "); }
            if (alqfin == 1) { MessageBox.Show("La hora de Fin seleccionada es invalida ya que ya se ha alquilado en el horario "); }
           

            if (validar==0 && validar1==0)
                {
               
                Alquilermodel arq = new Alquilermodel();
                arq.ID_Cancha =  db.getIdCancha(comboNombreCanchas.SelectedItem.ToString());
                arq.Precio_por_hora = Convert.ToDouble(precio.Value);
                arq.Fecha_Alquiler = fecha.Value;
                arq.hora_inicio = HInicio.Value;
                arq.hora_final = Hfinal.Value;
                arq.DPI = Convert.ToInt32(textDPI.Text);
                arq.Nombres = textName.Text;
                arq.Apellidos = textLastName.Text;
                arq.Telefono = Convert.ToInt32(textPhone.Text);
                arq.Correo = textMail.Text;
                if (accion == 1)
                {
                    arq.ID = idalquiler;
                    MessageBox.Show("actualizando...");
                    contextalq.upd(arq);
                    accion = 0;
                }
                else if (accion==0)
                    {
                    MessageBox.Show("Guardando.......");
                    contextalq.Add(arq);
                }
                
                }
            getalqui();
            clean();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            Alquilermodel alq = contextalq.Getalquilerid(id);
            textDPI.Text = alq.DPI.ToString();
            textLastName.Text = alq.Apellidos;
            textName.Text = alq.Nombres;
            textMail.Text = alq.Correo;
            textPhone.Text = alq.Telefono.ToString();
            fecha.Value = alq.Fecha_Alquiler.Date;
            HInicio.Value = alq.hora_inicio;
            Hfinal.Value = alq.hora_final;
            precio.Value = Convert.ToDecimal(alq.Precio_por_hora);
            comboNombreCanchas.SelectedItem = getname(alq.ID_Cancha);
            accion = 1;
            idalquiler = Convert.ToInt32(id);

        }

        private void Hfinal_ValueChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();
            contextalq.delete(id);
            getalqui();
            clean();
            
        }

        public void clean()
        {
            textDPI.Text = "";
            textLastName.Text = "";
            textName.Text = "";
            textMail.Text = "";
            textPhone.Text = "";

            precio.Value = Convert.ToDecimal(0.00);
            comboNombreCanchas.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           List<refereeModel> testing= refg.getRefereee();

            if(testing.Count>0)
            {

                int? id = GetID();
                Alquilermodel a = contextalq.Getalquilerid(id);
                TimeSpan time = a.hora_final - a.hora_inicio;
                string fech = a.Fecha_Alquiler.Year + "/" + a.Fecha_Alquiler.Month + "/" + a.Fecha_Alquiler.Day;

                List<string> nombres = contextalq.names(fech, a.hora_inicio.TimeOfDay, a.hora_final.TimeOfDay);
                List<string> nombres2 = contextalq.namesal(fech, a.hora_inicio, a.hora_final);
                List<string> names = new List<string>();
                foreach (var i in nombres)
                {
                    foreach (var d in nombres2)
                    {
                        if (i != d)
                        {
                            names.Add(d);
                        }
                    }
                }

                Arbitraje_Renta ar = new Arbitraje_Renta(names, Convert.ToInt32(id), Convert.ToInt32(time.Hours));
                ar.Show();
            }
            else
            {
                MessageBox.Show("No tenemos Arbitros registrados por favor ingrese arbitros si deseea este servicio");
            }
        }

        private void ListaAlquiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
