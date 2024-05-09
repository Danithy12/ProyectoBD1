using ProyectoCRUD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoBD1
{
    public class ClsProcedimientos

    //LAS MÉTODOS, CLASES DE SQL Y COMANDOS DE SQL QUE SE UTILIZARON EN LOS PROCEDIMIENTOS DE LA TABLA TORNEO SE APLICARAN A TODOS, POR LO TANTO NO VAKOS A SEGUIR DOCUMENTANDO
    //CABE RECALCAR QUE: A LA HORA DE HACER LAS CONSULTAS EN SQL SERVER TENDRÁ QUE APLICAR BBUENAS PRACTICAS Y HACERLAS EN MAYÚSCULAS SOSTENIDAS
    {
        //Cracion de procedimiento para guardar los datos de la tabal torneo
        public static int GuardarTorneo(ClsTorneo ObjetoComando)
        {
            int Retorna = 0;

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "INSERT INTO TORNEOS (Nombre_Torneo, Categoria_T, Fecha_Inicio, Fecha_Final, Ubicacion_T, Reglas_Especificas, Estado) " +
                    "VALUES(@Nombre_Torneo, @Categoria_T, @Fecha_Inicio, @Fecha_Final, @Ubicacion_T, @Reglas_Especificas, @Estado)";

                SqlCommand Comando = new SqlCommand(query, Conexion);
                Comando.Parameters.AddWithValue("@Nombre_Torneo", ObjetoComando.Nombre_torneo);
                Comando.Parameters.AddWithValue("@Categoria_T", ObjetoComando.Categoria_T);
                Comando.Parameters.AddWithValue("@Fecha_Inicio", ObjetoComando.Fecha_Inicio);
                Comando.Parameters.AddWithValue("@Fecha_Final", ObjetoComando.Fecha_Final);
                Comando.Parameters.AddWithValue("@Ubicacion_T", ObjetoComando.Ubicacion_T);
                Comando.Parameters.AddWithValue("@Reglas_Especificas", ObjetoComando.Reglas_Especificas);
                Comando.Parameters.AddWithValue("@Estado", ObjetoComando.Estado);

                Retorna = Comando.ExecuteNonQuery();
            }
            return Retorna;
        }
        public static List<ClsTorneo> ObtenerTorneosActivos()
        {
            List<ClsTorneo> torneosActivos = new List<ClsTorneo>();
            SqlConnection Conexion = null;

            try
            {
                Conexion = ClsConexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SELECT * FROM TORNEOS WHERE Estado = 1", Conexion);

                Conexion.Open();
                SqlDataReader Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    ClsTorneo torneo = new ClsTorneo
                    {
                        id_Torneo = Reader.GetInt32(Reader.GetOrdinal("id_Torneo")),
                        Nombre_torneo = Reader.IsDBNull(Reader.GetOrdinal("Nombre_torneo")) ? null : Reader.GetString(Reader.GetOrdinal("Nombre_torneo")),
                        Categoria_T = Reader.IsDBNull(Reader.GetOrdinal("Categoria_T")) ? null : Reader.GetString(Reader.GetOrdinal("Categoria_T")),
                        Fecha_Inicio = Reader.GetDateTime(Reader.GetOrdinal("Fecha_Inicio")),
                        Fecha_Final = Reader.GetDateTime(Reader.GetOrdinal("Fecha_Final")),
                        Ubicacion_T = Reader.IsDBNull(Reader.GetOrdinal("Ubicacion_T")) ? null : Reader.GetString(Reader.GetOrdinal("Ubicacion_T")),
                        Reglas_Especificas = Reader.IsDBNull(Reader.GetOrdinal("Reglas_Especificas")) ? null : Reader.GetString(Reader.GetOrdinal("Reglas_Especificas")),
                        Estado = Reader.GetBoolean(Reader.GetOrdinal("Estado"))
                    };
                    torneosActivos.Add(torneo);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los torneos activos: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            return torneosActivos;
        }

        //Creamos una lista para mostrar en nuestro data view todos los datos que ingresemos
        public static List<ClsTorneo> PresentarRegistroTorneo()
        {
            List<ClsTorneo> Lista = new List<ClsTorneo>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM TORNEOS"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader  = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Torneo + sus atributos
                    ClsTorneo torneo = new ClsTorneo();

                    torneo.id_Torneo = Reader.GetInt32(0);
                    torneo.Nombre_torneo = Reader.GetString(1);
                    torneo.Categoria_T = Reader.GetString(2);
                    torneo.Fecha_Inicio = Reader.GetDateTime(3);
                    torneo.Fecha_Final = Reader.GetDateTime(4);
                    torneo.Ubicacion_T = Reader.GetString(5);
                    torneo.Reglas_Especificas = Reader.GetString(6);
                    Lista.Add(torneo);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        //Procedimeinto para poder modificar los datos ingresados ne Torneo
        public static int ModificarTorneo(ClsTorneo torneo) //Objeto 
        {
            //Variables para resultados o y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "UPDATE TORNEOS SET Nombre_torneo='"+torneo.Nombre_torneo+"', Categoria_T='"+torneo.Categoria_T+ ", Fecha_Inicio="+torneo.Fecha_Inicio+ ",Fecha_Final="+torneo.Fecha_Final+"," +
                    " Ubicacion_T='"+torneo.Ubicacion_T+ "',  Reglas_Especificas='"+torneo.Reglas_Especificas+ "' WHERE id_Torneo="+torneo.id_Torneo+" "; //Datos a actualizar mas sintaxix de Sql Server

                SqlCommand Comando = new SqlCommand(query, Conexion);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;          
        }
        public static int EliminarTorneo(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM TORNEOS WHERE id_Torneo= " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarJugador(ClsRegistroJugador Jugador) //Ingresamos objeto de la clase Registro_Jugador
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnection
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para registrar todos los datos llamados por medio del objeto de la clase
                string query = "INSERT INTO REGISTRO_JUGADOR (Nombre, Apellido, Documento, Edad, Genero, Telefono, Correo)" +
                    " VALUES('" + Jugador.Nombre + "', '" + Jugador.Apellido + "', '" + Jugador.Documento + "', " + Jugador.Edad + ", '" + Jugador.Genero + "', '" + Jugador.Telefono + "', '" + Jugador.Correo + "' )"; 

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }
        
        public static List<ClsRegistroEquipo> ObtenerRegistroEquipoActivos()
        {
            List<ClsRegistroEquipo> torneosActivos = new List<ClsRegistroEquipo>();
            SqlConnection Conexion = null;

            try
            {
                Conexion = ClsConexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SELECT * FROM REGISTRO_EQUIPO WHERE id_Equipo = 1", Conexion);

                Conexion.Open();
                SqlDataReader Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    ClsRegistroEquipo Equipo = new ClsRegistroEquipo
                    {
                        id_Equipo = Reader.GetInt32(Reader.GetOrdinal("id_Equipo")),
                        id_Torneo = Reader.GetInt32(Reader.GetOrdinal("id_Torneo")),
                        Nombre = Reader.GetString(Reader.GetOrdinal("Nombre")),
                        Categoria = Reader.GetString(Reader.GetOrdinal("Categoria")),
                        Cantidad_Jugadores = Reader.GetInt32(Reader.GetOrdinal("Cantidad_Jugadores")),
                        Patrocinadores = Reader.GetString(Reader.GetOrdinal("Patrocinadores")),
                        Estado = Reader.GetBoolean(Reader.GetOrdinal("Estado"))
                    };
                    torneosActivos.Add(Equipo);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los Equipos activos: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            return torneosActivos;
        }

        public static List<ClsRegistroJugador> PresentarRegistroJugador()
        {
            List<ClsRegistroJugador> Lista = new List<ClsRegistroJugador>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM REGISTRO_JUGADOR"; //Variabl no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Jugador + sus atributos
                    ClsRegistroJugador Jugador = new ClsRegistroJugador();
                    Jugador.id_Jugador = Reader.GetInt32(0);
                    Jugador.id_Equipo = Reader.GetInt32(1);
                    Jugador.Nombre = Reader.GetString(2);
                    Jugador.Apellido = Reader.GetString(3);
                    Jugador.Documento = Reader.GetString(4);
                    Jugador.Edad = Reader.GetInt32(5);
                    Jugador.Genero = Reader.GetString(6);
                    Jugador.Telefono = Reader.GetString(7);
                    Jugador.Correo = Reader.GetString(8);
                    Lista.Add(Jugador);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        public static int ModificarRegistroJugador(ClsRegistroJugador Jugador) //Objeto 
        {
            //Variables para resultados o y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "UPDATE REGISTRO_JUGADOR SET Nombre='" + Jugador.Nombre + "', Apellido='" + Jugador.Apellido + "'," +
                    "Documento="+ Jugador.Documento + ",  Edad='" + Jugador.Edad + "',Genero='"+Jugador.Genero+ "', Telefono='"+Jugador.Telefono+ "', Correo='"+Jugador.Correo+"'," +
                    " WHERE id_Jugador=" + Jugador.id_Jugador + "  AND id_Equipo="+Jugador.id_Equipo+" "; //Datos a actualizar mas sintaxix de Sql Server

                SqlCommand Comando = new SqlCommand(query, Conexion);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }

        public static int EliminarRegistroJugador(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM REGISTRO_JUGADOR WHERE id_Jugador = " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarEquipo(ClsRegistroEquipo Equipo, string id_torneo)
        {
            int Retorna = 0;

            //id_torneo = Convert.ToInt32(id_torneo); 
            //Creamos la conexión con SQL SERVER y en su defecto nuestra base de datos por medio del comando SqlConnection
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para registrar todos los datos llamados por medio del objeto de la clase
                string query = "INSERT INTO REGISTRO_EQUIPOS(id_Torneo,Nombre, Categoria, Cantidad_Jugadores, Patrocinadores,Estado)" +
                    " VALUES("+id_torneo+ ",'" + Equipo.Nombre + "', '" + Equipo.Categoria + "', " + Equipo.Cantidad_Jugadores + ", '" +
                    Equipo.Patrocinadores + "',"+0+" )";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                try
                {
                    //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                    Retorna = Comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Imprimimos el mensaje de error
                    Console.WriteLine("Error al insertar en la tabla REGISTRO_EQUIPOS: " + ex.Message);
                }
            }
            return Retorna;
        }

        public static List<ClsRegistroEquipo> PresentarRegistroEquipo()
        {
            List<ClsRegistroEquipo> Lista = new List<ClsRegistroEquipo>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM REGISTRO_EQUIPOS"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Registro_Equipo + sus atributos
                    ClsRegistroEquipo Equipo = new ClsRegistroEquipo();
                    Equipo.id_Equipo = Reader.GetInt32(0);
                    Equipo.id_Torneo = Reader.GetInt32(1);
                    Equipo.Nombre = Reader.GetString(2);
                    Equipo.Categoria = Reader.GetString(3);
                    Equipo.Cantidad_Jugadores = Reader.GetInt32(4);
                    Equipo.Patrocinadores = Reader.GetString(5);
                    Lista.Add(Equipo);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        public static int ModificarRegistroEquipo(ClsRegistroEquipo Equipo) //Objeto 
        {
            //Variables para resultados 0 y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "UPDATE REGISTRO_EQUIPOS SET Nombre='" + Equipo.Nombre + "', '" + Equipo.Categoria + "', " + Equipo.Cantidad_Jugadores + ",'" + Equipo.Patrocinadores + "' " +
                    "WHERE id_Equipo="+Equipo.id_Equipo+" AND id_Torneo="+Equipo.id_Torneo+" "; //Datos a actualizar mas sintaxix de Sql Server

                SqlCommand Comando = new SqlCommand(query, Conexion);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }

        public static int EliminarEquipo(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM REGISTRO_EQUIPOS WHERE id_Equipo= " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarActualizacionJugador(ClsActualizacionJugador ActuJugador) //Ingresamos objeto de la clase Actualizacion_Jugador
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnection
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para registrar todos los datos llamados por medio del objeto de la clase
                string query = "INSERT INTO REGISTRO_JUGADOR (id_Jugador, Nombre, Apellido, Documento, Edad, Genero, Telefono, Correo)" +
                    " VALUES("+ActuJugador.id_Jugador+",'" + ActuJugador.Nombre + "', '" + ActuJugador.Apellido + "', '" + ActuJugador.Documento + "', " + ActuJugador.Edad + ", '" + ActuJugador.Genero + "', '" + ActuJugador.Telefono + "', '" + ActuJugador.Correo + "' )";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();
            }
            return Retorna;
        }

        public static List<ClsActualizacionJugador> PresentarRegistroActualizacionJugador()
        {
            List<ClsActualizacionJugador> Lista = new List<ClsActualizacionJugador>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM ACTUALIZACION_JUGADOR"; //Variabl no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Actualizacion_Jugador + sus atributos
                    ClsActualizacionJugador ActuJugador = new ClsActualizacionJugador();
                    ActuJugador.id_Actualizacion_JUGADOR = Reader.GetInt32(0);
                    ActuJugador.id_Jugador = Reader.GetInt32(1);
                    ActuJugador.Nombre = Reader.GetString(2);
                    ActuJugador.Apellido = Reader.GetString(3);
                    ActuJugador.Documento = Reader.GetString(4);
                    ActuJugador.Edad = Reader.GetInt32(5);
                    ActuJugador.Genero = Reader.GetString(6);
                    ActuJugador.Telefono = Reader.GetString(7);
                    ActuJugador.Correo = Reader.GetString(8);
                    Lista.Add(ActuJugador);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }

        public static int ModificarRegistroActualizacionJugador(ClsActualizacionJugador ActuJugador) //Objeto 
        {
            //Variables para resultados o y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "UPDATE REGISTRO_JUGADOR SET Nombre='" + ActuJugador.Nombre + "', Apellido='" + ActuJugador.Apellido + "'," +
                    "Documento=" + ActuJugador.Documento + ",  Edad='" + ActuJugador.Edad + "',Genero='" + ActuJugador.Genero + "', Telefono='" + ActuJugador.Telefono + "', Correo='" + ActuJugador.Correo + "'," +
                    " WHERE id_Actualizacion_JUGADOR=" + ActuJugador.id_Actualizacion_JUGADOR + "  AND id_Jugador=" + ActuJugador.id_Jugador + " "; //Datos a actualizar mas sintaxix de Sql Server

                SqlCommand Comando = new SqlCommand(query, Conexion);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }

        public static int EliminarRegistroActualizacionJugador(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM ACTUALIZACION_JUGADOR WHERE id_Actualizacion_JUGADOR = " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarProgramacion(ClsProgramacion Programacion) //Ingresamos objeto de la clase Programacion
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnection
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para registrar todos los datos llamados por medio del objeto de la clase
                string query = "INSERT INTO PROGRAMACION(id_Torneo, Fecha, Hora, Ubicacion, Equipo_Local, Equipo_visitante )" +
                    " VALUES(" + Programacion.id_Torneo + ", '" + Programacion.Fecha + "', '" + Programacion.Hora + "', '" + Programacion.Ubicacion + "', '" + Programacion.Equipo_Local + "', '" + Programacion.Equipo_Visitante + "' )";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static List<ClsProgramacion> PresentarRegistroProgramacion()
        {
            List<ClsProgramacion> Lista = new List<ClsProgramacion>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM PROGRAMACION"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Registro_Programacion + sus atributos
                    ClsProgramacion Programacion = new ClsProgramacion();
                    Programacion.id_Programacion = Reader.GetInt32(0);
                    Programacion.id_Torneo = Reader.GetInt32(1);
                    Programacion.Fecha = Reader.GetString(2);
                    Programacion.Hora = Reader.GetString(3);
                    Programacion.Ubicacion = Reader.GetString(4);
                    Programacion.Equipo_Local = Reader.GetString(5);
                    Programacion.Equipo_Visitante = Reader.GetString(6);
                    Lista.Add(Programacion);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }

        public static int ModificarProgramacion(ClsProgramacion Programacion) //Objeto 
        {
            //Variables para resultados o y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "UPDATE PROGRAMACION SET Fecha='"+Programacion.Fecha+"', Hora='"+Programacion.Hora+"', Ubicacion='"+Programacion.Ubicacion+"', Equipo_local='"+Programacion.Equipo_Local+"'," +
                    "Equipo_visitante='"+Programacion.Equipo_Visitante+"' " +
                    "WHERE id_Programacion="+Programacion.id_Programacion+" AND id_Torneo="+Programacion.id_Torneo+" )"; //Datos a actualizar mas sintaxix de Sql Server

                SqlCommand Comando = new SqlCommand(query, Conexion);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }

        public static int EliminarProgramacion(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM PROGRAMACION WHERE id_Programacion= " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarActualizacionProgramacion(ClsActualizacionProgramacion ActuProgramacion) //Ingresamos objeto de la clase Torneo
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnection
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para registrar todos los datos llamados por medio del objeto de la clase
                string query = "INSERT INTO ACTUALIZACION_PROGRAMACION(id_Programacion, Nueva_Fecha, Nueva_Ubiacion, Mensaje)" +
                    " VALUES(" + ActuProgramacion.id_Programacion + ", '" + ActuProgramacion.Nueva_Fecha + "', '" + ActuProgramacion.Nueva_Ubicacion + "', '"+ActuProgramacion.Mensaje+"' )";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static List<ClsActualizacionProgramacion> PresentarRegistroActualizacionProgramacion()
        {
            List<ClsActualizacionProgramacion> Lista = new List<ClsActualizacionProgramacion>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM ACTUALIZACION_PROGRAMACION"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Torneo + sus atributos
                    ClsActualizacionProgramacion ActuProgramacion = new ClsActualizacionProgramacion();
                    ActuProgramacion.id_Actualizacion_Programacion = Reader.GetInt32(0);
                    ActuProgramacion.id_Programacion = Reader.GetInt32(1);
                    ActuProgramacion.Nueva_Fecha = Reader.GetDateTime(2);
                    ActuProgramacion.Nueva_Ubicacion = Reader.GetString(3);
                    ActuProgramacion.Nueva_Hora = Reader.GetDateTime(4);
                    ActuProgramacion.Mensaje = Reader.GetString(5);
                    Lista.Add(ActuProgramacion);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }

        public static int ModificarActualizacionProgramacion(ClsActualizacionProgramacion ActuProgramacion) //Objeto 
        {
            //Variables para resultados o y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "UPDATE ACTUALIZACION_PROGRAMACION SET Nueva_Fecha='" + ActuProgramacion.Nueva_Fecha + "', Nueva_Ubicacion='" + ActuProgramacion.Nueva_Ubicacion +"', Mensaje='"+ActuProgramacion.Mensaje+"'," +
                    "WHERE id_Actualizacion_Programacion= "+ActuProgramacion.id_Actualizacion_Programacion+" AND id_Programacion="+ActuProgramacion.id_Programacion+" )"; //Datos a actualizar mas sintaxix de Sql Server

                SqlCommand Comando = new SqlCommand(query, Conexion);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Crramos conexion
            }
            return Resultados;
        }

        public static int EliminarActualizacionProgramacion(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM ACTUALIZACION_PROGRAMACION WHERE id_Actualizacion_Programacion= " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }



        public string GuardarResultados(ClsResultados ObjetoComando)
        {
            string Respuesta = " ";
            SqlConnection Conexion = new SqlConnection();
            try
            {
                Conexion = ClsConexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SP_REGISTRAR_DATOS_RESULTADOS");

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@Id_Resultado", SqlDbType.Int).Value = ObjetoComando.id_Resultado;
                Comando.Parameters.Add("@EquipoLocal", SqlDbType.VarChar, 50).Value = ObjetoComando.EquipoLocal;
                Comando.Parameters.Add("@EquippVisitante", SqlDbType.VarChar, 50).Value = ObjetoComando.EquipoVisitante;
                Comando.Parameters.Add("@Marcador", SqlDbType.VarChar, 50).Value = ObjetoComando.Marcador;
                Comando.Parameters.Add("@Estado", SqlDbType.VarChar, 100).Value = ObjetoComando.Estado;
                Comando.Parameters.Add("@EventoDestacado", SqlDbType.VarChar, 100).Value = ObjetoComando.EventoDestacado;


            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if(Conexion.State == ConnectionState.Open) Conexion.Close();
            }
            return Respuesta;
        }

        public string GuardarPosiciones(ClsPosiciones ObjetoComando)
        {
            string Respuesta = " ";
            SqlConnection Conexion = new SqlConnection();
            try
            {
                Conexion = ClsConexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SP_REGISTRAR_DATOS_POSICIONES");

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@Id_Posicion", SqlDbType.Int).Value = ObjetoComando.id_Posicion;
                Comando.Parameters.Add("@Equipo", SqlDbType.VarChar, 50).Value = ObjetoComando.Equipo;
                Comando.Parameters.Add("@Encuentros", SqlDbType.VarChar, 50).Value = ObjetoComando.Encuentros;
                Comando.Parameters.Add("@Victorias", SqlDbType.VarChar, 50).Value = ObjetoComando.Victorias;
                Comando.Parameters.Add("@Derrotas", SqlDbType.VarChar, 50).Value = ObjetoComando.Derrotas;
                Comando.Parameters.Add("@Empates", SqlDbType.VarChar, 50).Value = ObjetoComando.Empates;
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if(Conexion.State == ConnectionState.Open) Conexion.Close();
            }
            return Respuesta;
        }

        public string GuardarHistorial(ClsHistorial ObjetoComando)
        {
            string Respuesta = " ";
            SqlConnection Conexion = new SqlConnection();
            try
            {
                Conexion = ClsConexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SP_REGISTRAR_DATOS_HISTORIAL");

                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@Id_Historial", SqlDbType.Int).Value = ObjetoComando.id_Historial;
                Comando.Parameters.Add("@Id_Torneo", SqlDbType.Int).Value = ObjetoComando.Torneo;
                Comando.Parameters.Add("@Fecha", SqlDbType.VarChar, 50).Value = ObjetoComando.Fecha;
                Comando.Parameters.Add("EquipoLocal", SqlDbType.VarChar, 50).Value = ObjetoComando.EquipoLocal;
                Comando.Parameters.Add("EquipoLocal", SqlDbType.VarChar, 50).Value = ObjetoComando.EquipoVisitante;
                Comando.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 50).Value = ObjetoComando.Marcador;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = ObjetoComando.Estado;
                Comando.Parameters.Add("@Reglas", SqlDbType.VarChar, 100).Value = ObjetoComando.EventoDestacado;
            
                Comando.Parameters.Add("EquipoVisitante", SqlDbType.VarChar, 50).Value = ObjetoComando.EquipoVisitante;

            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if(Conexion.State == ConnectionState.Open) Conexion.Close();
            }
            return Respuesta;
        }
    }

    
}
    

