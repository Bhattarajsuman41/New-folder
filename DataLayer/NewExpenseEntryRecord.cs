//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class NewExpenseEntryRecord
    {
        public int Id { get; set; }
        public Nullable<int> ExpenseTypeId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<int> MonthId { get; set; }
        public string UserId { get; set; }
    }
}