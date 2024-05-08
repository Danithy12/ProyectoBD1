namespace ProyectoBD1
{
    partial class FRM_Torneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Torneo));
            this.lbl_UbicacionTorneo = new System.Windows.Forms.Label();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.lbl_NombreTorneo = new System.Windows.Forms.Label();
            this.txt_FechaTorneo = new System.Windows.Forms.TextBox();
            this.dgvTorneo = new System.Windows.Forms.DataGridView();
            this.txt_UbicacionTorneo = new System.Windows.Forms.TextBox();
            this.txt_NombreTorneo = new System.Windows.Forms.TextBox();
            this.btn_GuardarTorneo = new System.Windows.Forms.Button();
            this.btn_LimpiarTorneo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_ReglasEspecificas = new System.Windows.Forms.TextBox();
            this.lbl_Reglas = new System.Windows.Forms.Label();
            this.lbl_Idtorneo = new System.Windows.Forms.Label();
            this.txt_Idtorneo = new System.Windows.Forms.TextBox();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.txt_FechaFinal = new System.Windows.Forms.TextBox();
            this.lbl_FechaFinal_Torneo = new System.Windows.Forms.Label();
            this.cboBox_Categoria_Torneo = new System.Windows.Forms.ComboBox();
            this.btn_Categoria_Torneo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UbicacionTorneo
            // 
            this.lbl_UbicacionTorneo.AutoSize = true;
            this.lbl_UbicacionTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_UbicacionTorneo.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UbicacionTorneo.Location = new System.Drawing.Point(12, 332);
            this.lbl_UbicacionTorneo.Name = "lbl_UbicacionTorneo";
            this.lbl_UbicacionTorneo.Size = new System.Drawing.Size(108, 24);
            this.lbl_UbicacionTorneo.TabIndex = 12;
            this.lbl_UbicacionTorneo.Text = "Ubicación";
            this.lbl_UbicacionTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_FechaInicio.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInicio.Location = new System.Drawing.Point(14, 197);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(135, 24);
            this.lbl_FechaInicio.TabIndex = 14;
            this.lbl_FechaInicio.Text = "Fecha Inicio";
            this.lbl_FechaInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_NombreTorneo
            // 
            this.lbl_NombreTorneo.AutoSize = true;
            this.lbl_NombreTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NombreTorneo.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreTorneo.Location = new System.Drawing.Point(14, 47);
            this.lbl_NombreTorneo.Name = "lbl_NombreTorneo";
            this.lbl_NombreTorneo.Size = new System.Drawing.Size(86, 24);
            this.lbl_NombreTorneo.TabIndex = 16;
            this.lbl_NombreTorneo.Text = "Nombre";
            this.lbl_NombreTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_FechaTorneo
            // 
            this.txt_FechaTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_FechaTorneo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaTorneo.Location = new System.Drawing.Point(162, 197);
            this.txt_FechaTorneo.Name = "txt_FechaTorneo";
            this.txt_FechaTorneo.Size = new System.Drawing.Size(191, 26);
            this.txt_FechaTorneo.TabIndex = 21;
            this.txt_FechaTorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTorneo
            // 
            this.dgvTorneo.AllowUserToAddRows = false;
            this.dgvTorneo.AllowUserToDeleteRows = false;
            this.dgvTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTorneo.Location = new System.Drawing.Point(359, 47);
            this.dgvTorneo.Name = "dgvTorneo";
            this.dgvTorneo.ReadOnly = true;
            this.dgvTorneo.RowHeadersWidth = 62;
            this.dgvTorneo.RowTemplate.Height = 28;
            this.dgvTorneo.Size = new System.Drawing.Size(1442, 395);
            this.dgvTorneo.TabIndex = 22;
            this.dgvTorneo.SelectionChanged += new System.EventHandler(this.dgvTorneo_SelectionChanged);
            // 
            // txt_UbicacionTorneo
            // 
            this.txt_UbicacionTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_UbicacionTorneo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UbicacionTorneo.Location = new System.Drawing.Point(162, 333);
            this.txt_UbicacionTorneo.Name = "txt_UbicacionTorneo";
            this.txt_UbicacionTorneo.Size = new System.Drawing.Size(191, 26);
            this.txt_UbicacionTorneo.TabIndex = 25;
            this.txt_UbicacionTorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NombreTorneo
            // 
            this.txt_NombreTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NombreTorneo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreTorneo.Location = new System.Drawing.Point(162, 47);
            this.txt_NombreTorneo.Name = "txt_NombreTorneo";
            this.txt_NombreTorneo.Size = new System.Drawing.Size(191, 26);
            this.txt_NombreTorneo.TabIndex = 27;
            this.txt_NombreTorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_GuardarTorneo
            // 
            this.btn_GuardarTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_GuardarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarTorneo.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarTorneo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarTorneo.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarTorneo.Image")));
            this.btn_GuardarTorneo.Location = new System.Drawing.Point(407, 491);
            this.btn_GuardarTorneo.Name = "btn_GuardarTorneo";
            this.btn_GuardarTorneo.Size = new System.Drawing.Size(167, 74);
            this.btn_GuardarTorneo.TabIndex = 29;
            this.btn_GuardarTorneo.Text = "Guardar";
            this.btn_GuardarTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarTorneo.UseVisualStyleBackColor = false;
            this.btn_GuardarTorneo.Click += new System.EventHandler(this.btn_GuardarTorneo_Click);
            // 
            // btn_LimpiarTorneo
            // 
            this.btn_LimpiarTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_LimpiarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LimpiarTorneo.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimpiarTorneo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_LimpiarTorneo.Image = ((System.Drawing.Image)(resources.GetObject("btn_LimpiarTorneo.Image")));
            this.btn_LimpiarTorneo.Location = new System.Drawing.Point(853, 491);
            this.btn_LimpiarTorneo.Name = "btn_LimpiarTorneo";
            this.btn_LimpiarTorneo.Size = new System.Drawing.Size(167, 74);
            this.btn_LimpiarTorneo.TabIndex = 31;
            this.btn_LimpiarTorneo.Text = "Limpiar";
            this.btn_LimpiarTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LimpiarTorneo.UseVisualStyleBackColor = false;
            this.btn_LimpiarTorneo.Click += new System.EventHandler(this.btn_LimpiarTorneo_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1280, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 74);
            this.button3.TabIndex = 32;
            this.button3.Text = "Eliminar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_ReglasEspecificas
            // 
            this.txt_ReglasEspecificas.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_ReglasEspecificas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReglasEspecificas.Location = new System.Drawing.Point(162, 400);
            this.txt_ReglasEspecificas.Name = "txt_ReglasEspecificas";
            this.txt_ReglasEspecificas.Size = new System.Drawing.Size(191, 26);
            this.txt_ReglasEspecificas.TabIndex = 34;
            this.txt_ReglasEspecificas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Reglas
            // 
            this.lbl_Reglas.AutoSize = true;
            this.lbl_Reglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Reglas.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reglas.Location = new System.Drawing.Point(14, 399);
            this.lbl_Reglas.Name = "lbl_Reglas";
            this.lbl_Reglas.Size = new System.Drawing.Size(75, 24);
            this.lbl_Reglas.TabIndex = 33;
            this.lbl_Reglas.Text = "Reglas";
            this.lbl_Reglas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Idtorneo
            // 
            this.lbl_Idtorneo.AutoSize = true;
            this.lbl_Idtorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Idtorneo.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtorneo.Location = new System.Drawing.Point(8, 9);
            this.lbl_Idtorneo.Name = "lbl_Idtorneo";
            this.lbl_Idtorneo.Size = new System.Drawing.Size(37, 24);
            this.lbl_Idtorneo.TabIndex = 35;
            this.lbl_Idtorneo.Text = "ID";
            this.lbl_Idtorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Idtorneo
            // 
            this.txt_Idtorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_Idtorneo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idtorneo.Location = new System.Drawing.Point(51, 10);
            this.txt_Idtorneo.Name = "txt_Idtorneo";
            this.txt_Idtorneo.Size = new System.Drawing.Size(45, 26);
            this.txt_Idtorneo.TabIndex = 36;
            this.txt_Idtorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(1634, 491);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(167, 74);
            this.btn_SalirPresentacion.TabIndex = 23;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // txt_FechaFinal
            // 
            this.txt_FechaFinal.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_FechaFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaFinal.Location = new System.Drawing.Point(162, 273);
            this.txt_FechaFinal.Name = "txt_FechaFinal";
            this.txt_FechaFinal.Size = new System.Drawing.Size(191, 26);
            this.txt_FechaFinal.TabIndex = 38;
            this.txt_FechaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_FechaFinal_Torneo
            // 
            this.lbl_FechaFinal_Torneo.AutoSize = true;
            this.lbl_FechaFinal_Torneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_FechaFinal_Torneo.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaFinal_Torneo.Location = new System.Drawing.Point(14, 275);
            this.lbl_FechaFinal_Torneo.Name = "lbl_FechaFinal_Torneo";
            this.lbl_FechaFinal_Torneo.Size = new System.Drawing.Size(130, 24);
            this.lbl_FechaFinal_Torneo.TabIndex = 37;
            this.lbl_FechaFinal_Torneo.Text = "Fecha Final";
            this.lbl_FechaFinal_Torneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboBox_Categoria_Torneo
            // 
            this.cboBox_Categoria_Torneo.FormattingEnabled = true;
            this.cboBox_Categoria_Torneo.Location = new System.Drawing.Point(153, 124);
            this.cboBox_Categoria_Torneo.Name = "cboBox_Categoria_Torneo";
            this.cboBox_Categoria_Torneo.Size = new System.Drawing.Size(191, 28);
            this.cboBox_Categoria_Torneo.TabIndex = 39;
            // 
            // btn_Categoria_Torneo
            // 
            this.btn_Categoria_Torneo.Location = new System.Drawing.Point(18, 109);
            this.btn_Categoria_Torneo.Name = "btn_Categoria_Torneo";
            this.btn_Categoria_Torneo.Size = new System.Drawing.Size(115, 56);
            this.btn_Categoria_Torneo.TabIndex = 40;
            this.btn_Categoria_Torneo.Text = "Cargar\r\nCategoría";
            this.btn_Categoria_Torneo.UseVisualStyleBackColor = true;
            this.btn_Categoria_Torneo.Click += new System.EventHandler(this.btn_Categoria_Torneo_Click);
            // 
            // FRM_Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1813, 595);
            this.Controls.Add(this.btn_Categoria_Torneo);
            this.Controls.Add(this.cboBox_Categoria_Torneo);
            this.Controls.Add(this.txt_FechaFinal);
            this.Controls.Add(this.lbl_FechaFinal_Torneo);
            this.Controls.Add(this.txt_Idtorneo);
            this.Controls.Add(this.lbl_Idtorneo);
            this.Controls.Add(this.txt_ReglasEspecificas);
            this.Controls.Add(this.lbl_Reglas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_LimpiarTorneo);
            this.Controls.Add(this.btn_GuardarTorneo);
            this.Controls.Add(this.txt_NombreTorneo);
            this.Controls.Add(this.txt_UbicacionTorneo);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.dgvTorneo);
            this.Controls.Add(this.txt_FechaTorneo);
            this.Controls.Add(this.lbl_NombreTorneo);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.lbl_UbicacionTorneo);
            this.Name = "FRM_Torneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Torneo";
            this.Load += new System.EventHandler(this.FRM_Torneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UbicacionTorneo;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.Label lbl_NombreTorneo;
        private System.Windows.Forms.TextBox txt_FechaTorneo;
        private System.Windows.Forms.DataGridView dgvTorneo;
        private System.Windows.Forms.TextBox txt_UbicacionTorneo;
        private System.Windows.Forms.TextBox txt_NombreTorneo;
        private System.Windows.Forms.Button btn_GuardarTorneo;
        private System.Windows.Forms.Button btn_LimpiarTorneo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_ReglasEspecificas;
        private System.Windows.Forms.Label lbl_Reglas;
        private System.Windows.Forms.Label lbl_Idtorneo;
        private System.Windows.Forms.TextBox txt_Idtorneo;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.TextBox txt_FechaFinal;
        private System.Windows.Forms.Label lbl_FechaFinal_Torneo;
        private System.Windows.Forms.ComboBox cboBox_Categoria_Torneo;
        private System.Windows.Forms.Button btn_Categoria_Torneo;
    }
}