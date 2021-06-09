
namespace AdminitracionDeTorneosP.View
{
    partial class Reporte_Jugadores1
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
            this.Listajugadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Listajugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // Listajugadores
            // 
            this.Listajugadores.AllowUserToAddRows = false;
            this.Listajugadores.AllowUserToDeleteRows = false;
            this.Listajugadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Listajugadores.BackgroundColor = System.Drawing.Color.Azure;
            this.Listajugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listajugadores.Location = new System.Drawing.Point(126, 215);
            this.Listajugadores.Name = "Listajugadores";
            this.Listajugadores.ReadOnly = true;
            this.Listajugadores.RowHeadersVisible = false;
            this.Listajugadores.RowHeadersWidth = 51;
            this.Listajugadores.Size = new System.Drawing.Size(542, 142);
            this.Listajugadores.TabIndex = 10;
            // 
            // Reporte_Jugadores1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listajugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reporte_Jugadores1";
            this.Text = "Reporte_Jugadores1";
            this.Load += new System.EventHandler(this.Reporte_Jugadores1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listajugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Listajugadores;
    }
}