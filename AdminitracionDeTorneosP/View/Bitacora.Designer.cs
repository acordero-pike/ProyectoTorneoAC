
namespace AdminitracionDeTorneosP.View
{
    partial class Bitacora
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ListUtilidades = new System.Windows.Forms.DataGridView();
            this.Fechini = new System.Windows.Forms.DateTimePicker();
            this.Fechfn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListUtilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(207, 316);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 50);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ListUtilidades
            // 
            this.ListUtilidades.AllowUserToAddRows = false;
            this.ListUtilidades.AllowUserToDeleteRows = false;
            this.ListUtilidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListUtilidades.BackgroundColor = System.Drawing.Color.Azure;
            this.ListUtilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUtilidades.Location = new System.Drawing.Point(85, 154);
            this.ListUtilidades.Name = "ListUtilidades";
            this.ListUtilidades.ReadOnly = true;
            this.ListUtilidades.RowHeadersVisible = false;
            this.ListUtilidades.RowHeadersWidth = 51;
            this.ListUtilidades.Size = new System.Drawing.Size(378, 156);
            this.ListUtilidades.TabIndex = 18;
            // 
            // Fechini
            // 
            this.Fechini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fechini.Location = new System.Drawing.Point(64, 62);
            this.Fechini.Name = "Fechini";
            this.Fechini.Size = new System.Drawing.Size(158, 20);
            this.Fechini.TabIndex = 19;
            this.Fechini.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Fechfn
            // 
            this.Fechfn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fechfn.Location = new System.Drawing.Point(64, 116);
            this.Fechfn.Name = "Fechfn";
            this.Fechfn.Size = new System.Drawing.Size(158, 20);
            this.Fechfn.TabIndex = 20;
            this.Fechfn.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Usuarios";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(541, 378);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fechfn);
            this.Controls.Add(this.Fechini);
            this.Controls.Add(this.ListUtilidades);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Gananciaalquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListUtilidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView ListUtilidades;
        private System.Windows.Forms.DateTimePicker Fechini;
        private System.Windows.Forms.DateTimePicker Fechfn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}