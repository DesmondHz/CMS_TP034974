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
    
    public partial class Cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargo()
        {
            this.CargoBookings = new HashSet<CargoBooking>();
        }
    
        public int CargoId { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> CargoWeight { get; set; }
        public Nullable<int> CargoWidth { get; set; }
        public Nullable<int> CargoLength { get; set; }
        public Nullable<int> CargoHeight { get; set; }
        public string CargoName { get; set; }
        public string CargoRequirement { get; set; }
        public Nullable<int> CargoWarehouse { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargoBooking> CargoBookings { get; set; }
    }
}
