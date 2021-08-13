using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public DateTime Fecha { get; set; }
        public List<object> Partidos { get; set; }
    }
}
