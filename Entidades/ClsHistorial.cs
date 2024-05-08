using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD1
{
    public class ClsHistorial
    {
        public int id_Historial { get; set; }
        public int Torneo { get; set; }
        public string Fecha { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public string Marcador { get; set; }
        public string Estado { get; set; }
        public string EventoDestacado { get; set; }

    }
}
