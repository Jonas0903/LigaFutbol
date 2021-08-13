using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class EquipoPartido
    {
        public int IdEquipoPartido { get; set; }
        public int Goles { get; set; }
        public Partido Partido { get; set; }
        public Equipo Equipo { get; set; }
    }
}
