﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Final_ProductEntities : DbContext
    {
        public Final_ProductEntities()
            : base("name=Final_ProductEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<dashboard_Result> dashboard(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dashboard_Result>("dashboard", idParameter);
        }
    
        public virtual ObjectResult<AdminOrderList_Result> AdminOrderList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AdminOrderList_Result>("AdminOrderList");
        }

        public System.Data.Entity.DbSet<Final_Project.Models.AdminOrderList_Result> AdminOrderList_Result { get; set; }
    }
}