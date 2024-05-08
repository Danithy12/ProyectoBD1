using ProyectoCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            CargarTorneosEnComboBox();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
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
                string.IsNullOrWhiteSpace(cbo_CargarCategoria.Text) ||
               // string.IsNullOrWhiteSpace(txt_IdEquipo.Text) ||
                //string.IsNullOrWhiteSpace(txt_IdTorneo.Text) ||
                string.IsNullOrWhiteSpace(cbo_CargarTorneo.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados ");
            }
            else
            {
                ClsRegistroEquipo Equipo = new ClsRegistroEquipo();

                Equipo.Nombre = cbo_CargarTorneo.Text;
                Equipo.Categoria = cbo_CargarCategoria.Text;
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
            cbo_CargarTorneo.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Nombre"].Value);
            cbo_CargarCategoria.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Categoria"].Value);
            txt_CantidadJugadores.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Cantidad_Jugadores"].Value);
            txt_Patrocinadores_Equipo.Text = Convert.ToString(dgvRegistroEquipos.CurrentRow.Cells["Patrocinadores"].Value);
        }

        private void btnLimpiarEquipos_Click(object sender, EventArgs e)
        {
            txt_IdEquipo.Clear();
            txt_IdTorneo.Clear();
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
        private void CargarTorneosEnComboBox()
        {
            try
            {
                List<ClsTorneo> listaTorneos = ClsProcedimientos.ObtenerTorneosActivos();

                // Agrega un elemento al principio de la lista si es necesario.
                listaTorneos.Insert(0, new ClsTorneo { id_Torneo = 0, Nombre_torneo = "--Seleccione un torneo--" });

                cbo_CargarTorneo.DataSource = listaTorneos;
                cbo_CargarTorneo.DisplayMember = "Nombre_torneo";
                cbo_CargarTorneo.ValueMember = "id_Torneo";

                // No es necesario modificar Items directamente después de esto.
                cbo_CargarTorneo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los torneos: " + ex.Message);
            }
        }
        private void btn_CargarTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();

                string Consulta = "SELECT * FROM TORNEOS WHERE Estado = 0";

                SqlCommand Comando = new SqlCommand(Consulta, Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                List<ClsTorneo> listaTorneos = new List<ClsTorneo>();
                while (Lector.Read())
                {
                    ClsTorneo torneo = new ClsTorneo
                    {
                        id_Torneo = Lector.GetInt32(Lector.GetOrdinal("id_Torneo")),
                        Nombre_torneo = Lector.GetString(Lector.GetOrdinal("Nombre_torneo")),
                        // Asegúrate de agregar aquí el resto de las propiedades si es necesario
                    };
                    listaTorneos.Add(torneo);
                }
                Lector.Close();

                // Agrega un elemento al principio de la lista si es necesario.
                listaTorneos.Insert(0, new ClsTorneo { id_Torneo = 0, Nombre_torneo = "--Seleccione un torneo--" });

                cbo_CargarTorneo.DataSource = null; // Limpia el DataSource antes de asignar una nueva lista
                cbo_CargarTorneo.DataSource = listaTorneos;
                cbo_CargarTorneo.DisplayMember = "Nombre_torneo";
                cbo_CargarTorneo.ValueMember = "id_Torneo";

                cbo_CargarTorneo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los torneos: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Open();

            string Consulta = "SELECT * FROM CATEGORIAS";

            SqlCommand Comando = new SqlCommand(Consulta, Conexion);
            SqlDataReader Lector = Comando.ExecuteReader();

            while (Lector.Read())
            {
                cbo_CargarCategoria.Items.Add(Lector.GetString(0));
                cbo_CargarCategoria.Items.Add(Lector.GetString(1));
                cbo_CargarCategoria.Items.Add(Lector.GetString(2));
                cbo_CargarCategoria.Items.Add(Lector.GetString(3));
            }
            Conexion.Close();
        }
    }
}
