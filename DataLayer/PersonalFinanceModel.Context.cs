﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalFinanceMgmtApp.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonalFinanceDBEntities : DbContext
    {
        public PersonalFinanceDBEntities()
            : base("name=PersonalFinanceDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chart> Charts { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<NewExpenseRecord> NewExpenseRecords { get; set; }
        public virtual DbSet<NewExpenseEntryRecord> NewExpenseEntryRecords { get; set; }
    }
}