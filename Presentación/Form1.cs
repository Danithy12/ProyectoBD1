using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            FRM_Contenido Contenido = new FRM_Contenido();
            Contenido.Show();

            this.Hide();
        }

        private void btn_Historial_Click(object sender, EventArgs e)
        {
            FRM_Historial Historial = new FRM_Historial();
            Historial.Show();

            this.Hide();
        }
    }
}
