using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD1
{
    public class ClsRegistroEquipo
    {
        public int id_Equipo { get; set; }
        public int id_Torneo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Cantidad_Jugadores { get; set; }
        public string Patrocinadores { get; set; }
        public bool Estado {  get; set; }
    }
}
