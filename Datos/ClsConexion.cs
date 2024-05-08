using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCRUD
{
    public class ClsConexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;

        private static ClsConexion Con = null;

        public ClsConexion()
        {
            this.Base = "PRUEBAFINAL";
            this.Servidor = "DESKTOP-63RH14Q\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "12345678";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                           "; Database=" + this.Base +
                                           ";User Id=" + this.Usuario +
                                           "; Password=" + this.Clave;
                Cadena.Open();
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

       /* public void Abrir()
        {
            SqlConnection miconexion = CrearConexion();

            try
            {
                miconexion.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexión no Exitosa: " + ex.Message);

            }
        }*/
        public static ClsConexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new ClsConexion();

            }
            return Con;
        }

    }
}
