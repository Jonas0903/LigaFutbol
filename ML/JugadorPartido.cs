using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class JugadorPartido
    {
        public int IdJugadorPartido { get; set; }
        public int Goles { get; set; }
        public Partido Partido { get; set; }
        public Jugador Jugador { get; set; }
    }
}
