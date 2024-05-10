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
    public partial class RegistroEquiposs : Form
    {
        public RegistroEquiposs()
        {
            InitializeComponent();
            CargarTorneo();
            CargarCategoria();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            //Variable que guardará la cantidad de jugadores
            int CantidadJugadores;
            // Booleano para comprobar que el número ingresado sea mayor que 0
            bool NumeroValido = int.TryParse(txt_CantidadJugadores.Text,out CantidadJugadores);
            if (!NumeroValido || CantidadJugadores <= 0)
            {
                MessageBox.Show("Carechimba como putas va a jugar con " + CantidadJugadores + " jugadores"," Error de validación"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_CantidadJugadores.Text) ||
                string.IsNullOrWhiteSpace(cbo_CargarCategoria.Text) ||
                string.IsNullOrWhiteSpace(cbo_CargarTorneo.Text) ||
                string.IsNullOrWhiteSpace(txt_Nombre_Equipo.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados ");
            }
            else
            {

                ClsRegistroEquipo Equipo = new ClsRegistroEquipo();

                Equipo.Nombre = txt_Nombre_Equipo.Text;
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
                    int Resulta = ClsProcedimientos.GuardarEquipo(Equipo, cbo_CargarTorneo.Text);

                    if (Resulta > 0)
                    {
                        MessageBox.Show("Datos guardados con éxito");
                        refreshPantalla();
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


            dgvRegistroEquipos.DataSource =  ClsProcedimientos.PresentarRegistroEquipo();

            txt_IdEquipo.Enabled = false;
            txt_IdTorneo.Enabled = false;
        }
        public void refreshPantalla()
        {
            dgvRegistroEquipos.DataSource = ClsProcedimientos.PresentarRegistroEquipo();
        }
        private void btnLimpiarEquipos_Click(object sender, EventArgs e)
        {
            txt_IdEquipo.Clear();
            txt_IdTorneo.Clear();
            txt_CantidadJugadores.Clear();
            txt_Patrocinadores_Equipo.Clear();
            txt_Nombre_Equipo.Clear();
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
            }
        }

        private void CargarTorneo()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SELECT * FROM TORNEOS WHERE Estado = 0", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    cbo_CargarTorneo.Items.Add(Lector[0].ToString());
                }
                cbo_CargarTorneo.Items.Insert(0, "-Seleccione Equipo-");
                cbo_CargarTorneo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }

        private void CargarCategoria()
        {
            Conexion.Open();

            SqlCommand Comando = new SqlCommand("SELECT * FROM CATEGORIAS", Conexion);

            SqlDataReader Leer = Comando.ExecuteReader();
            while (Leer.Read())
            {
                cbo_CargarCategoria.Items.Add(Leer[0].ToString());
                cbo_CargarCategoria.Items.Add(Leer[1].ToString());
                cbo_CargarCategoria.Items.Add(Leer[2].ToString());
                cbo_CargarCategoria.Items.Add(Leer[3].ToString());
            }


            Conexion.Close();

            cbo_CargarCategoria.Items.Insert(0, "-Seleccione categoría-");
            cbo_CargarCategoria.SelectedIndex = 0;
        }
    }
}
