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
    
    public partial class Equipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipo()
        {
            this.EquipoPartidoes = new HashSet<EquipoPartido>();
            this.Jugadors = new HashSet<Jugador>();
        }
    
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Puntos { get; set; }
        public Nullable<int> GolesFavor { get; set; }
        public Nullable<int> GolesContra { get; set; }
        public Nullable<int> IdFuerza { get; set; }
        public Nullable<int> DiferenciaGoles { get; set; }
        public Nullable<int> Jugados { get; set; }
        public Nullable<int> Ganados { get; set; }
        public Nullable<int> Empatados { get; set; }
        public Nullable<int> Perdidos { get; set; }
    
        public virtual Fuerza Fuerza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipoPartido> EquipoPartidoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jugador> Jugadors { get; set; }
    }
}
