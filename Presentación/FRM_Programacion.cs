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
    public partial class FRM_Programacion : Form
    {
        int poc;
        public FRM_Programacion()
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
            if (string.IsNullOrWhiteSpace(txt_EquipoLocal.Text) ||
                string.IsNullOrWhiteSpace(txt_EquipoVisitante.Text) ||
                string.IsNullOrWhiteSpace(txt_FechaPrograma.Text) ||
                string.IsNullOrWhiteSpace(txt_HoraProgramaci.Text) ||
                string.IsNullOrWhiteSpace(txt_IdPrograma.Text) ||
                string.IsNullOrWhiteSpace(txt_NombreTorneo.Text) ||
                string.IsNullOrWhiteSpace(txt_UbicacionPrograma.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                ClsProgramacion Programacion = new ClsProgramacion();

                Programacion.Fecha  = txt_FechaPrograma.Text;
                Programacion.Hora = txt_HoraProgramaci.Text;
                Programacion.Ubicacion = txt_UbicacionPrograma.Text;
                Programacion.Equipo_Local = txt_EquipoLocal.Text;
                Programacion.Equipo_Visitante = txt_EquipoVisitante.Text;

                if (dgvProgramacion.SelectedCells.Count == 1)
                {
                    int id = Convert.ToInt32(dgvProgramacion.CurrentRow.Cells["id_Programacion"].Value);

                    if (id != null) //Si  existe un ID el boton modificará los datos
                    {
                        Programacion.id_Programacion = id;
                        int Resulta = ClsProcedimientos.ModificarProgramacion(Programacion);

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
                    int Resulta = ClsProcedimientos.GuardarProgramacion(Programacion);

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

        private void FRM_Programacion_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            refreshPantalla();
        }

        public void refreshPantalla()
        {
            dgvProgramacion.DataSource = ClsProcedimientos.PresentarRegistroTorneo();
        }

        private void dgvProgramacion_SelectionChanged(object sender, EventArgs e)
        {
            txt_IdPrograma.Text = Convert.ToString(dgvProgramacion.CurrentRow.Cells["id_Programacion"].Value);
            txt_NombreTorneo.Text = Convert.ToString(dgvProgramacion.CurrentRow.Cells["id_Torneo"].Value);
            txt_FechaPrograma.Text = Convert.ToString(dgvProgramacion.CurrentRow.Cells["Fecha"].Value);
            txt_HoraProgramaci.Text = Convert.ToString(dgvProgramacion.CurrentRow.Cells["Hora"].Value);
            txt_UbicacionPrograma.Text = Convert.ToString(dgvProgramacion.CurrentRow.Cells["Ubicacion"].Value);
            txt_EquipoLocal.Text = Convert.ToString(dgvProgramacion.CurrentRow.Cells["Equipo_Local"].Value);
            txt_EquipoVisitante.Text = Convert.ToString(dgvProgramacion.CurrentRow.Cells["Equipo_Visitante"].Value);
        }

        private void btnLimpiarProgramacion_Click(object sender, EventArgs e)
        {
            txt_IdPrograma.Clear();
            txt_NombreTorneo.Clear();
            txt_FechaPrograma.Clear();
            txt_HoraProgramaci.Clear();
            txt_UbicacionPrograma.Clear();
            txt_EquipoLocal.Clear();
            txt_EquipoVisitante.Clear();
        }

        private void btnEliminarProgramacion_Click(object sender, EventArgs e)
        {
            if (dgvProgramacion.SelectedRows.Count == 1)
            {
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvProgramacion.CurrentRow.Cells["id_Programacion"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarProgramacion(id);

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
   