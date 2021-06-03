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
    public partial class Usuarios : Form
    {
        ErrorProvider error = new ErrorProvider();
        ErrorProvider error2 = new ErrorProvider();
        public UsuariosDB context = new UsuariosDB();
        public int accion = 0;
        public Usuarios()
        {
            InitializeComponent();
            mostrar();
            ListaUsuarios.ReadOnly = true;
            cmbpuesto.SelectedIndex = 0;
        }

        public void mostrar()
        {
            ListaUsuarios.DataSource = context.getuser();
            ListaUsuarios.Columns[0].Visible = false;
            if (ListaUsuarios.Rows.Count==0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
        private int? GetID()
        {
            try
            {
                return int.Parse(
                    ListaUsuarios.Rows[ListaUsuarios.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return null;
            }
        }
        private void textDPI_TextChanged(object sender, EventArgs e)
        {

        }


        private void textAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textAddress.Text == "")
            {
                error.SetError(textAddress, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textAddress, "");

            }

        }

        private void textMail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        

        private void textDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de solo numeros en el texbox
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregar solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de solo numeros en el texbox
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Agregar solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textDPI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textDPI.Text == "")
            {
                error.SetError(textDPI, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textDPI, "");

            }
        }

        private void textName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textName.Text == "")
            {
                error.SetError(textName, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textName, "");

            }

        }

        private void textLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textLastName.Text == "")
            {
                error.SetError(textLastName, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textLastName, "");

            }

        }

       

        private void textPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textPhone.Text == "")
            {
                error.SetError(textPhone, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textPhone, "");

            }

        }
        
        private void textUser_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textPhone.Text == "")
            {
                error.SetError(textUser, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textUser, "");

            }

        }
        private void textClave_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validacion para alertas no nulas
            if (textPhone.Text == "")
            {
                error.SetError(textClave, "Este campo no puede ir vacio");

            }
            else
            {
                error.SetError(textClave, "");

            }

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if (textAddress.Text=="" || textClave.Text=="" || textDPI.Text=="" || textName.Text=="" || textMail.Text=="" || textLastName.Text=="" || textUser.Text=="" || textPhone.Text==""   || cmbpuesto.SelectedIndex<0 )
            {
                MessageBox.Show("Recuerda que Todos los Datos son necesartios para continuar");

            }
            else
            {
                Ususario us = new Ususario();
                us.DPI = Convert.ToInt32(textDPI.Text);
                us.Nombres = textName.Text;
                us.Apellidos = textLastName.Text;
                us.Correo = textMail.Text;
                us.Contraseña = textClave.Text;
                us.Usuario = textUser.Text;
                us.Telefono = Convert.ToInt32(textPhone.Text);
                us.puesto = cmbpuesto.SelectedItem.ToString();
                us.Direccion = textAddress.Text;


                if (accion == 0) // agregar
                {
                    context.Add(us);
                }
                else if (accion == 1) // modificar 
                {
                    us.id = Convert.ToInt32(GetID());
                    context.UPDATE(us);
                }
                clean();
            }
            
             
            mostrar();
         
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = 1;
            Ususario us =context.getus(GetID());

             textDPI.Text= us.DPI.ToString();
             textName.Text=us.Nombres;
             textLastName.Text= us.Apellidos;
             textMail.Text= us.Correo;
             textClave.Text= us.Contraseña;
             textUser.Text= us.Usuario;
             textPhone.Text= us.Telefono.ToString();
             cmbpuesto.SelectedItem= us.puesto;
             textAddress.Text= us.Direccion;
       
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            context.delete(GetID());
            mostrar();
            clean();
        }
        public void clean()
        {
            textDPI.Text = "";
            textName.Text = "";
            textLastName.Text = "";
            textMail.Text = "";
            textClave.Text = "";
            textUser.Text = "";
            textPhone.Text = "";
            cmbpuesto.SelectedIndex = 0;
            textAddress.Text = "";
        }
    }
}
