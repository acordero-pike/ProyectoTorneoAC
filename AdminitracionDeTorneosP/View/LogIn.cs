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

namespace AdminitracionDeTorneosP.View
{
    public partial class LogIn : Form
    {
        public UsuariosDB uscontext = new UsuariosDB();
        public acciones ac = new acciones();
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int validar = 0;
            int id = 0;
            string names="";
            string tipe = "";
           List<Ususario> users = uscontext.getuser();
            foreach(var i in users)
            {
                if(textUs.Text==i.Usuario && TextCl.Text==i.Contraseña)
                {
                    names = i.Nombres + " " + i.Apellidos;
                    validar = 1;
                     tipe = i.puesto;
                    id = i.id;
                }
            }
            if (validar==1)
            {
                MessageBox.Show("Bienvenido Al Sistema " + names );
                ac.add(id, "Login");
                this.Hide();
                Form1 fr = new Form1(names,tipe,id);
                fr.Show();
            }
            else
            {
                MessageBox.Show("Error en el ingreso , Contraseña o Usuario Incorrectos");
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
