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
    public partial class FRM_ActualizacionRegistroJugador : Form
    {
        public FRM_ActualizacionRegistroJugador()
        {
            InitializeComponent();
        }
        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            FRM_RegistroJugador RegistroJugador = new FRM_RegistroJugador();
            RegistroJugador.Show();
        }

        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Id_ActualizacionJugador.Text)||
                string.IsNullOrWhiteSpace(txt_idJugador.Text)||
                string.IsNullOrWhiteSpace(txt_NuevoNombreJugador.Text)||
                string.IsNullOrWhiteSpace(txt_NuevoApellidoJugador.Text)||
                string.IsNullOrWhiteSpace(txt_NuevoDocumentoJugador.Text)||
                string.IsNullOrWhiteSpace(txt_NuevaEdadJugador.Text)||
                string.IsNullOrWhiteSpace(txt_NuevoGeneroJugador.Text)||
                string.IsNullOrWhiteSpace(txt_NuevoTeleJugador.Text)||
                string.IsNullOrWhiteSpace(txt_NuevoCorreoJugador.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                ClsActualizacionJugador ActuJugador = new ClsActualizacionJugador();
                ActuJugador.Nombre = txt_NuevoNombreJugador.Text;
                ActuJugador.Apellido = txt_NuevoApellidoJugador.Text;
                ActuJugador.Documento = txt_NuevoDocumentoJugador.Text;
                ActuJugador.Edad = Convert.ToInt32(txt_NuevaEdadJugador.Text);
                ActuJugador.Genero = txt_NuevoGeneroJugador.Text;
                ActuJugador.Telefono = txt_NuevoTeleJugador.Text;
                ActuJugador.Correo = txt_NuevoCorreoJugador.Text;

                if (dgvRegistroActualizacionJugador.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvRegistroActualizacionJugador.CurrentRow.Cells["id_Actualizacion_JUGADOR"].Value);

                    if (id != null) //Si  existe un ID el boton modificará los datos
                    {
                        ActuJugador.id_Actualizacion_JUGADOR = id;
                        int Resulta = ClsProcedimientos.ModificarRegistroActualizacionJugador(ActuJugador);

                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos modificados con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar los datos");
                        }
                        

                    }
                    else
                    {
                        int Resulta = ClsProcedimientos.GuardarActualizacionJugador(ActuJugador);

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
            }
            refreshPantalla();
        }
        private void FRM_ActualizacionRegistroJugador_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            refreshPantalla();
        }
        public void refreshPantalla()
        {
            dgvRegistroActualizacionJugador.DataSource = ClsProcedimientos.PresentarRegistroTorneo();
        }

        private void dgvRegistroActualizacionJugador_SelectionChanged(object sender, EventArgs e)
        {
            txt_Id_ActualizacionJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["id_Actualizacion_JUGADOR"].Value);
            txt_idJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["id_Jugador"].Value);
            txt_NuevoNombreJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["Nombre"].Value);
            txt_NuevoApellidoJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["Apellido"].Value);
            txt_NuevoDocumentoJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["Documento"].Value);
            txt_NuevaEdadJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["Edad"].Value);
            txt_NuevoGeneroJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["Genero"].Value);
            txt_NuevoTeleJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["Telefono"].Value);
            txt_NuevoCorreoJugador.Text = Convert.ToString(dgvRegistroActualizacionJugador.CurrentRow.Cells["Correo"].Value);
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            txt_Id_ActualizacionJugador.Clear();
            txt_idJugador.Clear();
            txt_NuevoNombreJugador.Clear();
            txt_NuevoApellidoJugador.Clear();
            txt_NuevoDocumentoJugador.Clear();
            txt_NuevoDocumentoJugador.Clear();
            txt_NuevaEdadJugador.Clear();
            txt_NuevoGeneroJugador.Clear();
            txt_NuevoTeleJugador.Clear();
            txt_NuevoCorreoJugador.Clear();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            if (dgvRegistroActualizacionJugador.SelectedRows.Count == 1)
            {
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvRegistroActualizacionJugador.CurrentRow.Cells["id_Actualizacion_JUGADOR"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarRegistroActualizacionJugador(id);

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
