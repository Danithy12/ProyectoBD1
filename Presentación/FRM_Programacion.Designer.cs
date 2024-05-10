namespace ProyectoBD1
{
    partial class FRM_Programacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Programacion));
            this.btn_GuardarTorneo = new System.Windows.Forms.Button();
            this.txt_FechaPrograma = new System.Windows.Forms.TextBox();
            this.txt_NombreTorneo = new System.Windows.Forms.TextBox();
            this.txt_IdPrograma = new System.Windows.Forms.TextBox();
            this.txt_EquipoVisitante = new System.Windows.Forms.TextBox();
            this.txt_EquipoLocal = new System.Windows.Forms.TextBox();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.dgvProgramacion = new System.Windows.Forms.DataGridView();
            this.txt_HoraProgramaci = new System.Windows.Forms.TextBox();
            this.lbl_TorneoPrograma = new System.Windows.Forms.Label();
            this.lbl_FechaPrograma = new System.Windows.Forms.Label();
            this.lbl_HoraPrograma = new System.Windows.Forms.Label();
            this.lbl_EquipoLocal = new System.Windows.Forms.Label();
            this.lbl_UbicacionPrograma = new System.Windows.Forms.Label();
            this.lbl_IdPrograma = new System.Windows.Forms.Label();
            this.lbl_EquipoVisitan = new System.Windows.Forms.Label();
            this.txt_UbicacionPrograma = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiarProgramacion = new System.Windows.Forms.Button();
            this.btnEliminarProgramacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GuardarTorneo
            // 
            this.btn_GuardarTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_GuardarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarTorneo.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarTorneo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarTorneo.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarTorneo.Image")));
            this.btn_GuardarTorneo.Location = new System.Drawing.Point(472, 594);
            this.btn_GuardarTorneo.Name = "btn_GuardarTorneo";
            this.btn_GuardarTorneo.Size = new System.Drawing.Size(167, 74);
            this.btn_GuardarTorneo.TabIndex = 45;
            this.btn_GuardarTorneo.Text = "Guardar";
            this.btn_GuardarTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarTorneo.UseVisualStyleBackColor = false;
            this.btn_GuardarTorneo.Click += new System.EventHandler(this.btn_GuardarTorneo_Click);
            // 
            // txt_FechaPrograma
            // 
            this.txt_FechaPrograma.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_FechaPrograma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaPrograma.Location = new System.Drawing.Point(157, 208);
            this.txt_FechaPrograma.Name = "txt_FechaPrograma";
            this.txt_FechaPrograma.Size = new System.Drawing.Size(191, 26);
            this.txt_FechaPrograma.TabIndex = 44;
            this.txt_FechaPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NombreTorneo
            // 
            this.txt_NombreTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NombreTorneo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreTorneo.Location = new System.Drawing.Point(157, 141);
            this.txt_NombreTorneo.Name = "txt_NombreTorneo";
            this.txt_NombreTorneo.Size = new System.Drawing.Size(191, 26);
            this.txt_NombreTorneo.TabIndex = 43;
            this.txt_NombreTorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IdPrograma
            // 
            this.txt_IdPrograma.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_IdPrograma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdPrograma.Location = new System.Drawing.Point(157, 67);
            this.txt_IdPrograma.Name = "txt_IdPrograma";
            this.txt_IdPrograma.Size = new System.Drawing.Size(191, 26);
            this.txt_IdPrograma.TabIndex = 42;
            this.txt_IdPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EquipoVisitante
            // 
            this.txt_EquipoVisitante.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_EquipoVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EquipoVisitante.Location = new System.Drawing.Point(157, 461);
            this.txt_EquipoVisitante.Name = "txt_EquipoVisitante";
            this.txt_EquipoVisitante.Size = new System.Drawing.Size(191, 26);
            this.txt_EquipoVisitante.TabIndex = 41;
            this.txt_EquipoVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EquipoLocal
            // 
            this.txt_EquipoLocal.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_EquipoLocal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EquipoLocal.Location = new System.Drawing.Point(157, 367);
            this.txt_EquipoLocal.Name = "txt_EquipoLocal";
            this.txt_EquipoLocal.Size = new System.Drawing.Size(191, 26);
            this.txt_EquipoLocal.TabIndex = 40;
            this.txt_EquipoLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(1332, 594);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(167, 74);
            this.btn_SalirPresentacion.TabIndex = 39;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // dgvProgramacion
            // 
            this.dgvProgramacion.AllowUserToAddRows = false;
            this.dgvProgramacion.AllowUserToDeleteRows = false;
            this.dgvProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramacion.Location = new System.Drawing.Point(382, 67);
            this.dgvProgramacion.Name = "dgvProgramacion";
            this.dgvProgramacion.ReadOnly = true;
            this.dgvProgramacion.RowHeadersWidth = 62;
            this.dgvProgramacion.RowTemplate.Height = 28;
            this.dgvProgramacion.Size = new System.Drawing.Size(1470, 492);
            this.dgvProgramacion.TabIndex = 38;
            // 
            // txt_HoraProgramaci
            // 
            this.txt_HoraProgramaci.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_HoraProgramaci.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoraProgramaci.Location = new System.Drawing.Point(157, 284);
            this.txt_HoraProgramaci.Name = "txt_HoraProgramaci";
            this.txt_HoraProgramaci.Size = new System.Drawing.Size(191, 26);
            this.txt_HoraProgramaci.TabIndex = 37;
            this.txt_HoraProgramaci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_TorneoPrograma
            // 
            this.lbl_TorneoPrograma.AutoSize = true;
            this.lbl_TorneoPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TorneoPrograma.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TorneoPrograma.Location = new System.Drawing.Point(32, 143);
            this.lbl_TorneoPrograma.Name = "lbl_TorneoPrograma";
            this.lbl_TorneoPrograma.Size = new System.Drawing.Size(79, 24);
            this.lbl_TorneoPrograma.TabIndex = 36;
            this.lbl_TorneoPrograma.Text = "Torneo";
            this.lbl_TorneoPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_FechaPrograma
            // 
            this.lbl_FechaPrograma.AutoSize = true;
            this.lbl_FechaPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_FechaPrograma.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaPrograma.Location = new System.Drawing.Point(32, 208);
            this.lbl_FechaPrograma.Name = "lbl_FechaPrograma";
            this.lbl_FechaPrograma.Size = new System.Drawing.Size(69, 24);
            this.lbl_FechaPrograma.TabIndex = 35;
            this.lbl_FechaPrograma.Text = "Fecha";
            this.lbl_FechaPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_HoraPrograma
            // 
            this.lbl_HoraPrograma.AutoSize = true;
            this.lbl_HoraPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_HoraPrograma.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraPrograma.Location = new System.Drawing.Point(32, 286);
            this.lbl_HoraPrograma.Name = "lbl_HoraPrograma";
            this.lbl_HoraPrograma.Size = new System.Drawing.Size(61, 24);
            this.lbl_HoraPrograma.TabIndex = 34;
            this.lbl_HoraPrograma.Text = "Hora";
            this.lbl_HoraPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_EquipoLocal
            // 
            this.lbl_EquipoLocal.AutoSize = true;
            this.lbl_EquipoLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EquipoLocal.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EquipoLocal.Location = new System.Drawing.Point(32, 345);
            this.lbl_EquipoLocal.Name = "lbl_EquipoLocal";
            this.lbl_EquipoLocal.Size = new System.Drawing.Size(80, 48);
            this.lbl_EquipoLocal.TabIndex = 33;
            this.lbl_EquipoLocal.Text = "Equipo\r\nLocal";
            // 
            // lbl_UbicacionPrograma
            // 
            this.lbl_UbicacionPrograma.AutoSize = true;
            this.lbl_UbicacionPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_UbicacionPrograma.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UbicacionPrograma.Location = new System.Drawing.Point(32, 535);
            this.lbl_UbicacionPrograma.Name = "lbl_UbicacionPrograma";
            this.lbl_UbicacionPrograma.Size = new System.Drawing.Size(108, 24);
            this.lbl_UbicacionPrograma.TabIndex = 32;
            this.lbl_UbicacionPrograma.Text = "Ubicación";
            this.lbl_UbicacionPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_IdPrograma
            // 
            this.lbl_IdPrograma.AutoSize = true;
            this.lbl_IdPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_IdPrograma.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdPrograma.Location = new System.Drawing.Point(32, 45);
            this.lbl_IdPrograma.Name = "lbl_IdPrograma";
            this.lbl_IdPrograma.Size = new System.Drawing.Size(107, 48);
            this.lbl_IdPrograma.TabIndex = 30;
            this.lbl_IdPrograma.Text = "ID\r\nPrograma";
            this.lbl_IdPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_EquipoVisitan
            // 
            this.lbl_EquipoVisitan.AutoSize = true;
            this.lbl_EquipoVisitan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EquipoVisitan.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EquipoVisitan.Location = new System.Drawing.Point(32, 439);
            this.lbl_EquipoVisitan.Name = "lbl_EquipoVisitan";
            this.lbl_EquipoVisitan.Size = new System.Drawing.Size(101, 48);
            this.lbl_EquipoVisitan.TabIndex = 46;
            this.lbl_EquipoVisitan.Text = "Equipo\r\nVisitante";
            this.lbl_EquipoVisitan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_UbicacionPrograma
            // 
            this.txt_UbicacionPrograma.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_UbicacionPrograma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UbicacionPrograma.Location = new System.Drawing.Point(157, 535);
            this.txt_UbicacionPrograma.Name = "txt_UbicacionPrograma";
            this.txt_UbicacionPrograma.Size = new System.Drawing.Size(191, 26);
            this.txt_UbicacionPrograma.TabIndex = 47;
            this.txt_UbicacionPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1112, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 74);
            this.button1.TabIndex = 75;
            this.button1.Text = "Actualizar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarProgramacion
            // 
            this.btnLimpiarProgramacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnLimpiarProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProgramacion.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProgramacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarProgramacion.Image")));
            this.btnLimpiarProgramacion.Location = new System.Drawing.Point(677, 594);
            this.btnLimpiarProgramacion.Name = "btnLimpiarProgramacion";
            this.btnLimpiarProgramacion.Size = new System.Drawing.Size(167, 74);
            this.btnLimpiarProgramacion.TabIndex = 77;
            this.btnLimpiarProgramacion.Text = "Limpiar";
            this.btnLimpiarProgramacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarProgramacion.UseVisualStyleBackColor = false;
            this.btnLimpiarProgramacion.Click += new System.EventHandler(this.btnLimpiarProgramacion_Click);
            // 
            // btnEliminarProgramacion
            // 
            this.btnEliminarProgramacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEliminarProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProgramacion.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProgramacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProgramacion.Image")));
            this.btnEliminarProgramacion.Location = new System.Drawing.Point(893, 594);
            this.btnEliminarProgramacion.Name = "btnEliminarProgramacion";
            this.btnEliminarProgramacion.Size = new System.Drawing.Size(167, 74);
            this.btnEliminarProgramacion.TabIndex = 78;
            this.btnEliminarProgramacion.Text = "Eliminar";
            this.btnEliminarProgramacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarProgramacion.UseVisualStyleBackColor = false;
            this.btnEliminarProgramacion.Click += new System.EventHandler(this.btnEliminarProgramacion_Click);
            // 
            // FRM_Programacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1864, 680);
            this.Controls.Add(this.btnEliminarProgramacion);
            this.Controls.Add(this.btnLimpiarProgramacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_UbicacionPrograma);
            this.Controls.Add(this.lbl_EquipoVisitan);
            this.Controls.Add(this.btn_GuardarTorneo);
            this.Controls.Add(this.txt_FechaPrograma);
            this.Controls.Add(this.txt_NombreTorneo);
            this.Controls.Add(this.txt_IdPrograma);
            this.Controls.Add(this.txt_EquipoVisitante);
            this.Controls.Add(this.txt_EquipoLocal);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.dgvProgramacion);
            this.Controls.Add(this.txt_HoraProgramaci);
            this.Controls.Add(this.lbl_TorneoPrograma);
            this.Controls.Add(this.lbl_FechaPrograma);
            this.Controls.Add(this.lbl_HoraPrograma);
            this.Controls.Add(this.lbl_EquipoLocal);
            this.Controls.Add(this.lbl_UbicacionPrograma);
            this.Controls.Add(this.lbl_IdPrograma);
            this.Name = "FRM_Programacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Programacion";
            this.Load += new System.EventHandler(this.FRM_Programacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarTorneo;
        private System.Windows.Forms.TextBox txt_FechaPrograma;
        private System.Windows.Forms.TextBox txt_NombreTorneo;
        private System.Windows.Forms.TextBox txt_IdPrograma;
        private System.Windows.Forms.TextBox txt_EquipoVisitante;
        private System.Windows.Forms.TextBox txt_EquipoLocal;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.DataGridView dgvProgramacion;
        private System.Windows.Forms.TextBox txt_HoraProgramaci;
        private System.Windows.Forms.Label lbl_TorneoPrograma;
        private System.Windows.Forms.Label lbl_FechaPrograma;
        private System.Windows.Forms.Label lbl_HoraPrograma;
        private System.Windows.Forms.Label lbl_EquipoLocal;
        private System.Windows.Forms.Label lbl_UbicacionPrograma;
        private System.Windows.Forms.Label lbl_IdPrograma;
        private System.Windows.Forms.Label lbl_EquipoVisitan;
        private System.Windows.Forms.TextBox txt_UbicacionPrograma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiarProgramacion;
        private System.Windows.Forms.Button btnEliminarProgramacion;
    }
}