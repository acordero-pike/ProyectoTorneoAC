
namespace AdminitracionDeTorneosP.View
{
    partial class GananciasArbitrajealquiler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fechfn = new System.Windows.Forms.DateTimePicker();
            this.Fechini = new System.Windows.Forms.DateTimePicker();
            this.ListUtilidades = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListUtilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Inicio";
            // 
            // Fechfn
            // 
            this.Fechfn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fechfn.Location = new System.Drawing.Point(278, 62);
            this.Fechfn.Name = "Fechfn";
            this.Fechfn.Size = new System.Drawing.Size(158, 20);
            this.Fechfn.TabIndex = 26;
            this.Fechfn.ValueChanged += new System.EventHandler(this.Fechfn_ValueChanged_1);
            // 
            // Fechini
            // 
            this.Fechini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fechini.Location = new System.Drawing.Point(72, 62);
            this.Fechini.Name = "Fechini";
            this.Fechini.Size = new System.Drawing.Size(158, 20);
            this.Fechini.TabIndex = 25;
            this.Fechini.ValueChanged += new System.EventHandler(this.Fechini_ValueChanged);
            // 
            // ListUtilidades
            // 
            this.ListUtilidades.AllowUserToAddRows = false;
            this.ListUtilidades.AllowUserToDeleteRows = false;
            this.ListUtilidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListUtilidades.BackgroundColor = System.Drawing.Color.Azure;
            this.ListUtilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUtilidades.Location = new System.Drawing.Point(72, 126);
            this.ListUtilidades.Name = "ListUtilidades";
            this.ListUtilidades.ReadOnly = true;
            this.ListUtilidades.RowHeadersVisible = false;
            this.ListUtilidades.RowHeadersWidth = 51;
            this.ListUtilidades.Size = new System.Drawing.Size(378, 156);
            this.ListUtilidades.TabIndex = 24;
            this.ListUtilidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListUtilidades_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(194, 304);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 50);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GananciasArbitrajealquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(525, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fechfn);
            this.Controls.Add(this.Fechini);
            this.Controls.Add(this.ListUtilidades);
            this.Controls.Add(this.btnBuscar);
            this.Name = "GananciasArbitrajealquiler";
            this.Text = "GananciasArbitrajealquiler";
            this.Load += new System.EventHandler(this.GananciasArbitrajealquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListUtilidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fechfn;
        private System.Windows.Forms.DateTimePicker Fechini;
        private System.Windows.Forms.DataGridView ListUtilidades;
        private System.Windows.Forms.Button btnBuscar;
    }
}