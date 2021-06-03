
namespace AdminitracionDeTorneosP.View
{
    partial class Alquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ListaAlquiler = new System.Windows.Forms.DataGridView();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDPI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.HInicio = new System.Windows.Forms.DateTimePicker();
            this.Hfinal = new System.Windows.Forms.DateTimePicker();
            this.comboNombreCanchas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(522, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 50);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(327, 382);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(161, 50);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(130, 382);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 50);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ListaAlquiler
            // 
            this.ListaAlquiler.AllowUserToAddRows = false;
            this.ListaAlquiler.AllowUserToDeleteRows = false;
            this.ListaAlquiler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaAlquiler.BackgroundColor = System.Drawing.Color.Azure;
            this.ListaAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAlquiler.Location = new System.Drawing.Point(140, 213);
            this.ListaAlquiler.Name = "ListaAlquiler";
            this.ListaAlquiler.ReadOnly = true;
            this.ListaAlquiler.RowHeadersVisible = false;
            this.ListaAlquiler.RowHeadersWidth = 51;
            this.ListaAlquiler.Size = new System.Drawing.Size(542, 142);
            this.ListaAlquiler.TabIndex = 9;
            this.ListaAlquiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAlquiler_CellContentClick);
            // 
            // textMail
            // 
            this.textMail.BackColor = System.Drawing.Color.AliceBlue;
            this.textMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textMail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMail.Location = new System.Drawing.Point(275, 99);
            this.textMail.Margin = new System.Windows.Forms.Padding(2);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(138, 29);
            this.textMail.TabIndex = 19;
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.textPhone.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(200, 163);
            this.textPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(138, 29);
            this.textPhone.TabIndex = 18;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            this.textPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textPhone_Validating);
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.Color.AliceBlue;
            this.textLastName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(88, 109);
            this.textLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(138, 29);
            this.textLastName.TabIndex = 17;
            this.textLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLastName_KeyPress);
            this.textLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textLastName_Validating);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.AliceBlue;
            this.textName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(275, 32);
            this.textName.Margin = new System.Windows.Forms.Padding(2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(138, 29);
            this.textName.TabIndex = 16;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            // 
            // textDPI
            // 
            this.textDPI.BackColor = System.Drawing.Color.AliceBlue;
            this.textDPI.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.textDPI.Location = new System.Drawing.Point(88, 32);
            this.textDPI.Margin = new System.Windows.Forms.Padding(2);
            this.textDPI.Name = "textDPI";
            this.textDPI.Size = new System.Drawing.Size(138, 29);
            this.textDPI.TabIndex = 15;
            this.textDPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDPI_KeyPress);
            this.textDPI.Validating += new System.ComponentModel.CancelEventHandler(this.textDPI_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "DPI";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(522, 32);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 25;
            this.fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // HInicio
            // 
            this.HInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HInicio.Location = new System.Drawing.Point(484, 99);
            this.HInicio.Name = "HInicio";
            this.HInicio.ShowUpDown = true;
            this.HInicio.Size = new System.Drawing.Size(111, 20);
            this.HInicio.TabIndex = 26;
            this.HInicio.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Hfinal
            // 
            this.Hfinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hfinal.Location = new System.Drawing.Point(638, 99);
            this.Hfinal.Name = "Hfinal";
            this.Hfinal.ShowUpDown = true;
            this.Hfinal.Size = new System.Drawing.Size(111, 20);
            this.Hfinal.TabIndex = 27;
            this.Hfinal.ValueChanged += new System.EventHandler(this.Hfinal_ValueChanged);
            // 
            // comboNombreCanchas
            // 
            this.comboNombreCanchas.BackColor = System.Drawing.Color.Azure;
            this.comboNombreCanchas.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNombreCanchas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.comboNombreCanchas.FormattingEnabled = true;
            this.comboNombreCanchas.Location = new System.Drawing.Point(620, 156);
            this.comboNombreCanchas.Margin = new System.Windows.Forms.Padding(2);
            this.comboNombreCanchas.Name = "comboNombreCanchas";
            this.comboNombreCanchas.Size = new System.Drawing.Size(138, 29);
            this.comboNombreCanchas.TabIndex = 29;
            this.comboNombreCanchas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hora inicio ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(667, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Hora final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Costo por Hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(651, 133);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Cancha ";
            // 
            // precio
            // 
            this.precio.DecimalPlaces = 2;
            this.precio.Location = new System.Drawing.Point(464, 163);
            this.precio.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(120, 20);
            this.precio.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(688, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 36;
            this.button1.Text = "Arbitraje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNombreCanchas);
            this.Controls.Add(this.Hfinal);
            this.Controls.Add(this.HInicio);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textDPI);
            this.Controls.Add(this.ListaAlquiler);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView ListaAlquiler;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDPI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DateTimePicker HInicio;
        private System.Windows.Forms.DateTimePicker Hfinal;
        private System.Windows.Forms.ComboBox comboNombreCanchas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown precio;
        private System.Windows.Forms.Button button1;
    }
}