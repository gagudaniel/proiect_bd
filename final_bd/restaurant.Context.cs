﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class restaurantEntities : DbContext
    {
        public restaurantEntities()
            : base("name=restaurantEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblEmployees> TblEmployees { get; set; }
        public virtual DbSet<TblOrderItems> TblOrderItems { get; set; }
        public virtual DbSet<TblOrders> TblOrders { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }
        public virtual DbSet<TblTables> TblTables { get; set; }
    }
}
