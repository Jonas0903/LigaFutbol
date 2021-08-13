using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Jugador
    {
        public int IdJugador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Goles { get; set; }
        public Equipo Equipo { get; set; }
        public List<object> Jugadores { get; set; }
    }
}
