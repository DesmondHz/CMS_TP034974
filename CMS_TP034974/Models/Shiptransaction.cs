//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS_TP034974.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shiptransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shiptransaction()
        {
            this.CargoBookings = new HashSet<CargoBooking>();
        }
    
        public int shiptranId { get; set; }
        public string shipName { get; set; }
        public string DepartLocation { get; set; }
        public string DestinationLocation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargoBooking> CargoBookings { get; set; }
    }
}
