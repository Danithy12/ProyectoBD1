using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD1
{
    public class ClsActualizacionProgramacion
    {
        public int id_Actualizacion_Programacion { get; set; }
        public int id_Programacion { get; set; }
        public DateTime Nueva_Fecha { get; set; }
        public string Nueva_Ubicacion { get; set; }
        public DateTime Nueva_Hora { get; set; }
        public string Mensaje { get; set; }
    }
}
