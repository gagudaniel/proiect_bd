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
    
    public partial class TblOrders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblOrders()
        {
            this.TblOrderItems = new HashSet<TblOrderItems>();
        }
    
        public int OrderID { get; set; }
        public Nullable<int> Guests { get; set; }
        public Nullable<int> TableID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string OrderState { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
    
        public virtual TblEmployees TblEmployees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblOrderItems> TblOrderItems { get; set; }
        public virtual TblTables TblTables { get; set; }
    }
}
