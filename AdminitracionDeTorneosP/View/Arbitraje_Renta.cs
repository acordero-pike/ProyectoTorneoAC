using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;
using AdminitracionDeTorneosP.View;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class Arbitraje_Renta : Form
    {
        AlquilerDB contextalq = new AlquilerDB();
        public int ids = 0;
        public int accion=0;
        public int tm = 0;
        public Arbitroalquiler arconte  = new Arbitroalquiler();
        Arbitro_PartidoDB arbitro_PartidoDB = new Arbitro_PartidoDB();
        refereeDB refe = new refereeDB();
        public Arbitraje_Renta(List<string> names , int id,int time )
        {
            InitializeComponent();
            MessageBox.Show("Los nombres de los arbitros Mostrados son los que se encuentran disponibles en la hora seleccionada ");
            ids = id;
            tm = time;
            GetArbitro();
            cbxArbitro.Items.AddRange(names.ToArray());
            ListArbitro.ReadOnly = false;
         


        }

        private void Arbitraje_Renta_Load(object sender, EventArgs e)
        {

        }
        private void GetArbitro()
        {
            ListArbitro.DataSource = arconte.listaarb(ids);
            if (ListArbitro.Rows.Count>0)
            {
              precio.Value=  Convert.ToDecimal(ListArbitro.Rows[0].Cells[4].Value.ToString());
                precio.Enabled = false;
            }
            else
            {
                precio.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          

           if(cbxArbitro.SelectedIndex<0 || precio.Value==0)
            {
                MessageBox.Show("Por Favor llene los campos para poder continuar, el precio debe ser mayor a cero");
            }
            else
            {
                string Arbitro = Convert.ToString(cbxArbitro.SelectedItem);
                string[] ArbitroArray = Arbitro.Split(' ');
                //Nombre almacenado en la posicion 0
                //Apellidos almacenado en la posicion 1
                string Nombres = "";
                string Apellidos = "";
                if (ArbitroArray.Length == 2)
                {
                    Nombres = ArbitroArray[0];
                    Apellidos = ArbitroArray[1];
                }
                else if (ArbitroArray.Length == 4)
                {
                    Nombres = $"{ArbitroArray[0]} {ArbitroArray[1]}";
                    Apellidos = $"{ArbitroArray[2]} {ArbitroArray[3]}";
                }
                Arbitrajemodel ar = new Arbitrajemodel();
                ar.alquiler = ids;
                ar.Arbitro = arbitro_PartidoDB.DPI_Arbitros(Nombres, Apellidos);
                ar.precio = Convert.ToDouble(precio.Value);
                ar.tiempo = tm;
                if (accion == 0)
                {
                    arconte.Add(ar);
                    precio.Enabled = false;
                }
                else
                {
                    ar.id = Convert.ToInt32(GetID());
                    arconte.edtarb(ar);
                    precio.Enabled = false;
                }
            }
            GetArbitro(); 
            getnames();


        }



        private int? GetID()
        {
            try
            {
                return int.Parse(
                    ListArbitro.Rows[ListArbitro.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return null;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = 1;

            Arbitrajemodel arr = arconte.getar(GetID());
            refereeModel re = refe.getRefereeByDPI(arr.Arbitro);
            cbxArbitro.Text = re.name + " " + re.lastname;
            precio.Value = Convert.ToDecimal(arr.precio);
            precio.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            arconte.delete(GetID());
            GetArbitro();
            getnames();

        }

        public void getnames()
        {
            cbxArbitro.Items.Clear();
            Alquilermodel a = contextalq.Getalquilerid(ids);
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
            cbxArbitro.Items.AddRange(names.ToArray());
        }
    }
}
