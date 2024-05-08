namespace ProyectoBD1
{
    partial class FRM_ActualizacionRegistroJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ActualizacionRegistroJugador));
            this.txt_NuevoApellidoJugador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.txt_Id_ActualizacionJugador = new System.Windows.Forms.TextBox();
            this.txt_idJugador = new System.Windows.Forms.TextBox();
            this.txt_NuevoCorreoJugador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_EquipoVisitan = new System.Windows.Forms.Label();
            this.lbl_Id_Jugador = new System.Windows.Forms.Label();
            this.lbl_HoraPrograma = new System.Windows.Forms.Label();
            this.lbl_EquipoLocal = new System.Windows.Forms.Label();
            this.lbl_UbicacionPrograma = new System.Windows.Forms.Label();
            this.lbl_ActualizacionJugador = new System.Windows.Forms.Label();
            this.btn_GuardarTorneo = new System.Windows.Forms.Button();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.dgvRegistroActualizacionJugador = new System.Windows.Forms.DataGridView();
            this.txt_NuevoTeleJugador = new System.Windows.Forms.TextBox();
            this.txt_NuevoNombreJugador = new System.Windows.Forms.TextBox();
            this.txt_NuevoGeneroJugador = new System.Windows.Forms.TextBox();
            this.txt_NuevoDocumentoJugador = new System.Windows.Forms.TextBox();
            this.txt_NuevaEdadJugador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroActualizacionJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NuevoApellidoJugador
            // 
            this.txt_NuevoApellidoJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NuevoApellidoJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoApellidoJugador.Location = new System.Drawing.Point(315, 145);
            this.txt_NuevoApellidoJugador.Name = "txt_NuevoApellidoJugador";
            this.txt_NuevoApellidoJugador.Size = new System.Drawing.Size(191, 26);
            this.txt_NuevoApellidoJugador.TabIndex = 104;
            this.txt_NuevoApellidoJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnModificarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarJugador.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarJugador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarJugador.Image")));
            this.btnModificarJugador.Location = new System.Drawing.Point(781, 587);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(167, 74);
            this.btnModificarJugador.TabIndex = 102;
            this.btnModificarJugador.Text = "Limpiar";
            this.btnModificarJugador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarJugador.UseVisualStyleBackColor = false;
            this.btnModificarJugador.Click += new System.EventHandler(this.btnModificarJugador_Click);
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEliminarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarJugador.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarJugador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarJugador.Image")));
            this.btnEliminarJugador.Location = new System.Drawing.Point(1056, 587);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(167, 74);
            this.btnEliminarJugador.TabIndex = 101;
            this.btnEliminarJugador.Text = "Eliminar";
            this.btnEliminarJugador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarJugador.UseVisualStyleBackColor = false;
            this.btnEliminarJugador.Click += new System.EventHandler(this.btnEliminarJugador_Click);
            // 
            // txt_Id_ActualizacionJugador
            // 
            this.txt_Id_ActualizacionJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_Id_ActualizacionJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_ActualizacionJugador.Location = new System.Drawing.Point(26, 60);
            this.txt_Id_ActualizacionJugador.Name = "txt_Id_ActualizacionJugador";
            this.txt_Id_ActualizacionJugador.Size = new System.Drawing.Size(84, 26);
            this.txt_Id_ActualizacionJugador.TabIndex = 100;
            this.txt_Id_ActualizacionJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_idJugador
            // 
            this.txt_idJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_idJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idJugador.Location = new System.Drawing.Point(41, 145);
            this.txt_idJugador.Name = "txt_idJugador";
            this.txt_idJugador.Size = new System.Drawing.Size(88, 26);
            this.txt_idJugador.TabIndex = 98;
            this.txt_idJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NuevoCorreoJugador
            // 
            this.txt_NuevoCorreoJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NuevoCorreoJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoCorreoJugador.Location = new System.Drawing.Point(1250, 102);
            this.txt_NuevoCorreoJugador.Name = "txt_NuevoCorreoJugador";
            this.txt_NuevoCorreoJugador.Size = new System.Drawing.Size(191, 26);
            this.txt_NuevoCorreoJugador.TabIndex = 97;
            this.txt_NuevoCorreoJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(952, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "Telefono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1312, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "Correo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_EquipoVisitan
            // 
            this.lbl_EquipoVisitan.AutoSize = true;
            this.lbl_EquipoVisitan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EquipoVisitan.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EquipoVisitan.Location = new System.Drawing.Point(695, 101);
            this.lbl_EquipoVisitan.Name = "lbl_EquipoVisitan";
            this.lbl_EquipoVisitan.Size = new System.Drawing.Size(61, 24);
            this.lbl_EquipoVisitan.TabIndex = 94;
            this.lbl_EquipoVisitan.Text = "Edad";
            this.lbl_EquipoVisitan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Id_Jugador
            // 
            this.lbl_Id_Jugador.AutoSize = true;
            this.lbl_Id_Jugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Id_Jugador.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Jugador.Location = new System.Drawing.Point(12, 94);
            this.lbl_Id_Jugador.Name = "lbl_Id_Jugador";
            this.lbl_Id_Jugador.Size = new System.Drawing.Size(86, 48);
            this.lbl_Id_Jugador.TabIndex = 93;
            this.lbl_Id_Jugador.Text = "ID\r\n Equipo";
            this.lbl_Id_Jugador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_HoraPrograma
            // 
            this.lbl_HoraPrograma.AutoSize = true;
            this.lbl_HoraPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_HoraPrograma.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraPrograma.Location = new System.Drawing.Point(353, 13);
            this.lbl_HoraPrograma.Name = "lbl_HoraPrograma";
            this.lbl_HoraPrograma.Size = new System.Drawing.Size(86, 24);
            this.lbl_HoraPrograma.TabIndex = 92;
            this.lbl_HoraPrograma.Text = "Nombre";
            this.lbl_HoraPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_EquipoLocal
            // 
            this.lbl_EquipoLocal.AutoSize = true;
            this.lbl_EquipoLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EquipoLocal.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EquipoLocal.Location = new System.Drawing.Point(656, 13);
            this.lbl_EquipoLocal.Name = "lbl_EquipoLocal";
            this.lbl_EquipoLocal.Size = new System.Drawing.Size(120, 24);
            this.lbl_EquipoLocal.TabIndex = 91;
            this.lbl_EquipoLocal.Text = "Documento";
            this.lbl_EquipoLocal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UbicacionPrograma
            // 
            this.lbl_UbicacionPrograma.AutoSize = true;
            this.lbl_UbicacionPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_UbicacionPrograma.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UbicacionPrograma.Location = new System.Drawing.Point(952, 13);
            this.lbl_UbicacionPrograma.Name = "lbl_UbicacionPrograma";
            this.lbl_UbicacionPrograma.Size = new System.Drawing.Size(80, 24);
            this.lbl_UbicacionPrograma.TabIndex = 90;
            this.lbl_UbicacionPrograma.Text = "Género";
            this.lbl_UbicacionPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ActualizacionJugador
            // 
            this.lbl_ActualizacionJugador.AutoSize = true;
            this.lbl_ActualizacionJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ActualizacionJugador.Font = new System.Drawing.Font("Modern No. 20", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActualizacionJugador.Location = new System.Drawing.Point(-3, 9);
            this.lbl_ActualizacionJugador.Name = "lbl_ActualizacionJugador";
            this.lbl_ActualizacionJugador.Size = new System.Drawing.Size(146, 48);
            this.lbl_ActualizacionJugador.TabIndex = 89;
            this.lbl_ActualizacionJugador.Text = "ID\r\nActualizacion";
            this.lbl_ActualizacionJugador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_GuardarTorneo
            // 
            this.btn_GuardarTorneo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_GuardarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarTorneo.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarTorneo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarTorneo.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarTorneo.Image")));
            this.btn_GuardarTorneo.Location = new System.Drawing.Point(475, 587);
            this.btn_GuardarTorneo.Name = "btn_GuardarTorneo";
            this.btn_GuardarTorneo.Size = new System.Drawing.Size(167, 74);
            this.btn_GuardarTorneo.TabIndex = 88;
            this.btn_GuardarTorneo.Text = "Guardar";
            this.btn_GuardarTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarTorneo.UseVisualStyleBackColor = false;
            this.btn_GuardarTorneo.Click += new System.EventHandler(this.btn_GuardarTorneo_Click);
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(1302, 587);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(167, 74);
            this.btn_SalirPresentacion.TabIndex = 86;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // dgvRegistroActualizacionJugador
            // 
            this.dgvRegistroActualizacionJugador.AccessibleDescription = "Act";
            this.dgvRegistroActualizacionJugador.AllowUserToAddRows = false;
            this.dgvRegistroActualizacionJugador.AllowUserToDeleteRows = false;
            this.dgvRegistroActualizacionJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroActualizacionJugador.Location = new System.Drawing.Point(41, 186);
            this.dgvRegistroActualizacionJugador.Name = "dgvRegistroActualizacionJugador";
            this.dgvRegistroActualizacionJugador.ReadOnly = true;
            this.dgvRegistroActualizacionJugador.RowHeadersWidth = 62;
            this.dgvRegistroActualizacionJugador.RowTemplate.Height = 28;
            this.dgvRegistroActualizacionJugador.Size = new System.Drawing.Size(1428, 362);
            this.dgvRegistroActualizacionJugador.TabIndex = 85;
            this.dgvRegistroActualizacionJugador.SelectionChanged += new System.EventHandler(this.dgvRegistroActualizacionJugador_SelectionChanged);
            // 
            // txt_NuevoTeleJugador
            // 
            this.txt_NuevoTeleJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NuevoTeleJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoTeleJugador.Location = new System.Drawing.Point(905, 145);
            this.txt_NuevoTeleJugador.Name = "txt_NuevoTeleJugador";
            this.txt_NuevoTeleJugador.Size = new System.Drawing.Size(191, 26);
            this.txt_NuevoTeleJugador.TabIndex = 84;
            this.txt_NuevoTeleJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NuevoNombreJugador
            // 
            this.txt_NuevoNombreJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NuevoNombreJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoNombreJugador.Location = new System.Drawing.Point(315, 47);
            this.txt_NuevoNombreJugador.Name = "txt_NuevoNombreJugador";
            this.txt_NuevoNombreJugador.Size = new System.Drawing.Size(191, 26);
            this.txt_NuevoNombreJugador.TabIndex = 83;
            this.txt_NuevoNombreJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NuevoGeneroJugador
            // 
            this.txt_NuevoGeneroJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NuevoGeneroJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoGeneroJugador.Location = new System.Drawing.Point(905, 47);
            this.txt_NuevoGeneroJugador.Name = "txt_NuevoGeneroJugador";
            this.txt_NuevoGeneroJugador.Size = new System.Drawing.Size(191, 26);
            this.txt_NuevoGeneroJugador.TabIndex = 82;
            this.txt_NuevoGeneroJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NuevoDocumentoJugador
            // 
            this.txt_NuevoDocumentoJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NuevoDocumentoJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoDocumentoJugador.Location = new System.Drawing.Point(624, 47);
            this.txt_NuevoDocumentoJugador.Name = "txt_NuevoDocumentoJugador";
            this.txt_NuevoDocumentoJugador.Size = new System.Drawing.Size(191, 26);
            this.txt_NuevoDocumentoJugador.TabIndex = 81;
            this.txt_NuevoDocumentoJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NuevaEdadJugador
            // 
            this.txt_NuevaEdadJugador.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_NuevaEdadJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevaEdadJugador.Location = new System.Drawing.Point(624, 145);
            this.txt_NuevaEdadJugador.Name = "txt_NuevaEdadJugador";
            this.txt_NuevaEdadJugador.Size = new System.Drawing.Size(191, 26);
            this.txt_NuevaEdadJugador.TabIndex = 80;
            this.txt_NuevaEdadJugador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_ActualizacionRegistroJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 692);
            this.Controls.Add(this.txt_NuevoApellidoJugador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificarJugador);
            this.Controls.Add(this.btnEliminarJugador);
            this.Controls.Add(this.txt_Id_ActualizacionJugador);
            this.Controls.Add(this.txt_idJugador);
            this.Controls.Add(this.txt_NuevoCorreoJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_EquipoVisitan);
            this.Controls.Add(this.lbl_Id_Jugador);
            this.Controls.Add(this.lbl_HoraPrograma);
            this.Controls.Add(this.lbl_EquipoLocal);
            this.Controls.Add(this.lbl_UbicacionPrograma);
            this.Controls.Add(this.lbl_ActualizacionJugador);
            this.Controls.Add(this.btn_GuardarTorneo);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.dgvRegistroActualizacionJugador);
            this.Controls.Add(this.txt_NuevoTeleJugador);
            this.Controls.Add(this.txt_NuevoNombreJugador);
            this.Controls.Add(this.txt_NuevoGeneroJugador);
            this.Controls.Add(this.txt_NuevoDocumentoJugador);
            this.Controls.Add(this.txt_NuevaEdadJugador);
            this.Name = "FRM_ActualizacionRegistroJugador";
            this.Text = "FRM_ActualizacionRegistroJugador";
            this.Load += new System.EventHandler(this.FRM_ActualizacionRegistroJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroActualizacionJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NuevoApellidoJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarJugador;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.TextBox txt_Id_ActualizacionJugador;
        private System.Windows.Forms.TextBox txt_idJugador;
        private System.Windows.Forms.TextBox txt_NuevoCorreoJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_EquipoVisitan;
        private System.Windows.Forms.Label lbl_Id_Jugador;
        private System.Windows.Forms.Label lbl_HoraPrograma;
        private System.Windows.Forms.Label lbl_EquipoLocal;
        private System.Windows.Forms.Label lbl_UbicacionPrograma;
        private System.Windows.Forms.Label lbl_ActualizacionJugador;
        private System.Windows.Forms.Button btn_GuardarTorneo;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.DataGridView dgvRegistroActualizacionJugador;
        private System.Windows.Forms.TextBox txt_NuevoTeleJugador;
        private System.Windows.Forms.TextBox txt_NuevoNombreJugador;
        private System.Windows.Forms.TextBox txt_NuevoGeneroJugador;
        private System.Windows.Forms.TextBox txt_NuevoDocumentoJugador;
        private System.Windows.Forms.TextBox txt_NuevaEdadJugador;
    }
}