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
    public partial class FRM_RegistroJugador : Form
    {
        int poc;
        public FRM_RegistroJugador()
        {
            InitializeComponent();
            CargarEquipo();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            FRM_Contenido Contenido  = new FRM_Contenido();
            Contenido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ActualizacionRegistroJugador ActuaJugador = new FRM_ActualizacionRegistroJugador();
            ActuaJugador.Show();
        }

        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CorreoJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_DocumentoJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_EdadJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_GeneroJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_NombreJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_TeleJugador.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados ");
            }
            else
            {
                ClsRegistroJugador Jugador = new ClsRegistroJugador();

                Jugador.Nombre = txt_NombreJugador.Text;
                Jugador.Apellido = txt_ApellidoJugador.Text;
                Jugador.Documento = txt_DocumentoJugador.Text;
                Jugador.Edad = Convert.ToInt32(txt_EdadJugador.Text);
                Jugador.Genero = txt_GeneroJugador.Text;
                Jugador.Telefono = txt_TeleJugador.Text;
                Jugador.Correo = txt_CorreoJugador.Text;



                if (dgvRegistroJugador.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvRegistroJugador.CurrentRow.Cells["id_Jugador"].Value);

                    if (id != null)
                    {
                        Jugador.id_Jugador = id;
                        int Resultado = ClsProcedimientos.ModificarRegistroJugador(Jugador);

                        if (Resultado > 0)
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
                    int Resultado = ClsProcedimientos.GuardarJugador(Jugador);


                    if (Resultado > 0)
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

        private void FRM_RegistroJugador_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            refreshPantalla();

            //txt_Equipo.Enabled = false;
            txt_Id_Jugador.Enabled = false;
        }
        public void refreshPantalla()
        {
            dgvRegistroJugador.DataSource = ClsProcedimientos.PresentarRegistroJugador();
        }

        private void dgvRegistroJugador_SelectionChanged(object sender, EventArgs e)
        {
            txt_Id_Jugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["id_Jugador"].Value);
            txt_Equipo.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["id_Equipo"].Value);
            txt_NombreJugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["Nombre"].Value);
            txt_ApellidoJugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["Apellido"].Value);
            txt_DocumentoJugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["Documento"].Value);
            txt_EdadJugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["Edad"].Value);
            txt_GeneroJugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["Genero"].Value);
            txt_TeleJugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["Telefono"].Value);
            txt_CorreoJugador.Text = Convert.ToString(dgvRegistroJugador.CurrentRow.Cells["Correo"].Value);
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            txt_ApellidoJugador.Clear();
            txt_CorreoJugador.Clear();
            txt_DocumentoJugador.Clear();
            txt_EdadJugador.Clear();
            txt_Equipo.Clear();
            txt_GeneroJugador.Clear();
            txt_Id_Jugador.Clear();
            txt_NombreJugador.Clear();
            txt_TeleJugador.Clear();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            if (dgvRegistroJugador.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvRegistroJugador.CurrentRow.Cells["id_Jugador"].Value);

                int Resultado = ClsProcedimientos.EliminarRegistroJugador(id);

                if (Resultado == 0)
                {
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

        private void CargarEquipo()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SELECT * FROM REGISTRO_EQUIPO WHERE Estado = 1", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                List<ClsRegistroEquipo> listaTorneos = new List<ClsRegistroEquipo>();
                while (Lector.Read())
                {
                    cbo_Cargar_Equipos.Items.Add(Lector[1].ToString());
                    cbo_Cargar_Equipos.Items.Add(Lector[2].ToString());
                }
                cbo_Cargar_Equipos.Items.Insert(0, "-Selecciones torneo-");
                cbo_Cargar_Equipos.SelectedIndex = 0;
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
    }
}
