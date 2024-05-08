using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD1
{
    public class Torneo
    {
            public int id_Torneo { get; set; }
            public string Nombre_torneo { get; set; }
            public string Categoria_T { get; set; }
            public DateTime Fecha_Inicio { get; set; }
            public DateTime Fecha_Final { get; set; }     
            public string Ubicación_T { get; set; }
            public string Reglas_Especificas { get; set; }
            public bool Estado {  get; set; }
        
    }
}
    /*public class Torneo_Equipos
    {
        public int id_Torneo { get; set; }
        public int id_Equipo { get; set; }
    }

}*/
   



