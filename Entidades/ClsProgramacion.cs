using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD1
{
    public class ClsProgramacion
    {
        public int id_Programacion { get; set; }
        public int id_Torneo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Ubicacion { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_Visitante { get; set; }
    }
}
