using ProyectoCRUD;
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
    public partial class FRM_RegistroEquipos : Form
    {
        int poc;
        public FRM_RegistroEquipos()
        {
            InitializeComponent();
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            FRM_Contenido Contenido = new FRM_Contenido();
            Contenido.Show();
        }

        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CantidadJugadores.Text) ||
                string.IsNullOrWhiteSpace(txt_Categoría.Text) ||
               // string.IsNullOrWhiteSpace(txt_IdEquipo.Text) ||
                //string.IsNullOrWhiteSpace(txt_IdTorneo.Text) ||
                string.IsNullOrWhiteSpace(txt_NombreEquipo.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados ");
            }
            else
            {
                ClsRegistroEquipo Equipo = new ClsRegistroEquipo();

                Equipo.Nombre = txt_NombreEquipo.Text;
                Equipo.Categoria = txt_Categoría.Text;
                Equipo.Cantidad_Jugadores = Convert.ToInt32(txt_CantidadJugadores.Text);
                Equipo.Patrocinadores = txt_Patrocinadores_Equipo.Text;

                if (dgvRegistroEquipos.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvRegistroEquipos.CurrentRow.Cells["id_Equipo"].Value);

                        if (id != null)
                    {
                        Equipo.id_Equipo = id;
                        int Resulta = ClsProcedimientos.ModificarRegistroEquipo(Equipo);

                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos modificados con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar los datos");
                        }
                    }
                }
                else
                {
                    int Resulta = ClsProcedimientos.GuardarEquipo(Equipo);

                    if (Resulta > 0)
                    {
                        MessageBox.Show("Datos guardados con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar los datos");
                    }
                }

            }
            refreshPantalla();
        }

        private void FRM_RegistroEquipos_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            //txt_IdEquipo.Enabled = false;
            //txt_IdTorneo.Enabled = false;
        }
        public void refreshPantalla()
        {
            dgvRegistroEquipos.DataSource = ClsProcedimientos.PresentarRegistroEquipo();
        }

        private void dgvRegistroEquipos_SelectionChanged(object sender, EventArgs e)
        {
            txt_IdEquipo.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["id_Equipo"].Value);
            txt_IdTorneo.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["id_Torneo"].Value);
            txt_NombreEquipo.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Nombre"].Value);
            txt_Categoría.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Categoria"].Value);
            txt_CantidadJugadores.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Cantidad_Jugadores"].Value);
            txt_Patrocinadores_Equipo.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Patrocinadores"].Value);
        }

        private void btnLimpiarEquipos_Click(object sender, EventArgs e)
        {
            txt_IdEquipo.Clear();
            txt_IdTorneo.Clear();
            txt_NombreEquipo.Clear();
            txt_Categoría.Clear();
            txt_CantidadJugadores.Clear();
            txt_Patrocinadores_Equipo.Clear();
        }

        private void btnEliminarEquipos_Click(object sender, EventArgs e)
        {
            if (dgvRegistroEquipos.SelectedRows.Count == 1)
            {
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvRegistroEquipos.CurrentRow.Cells["id_Equipo"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarEquipo(id);

                if (Resultado > 0)
                {
                    MessageBox.Show("Datos eliminados con éxito");
                }
                else
                {
                    MessageBox.Show("Error en la eliminación de datos");
                }
                refreshPantalla();
            }
        }


    }
}
