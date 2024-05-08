﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD1
{
    public partial class FRM_Contenido : Form
    {
        public FRM_Contenido()
        {
            InitializeComponent();
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Show();
        }

        private void btn_Torneo_Click(object sender, EventArgs e)
        {
            FRM_Torneo torneo = new FRM_Torneo();
            torneo.Show();
        }

        private void btn_Programacion_Click(object sender, EventArgs e)
        {
            FRM_Programacion Programacion = new FRM_Programacion();
            Programacion.Show();
        }

        private void btn_RegistroJugador_Click(object sender, EventArgs e)
        {
            FRM_RegistroJugador RegistroJugador = new FRM_RegistroJugador();
            RegistroJugador.Show();
        }

        private void btn_Resultados_Click(object sender, EventArgs e)
        {
            FRM_Resultados Resultados = new FRM_Resultados();
            Resultados.Show();
        }

        private void btn_RegistrarEquipo_Click(object sender, EventArgs e)
        {
            FRM_RegistroEquipos RegistrarEquipos = new FRM_RegistroEquipos();
            RegistrarEquipos.Show();
        }

        private void btn_Posiciones_Click(object sender, EventArgs e)
        {
            FRM_Posiciones Posiciones = new FRM_Posiciones();
            Posiciones.Show();
        }
    }
}
