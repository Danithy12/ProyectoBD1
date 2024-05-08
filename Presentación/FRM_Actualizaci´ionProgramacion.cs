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
    public partial class FRM_Actualizaci_ionProgramacion : Form
    {
        public FRM_Actualizaci_ionProgramacion()
        {
            InitializeComponent();
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            FRM_Programacion Programacion = new FRM_Programacion();
            Programacion.Show();
        }

        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_IdActualizacionPrograma.Text) ||
                string.IsNullOrWhiteSpace(txt_Id_Programacion.Text) ||
                string.IsNullOrWhiteSpace(txt_NuevaFechaPrograma.Text) ||
                string.IsNullOrWhiteSpace(txt_NuevaUbicacionPrograma.Text)||
                string.IsNullOrWhiteSpace(txt_MensajeActuProgramacion.Text)
                )
            
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                ClsActualizacionProgramacion ActuProgramacion = new ClsActualizacionProgramacion();

                ActuProgramacion.Nueva_Fecha = Convert.ToDateTime(txt_NuevaFechaPrograma.Text);
                ActuProgramacion.Nueva_Ubicacion = txt_NuevaUbicacionPrograma.Text;
                ActuProgramacion.Nueva_Hora = Convert.ToDateTime(txt_NuevaHora.Text);
                ActuProgramacion.Mensaje = txt_MensajeActuProgramacion.Text;

                if (dgvActualizacionProgramacion.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvActualizacionProgramacion.CurrentRow.Cells["id_Actualizacion_Programacion"].Value);

                    if (id != null) //Si  existe un ID el boton modificará los datos
                    {
                        ActuProgramacion.id_Actualizacion_Programacion = id;
                        int Resulta = ClsProcedimientos.ModificarActualizacionProgramacion(ActuProgramacion);

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
                    int Resulta = ClsProcedimientos.GuardarActualizacionProgramacion(ActuProgramacion);

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

        private void FRM_Actualizaci_ionProgramacion_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            refreshPantalla();
        }
        public void refreshPantalla()
        {
            dgvActualizacionProgramacion.DataSource = ClsProcedimientos.PresentarRegistroTorneo();
        }

        private void dgvActualizacionProgramacion_SelectionChanged(object sender, EventArgs e)
        {
            txt_IdActualizacionPrograma.Text = Convert.ToString(dgvActualizacionProgramacion.CurrentRow.Cells["id_Actualizacion_Programacion"].Value);
            txt_Id_Programacion.Text = Convert.ToString(dgvActualizacionProgramacion.CurrentRow.Cells["id_Programacion"].Value);
            txt_NuevaFechaPrograma.Text = Convert.ToString(dgvActualizacionProgramacion.CurrentRow.Cells["Nueva_Fecha"].Value);
            txt_NuevaUbicacionPrograma.Text = Convert.ToString(dgvActualizacionProgramacion.CurrentRow.Cells["Nueva_Ubicacion"].Value);
            txt_NuevaHora.Text = Convert.ToString(dgvActualizacionProgramacion.CurrentRow.Cells["Nueva_Hora"].Value);
            txt_MensajeActuProgramacion.Text = Convert.ToString(dgvActualizacionProgramacion.CurrentRow.Cells["Mensaje"].Value);
        }

        private void btnLimpiarProgramacion_Click(object sender, EventArgs e)
        {
            txt_IdActualizacionPrograma.Clear();
            txt_Id_Programacion.Clear();
            txt_NuevaFechaPrograma.Clear();
            txt_NuevaUbicacionPrograma.Clear();
            txt_MensajeActuProgramacion.Clear();
        }

        private void btnEliminarProgramacion_Click(object sender, EventArgs e)
        {
            if (dgvActualizacionProgramacion.SelectedRows.Count == 1)
            {
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvActualizacionProgramacion.CurrentRow.Cells["id_Torneo"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarActualizacionProgramacion(id);

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
