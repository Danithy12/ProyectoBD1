using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD1
{
    public class ClsRegistroJugador
    {
            public int id_Jugador { get; set; }
            public int id_Equipo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Documento { get; set; }
            public int Edad { get; set; }
            public string Genero { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
    }
}
