//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class JugadorPartido
    {
        public int IdJugadorPartido { get; set; }
        public Nullable<int> IdPartido { get; set; }
        public Nullable<int> IdJugador { get; set; }
        public Nullable<int> Goles { get; set; }
    
        public virtual Jugador Jugador { get; set; }
        public virtual Partido Partido { get; set; }
    }
}
