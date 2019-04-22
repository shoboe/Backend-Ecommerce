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
    
    public partial class tblSellers_Sk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSellers_Sk()
        {
            this.tblInventory_Sk = new HashSet<tblInventory_Sk>();
        }
    
        public int SellerId { get; set; }
        public int SellerStatusId { get; set; }
        public int BusinessTypeId { get; set; }
        public int Rating { get; set; }
        public int BankId { get; set; }
        public int AccountNumber { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime IsCreatedOn { get; set; }
        public string IsCreatedBy { get; set; }
        public System.DateTime IsUpdatedOn { get; set; }
        public string IsUpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string IsDeletedBy { get; set; }
    
        public virtual tblBank_Sk tblBank_Sk { get; set; }
        public virtual tblBusinessType_Sk tblBusinessType_Sk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInventory_Sk> tblInventory_Sk { get; set; }
        public virtual tblSellerStatus_Sk tblSellerStatus_Sk { get; set; }
    }
}
