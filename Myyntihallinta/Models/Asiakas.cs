//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Myyntihallinta.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asiakas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asiakas()
        {
            this.Tilaus = new HashSet<Tilaus>();
        }
    
        public int asiakas_id { get; set; }
        public string sukunimi { get; set; }
        public string etunimi { get; set; }
        public string osoite { get; set; }
        public string postinumero { get; set; }
        public string postitoimipaikka { get; set; }
        public Nullable<System.DateTime> syntymäaika { get; set; }
        public Nullable<int> luottoraja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tilaus> Tilaus { get; set; }
    }
}
