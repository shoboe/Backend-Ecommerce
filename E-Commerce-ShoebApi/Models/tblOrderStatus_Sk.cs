//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Commerce_ShoebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrderStatus_Sk
    {
        public int OrderStatusId { get; set; }
        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public System.DateTime OrderStatusChangedOn { get; set; }
        public string OrderStatusChangedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime IsCreatedOn { get; set; }
        public string IsCreatedBy { get; set; }
        public System.DateTime IsUpdatedOn { get; set; }
        public string IsUpdatedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string IsDeletedBy { get; set; }
    
        public virtual tblOrders_Sk tblOrders_Sk { get; set; }
    }
}
