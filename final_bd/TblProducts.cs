//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace final_bd
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProducts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblProducts()
        {
            this.TblOrderItems = new HashSet<TblOrderItems>();
        }
    
        public int ProductID { get; set; }
        public string Description { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> ProductType { get; set; }
        public byte[] Image { get; set; }
        public string Stock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblOrderItems> TblOrderItems { get; set; }
        public virtual TblProductTypes TblProductTypes { get; set; }
    }
}
