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
    
    public partial class tblInventory_Sk
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public int PricePerUnit { get; set; }
        public int ProductCount { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime IsCreatedOn { get; set; }
        public string IsCreatedBy { get; set; }
        public System.DateTime IsUpdatedOn { get; set; }
        public string IsUpdatedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string IsDeletedBy { get; set; }
    
        public virtual tblProducts_Sk tblProducts_Sk { get; set; }
        public virtual tblSellers_Sk tblSellers_Sk { get; set; }
    }
}
