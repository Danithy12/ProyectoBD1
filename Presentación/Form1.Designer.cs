namespace ProyectoBD1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Presentación = new System.Windows.Forms.Label();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Historial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.lbl_Presentación);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 70);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Presentación
            // 
            this.lbl_Presentación.AutoSize = true;
            this.lbl_Presentación.Font = new System.Drawing.Font("Modern No. 20", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Presentación.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Presentación.Location = new System.Drawing.Point(24, 23);
            this.lbl_Presentación.Name = "lbl_Presentación";
            this.lbl_Presentación.Size = new System.Drawing.Size(813, 34);
            this.lbl_Presentación.TabIndex = 0;
            this.lbl_Presentación.Text = "SISTEMA DE REGISTRO DE EVENTOS DE FÚTBOL";
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("Modern No. 20", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(747, 490);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(167, 74);
            this.btn_SalirPresentacion.TabIndex = 1;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Iniciar.Image")));
            this.btn_Iniciar.Location = new System.Drawing.Point(12, 101);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(427, 141);
            this.btn_Iniciar.TabIndex = 2;
            this.btn_Iniciar.Text = "Registrar";
            this.btn_Iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Iniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Historial
            // 
            this.btn_Historial.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historial.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Historial.Image = ((System.Drawing.Image)(resources.GetObject("btn_Historial.Image")));
            this.btn_Historial.Location = new System.Drawing.Point(487, 101);
            this.btn_Historial.Name = "btn_Historial";
            this.btn_Historial.Size = new System.Drawing.Size(427, 141);
            this.btn_Historial.TabIndex = 3;
            this.btn_Historial.Text = "Historial De Eventos";
            this.btn_Historial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Historial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Historial.UseVisualStyleBackColor = false;
            this.btn_Historial.Click += new System.EventHandler(this.btn_Historial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(487, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(427, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 576);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Historial);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Presentación;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Historial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

