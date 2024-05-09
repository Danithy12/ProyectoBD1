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
    public partial class FRM_Torneo : Form
    {
        public FRM_Torneo()
        {
            InitializeComponent();
            CargarCategoria();
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

        //Método que no dejárá guardar los datos hasta que sean ingresados todos, not null
        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboBox_Categoria_Torneo.Text) ||
                string.IsNullOrWhiteSpace(txt_FechaTorneo.Text) ||
                string.IsNullOrWhiteSpace(txt_FechaFinal.Text) ||
                string.IsNullOrWhiteSpace(txt_NombreTorneo.Text) ||
                string.IsNullOrWhiteSpace(txt_UbicacionTorneo.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                //Objeto para agregar los datos
                ClsTorneo torneo = new ClsTorneo();

                torneo.Nombre_torneo = txt_NombreTorneo.Text;
                torneo.Categoria_T = cboBox_Categoria_Torneo.Text;
                torneo.Fecha_Inicio = Convert.ToDateTime(txt_FechaTorneo.Text);
                torneo.Fecha_Final = Convert.ToDateTime(txt_FechaFinal.Text);
                torneo.Ubicacion_T = txt_UbicacionTorneo.Text;
                torneo.Reglas_Especificas = txt_ReglasEspecificas.Text;

                //Condicional para modificar y guardar el id en los datos selecionados
                if (dgvTorneo.SelectedRows.Count == 1)
                {

                
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvTorneo.CurrentRow.Cells["id_Torneo"]. Value);
                    //Fila seleccionada se guarda en variable id pero solo si esta
                   
                    //La tabla tiene CONSTRAINS(SQL) Y no deja modificar las llaves
                    
                    if (id != null) //Si  existe un ID el boton modificará los datos
                    {
                        torneo.id_Torneo = id;
                        int Resulta = ClsProcedimientos.ModificarTorneo(torneo);

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
                else //Si no existe los va a guardar
                {
                    int Resulta = ClsProcedimientos.GuardarTorneo(torneo);

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
            refreshPantalla(); //LLamamos el metodo cuando se guarde

        }

        private void FRM_Torneo_Load(object sender, EventArgs e)
        {
            //Llamamos la connexion en el forms de Torneo
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            refreshPantalla();//Llamamos el metodo cuando se cargue

            //Ocultamos ID para que no se pueda modificar porque esta automatico
            txt_Idtorneo.Enabled = false;

        }
        //Método para que refrescará los datos que se vayan ingresando
        public void refreshPantalla()
        {
            dgvTorneo.DataSource = ClsProcedimientos.PresentarRegistroTorneo();
        }

        //Método para que aparezcan los datos ingresados en los textbox y se puedan modificar
        private void dgvTorneo_SelectionChanged(object sender, EventArgs e)
        {
            txt_Idtorneo.Text = Convert.ToString(dgvTorneo.CurrentRow.Cells["id_Torneo"].Value);
            txt_NombreTorneo.Text = Convert.ToString(dgvTorneo.CurrentRow.Cells["Nombre_torneo"].Value);
            cboBox_Categoria_Torneo.Text = Convert.ToString(dgvTorneo.CurrentRow.Cells["Categoria_T"].Value);
            txt_FechaTorneo.Text = Convert.ToString(dgvTorneo.CurrentRow.Cells["Fecha_Inicio"].Value);
            txt_FechaFinal.Text = Convert.ToString(dgvTorneo.CurrentRow.Cells["Fecha_Final"].Value);
            txt_UbicacionTorneo.Text = Convert.ToString(dgvTorneo.CurrentRow.Cells["Ubicacion_T"].Value);
            txt_ReglasEspecificas.Text = Convert.ToString(dgvTorneo.CurrentRow.Cells["Reglas_Especificas"].Value);

        }

        private void btn_LimpiarTorneo_Click(object sender, EventArgs e)
        {
            txt_Idtorneo.Clear();
            txt_NombreTorneo.Clear();
            txt_FechaTorneo.Clear();
            txt_FechaFinal.Clear();
            txt_UbicacionTorneo.Clear();
            txt_ReglasEspecificas.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvTorneo.SelectedRows.Count == 1)
            {
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvTorneo.CurrentRow.Cells["id_Torneo"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarTorneo(id);

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
        private void CargarCategoria()
        {
            cboBox_Categoria_Torneo.Items.Clear();
            Conexion.Open();

            SqlCommand Comando = new SqlCommand("SELECT * FROM CATEGORIAS", Conexion);

            SqlDataReader Leer = Comando.ExecuteReader();
            while (Leer.Read())
            {
                cboBox_Categoria_Torneo.Items.Add(Leer[0].ToString());
                cboBox_Categoria_Torneo.Items.Add(Leer[1].ToString());
                cboBox_Categoria_Torneo.Items.Add(Leer[2].ToString());
                cboBox_Categoria_Torneo.Items.Add(Leer[3].ToString());
            }


            Conexion.Close();

            cboBox_Categoria_Torneo.Items.Insert(0, "-Seleccione categoría-");
            cboBox_Categoria_Torneo.SelectedIndex = 0;
        }

    }
}
