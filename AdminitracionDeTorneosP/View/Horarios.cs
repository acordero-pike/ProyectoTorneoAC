using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;

namespace AdminitracionDeTorneosP.View
{
    public partial class Horarios : Form
       
    {
        public horarioDB hcon = new horarioDB();
        public Horarios()
        {
            InitializeComponent();
            coachesList.ReadOnly = true;
            load();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {

        }
        public void load()
        {
            coachesList.DataSource = hcon.getdias();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="") 
            {
                MessageBox.Show("Valores en blanco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Horario h = new Horario();
                h.Dia = textBox1.Text;
                h.Apertura = aper.Value;
                h.Cierre = cierre.Value;
                hcon.upd(h);
                load();
                textBox1.Text = "";
            }
           
        }

        private string GetID()
        {
            try
            {
                return 
                    coachesList.Rows[coachesList.CurrentRow.Index].Cells[0].Value.ToString()
                    ;
            }
            catch
            {
                return null;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string name = GetID();
           textBox1.Text= hcon.GetHorarios(name).Dia;
            aper.Value = hcon.GetHorarios(name).Apertura;
            cierre.Value = hcon.GetHorarios(name).Cierre;
        }
    }
}
