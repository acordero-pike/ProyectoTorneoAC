
namespace AdminitracionDeTorneosP.View
{
    partial class vISTA_ENCUENTROS_WIN
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
            this.lista_encuentros_datagrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbid_torneo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lista_encuentros_datagrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista_encuentros_datagrid
            // 
            this.lista_encuentros_datagrid.AllowUserToAddRows = false;
            this.lista_encuentros_datagrid.AllowUserToDeleteRows = false;
            this.lista_encuentros_datagrid.BackgroundColor = System.Drawing.Color.Azure;
            this.lista_encuentros_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_encuentros_datagrid.GridColor = System.Drawing.Color.Azure;
            this.lista_encuentros_datagrid.Location = new System.Drawing.Point(24, 176);
            this.lista_encuentros_datagrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lista_encuentros_datagrid.Name = "lista_encuentros_datagrid";
            this.lista_encuentros_datagrid.ReadOnly = true;
            this.lista_encuentros_datagrid.RowHeadersVisible = false;
            this.lista_encuentros_datagrid.RowHeadersWidth = 51;
            this.lista_encuentros_datagrid.RowTemplate.Height = 24;
            this.lista_encuentros_datagrid.Size = new System.Drawing.Size(476, 115);
            this.lista_encuentros_datagrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1_id);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbid_torneo);
            this.groupBox1.Controls.Add(this.lista_encuentros_datagrid);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(100, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(523, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(310, 89);
            this.textBox1_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(76, 20);
            this.textBox1_id.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(193, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(30, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "VISTA DE ENCUENTROS POR TORNEO";
            // 
            // cmbid_torneo
            // 
            this.cmbid_torneo.BackColor = System.Drawing.Color.Azure;
            this.cmbid_torneo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid_torneo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.cmbid_torneo.FormattingEnabled = true;
            this.cmbid_torneo.Location = new System.Drawing.Point(310, 29);
            this.cmbid_torneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbid_torneo.Name = "cmbid_torneo";
            this.cmbid_torneo.Size = new System.Drawing.Size(190, 29);
            this.cmbid_torneo.TabIndex = 2;
            this.cmbid_torneo.Text = "Seleccione una opcion";
            this.cmbid_torneo.SelectedIndexChanged += new System.EventHandler(this.cmbid_torneo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "VISTA DE ENCUENTROS POR TORNEO";
            // 
            // vISTA_ENCUENTROS_WIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(769, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "vISTA_ENCUENTROS_WIN";
            this.Text = "vISTA_ENCUENTROS_WIN";
            ((System.ComponentModel.ISupportInitialize)(this.lista_encuentros_datagrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_encuentros_datagrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbid_torneo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_id;
    }
}