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
    
    public partial class Tuote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tuote()
        {
            this.TilausRivi = new HashSet<TilausRivi>();
        }
    
        public int tuote_id { get; set; }
        public string nimi { get; set; }
        public string tyyppi { get; set; }
        public string tuoteryhmä { get; set; }
        public Nullable<decimal> hinta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TilausRivi> TilausRivi { get; set; }
    }
}
