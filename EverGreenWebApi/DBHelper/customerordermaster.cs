//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EverGreenWebApi.DBHelper
{
    using System;
    using System.Collections.Generic;
    
    public partial class customerordermaster
    {
        public int OrderId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> MenuId { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<decimal> CustomerPrice { get; set; }
        public Nullable<decimal> EventFee { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public Nullable<decimal> DiscountValue { get; set; }
        public Nullable<decimal> AdvancePrice { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public Nullable<decimal> NetPrice { get; set; }
        public Nullable<int> OrderStatusId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}