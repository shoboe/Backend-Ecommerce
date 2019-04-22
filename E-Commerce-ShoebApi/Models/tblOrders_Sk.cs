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
    
    public partial class tblOrders_Sk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrders_Sk()
        {
            this.tblItems_Sk = new HashSet<tblItems_Sk>();
            this.tblOrderStatus_Sk = new HashSet<tblOrderStatus_Sk>();
        }
    
        public int OrderId { get; set; }
        public int BuyerId { get; set; }
        public int ShippingMethodId { get; set; }
        public int NetPrice { get; set; }
        public int PaymentMethodId { get; set; }
        public int PaidFrom { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime IsCreatedOn { get; set; }
        public string IsCreatedBy { get; set; }
        public System.DateTime IsUpdatedOn { get; set; }
        public string IsUpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string IsDeletedBy { get; set; }
    
        public virtual tblBuyers_Sk tblBuyers_Sk { get; set; }
        public virtual tblBuyers_Sk tblBuyers_Sk1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblItems_Sk> tblItems_Sk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderStatus_Sk> tblOrderStatus_Sk { get; set; }
        public virtual tblPaymentMethod_Sk tblPaymentMethod_Sk { get; set; }
        public virtual tblShippingMethod_Sk tblShippingMethod_Sk { get; set; }
        public virtual tblShippingMethod_Sk tblShippingMethod_Sk1 { get; set; }
        public virtual tblShippingMethod_Sk tblShippingMethod_Sk2 { get; set; }
        public virtual tblShippingMethod_Sk tblShippingMethod_Sk3 { get; set; }
    }
}
