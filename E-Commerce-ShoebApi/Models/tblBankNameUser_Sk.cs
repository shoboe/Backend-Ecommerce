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
    
    public partial class tblBankNameUser_Sk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBankNameUser_Sk()
        {
            this.tblBorrowMoney_Sk = new HashSet<tblBorrowMoney_Sk>();
            this.tblDebitCards_Sk = new HashSet<tblDebitCards_Sk>();
        }
    
        public int BankNameUserId { get; set; }
        public int BankId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }
        public int Balance { get; set; }
        public int AccountNumber { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime IsCreatedOn { get; set; }
        public string IsCreatedBy { get; set; }
        public System.DateTime IsUpdatedOn { get; set; }
        public string IsUpdatedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string IsDeletedBy { get; set; }
    
        public virtual tblBank_Sk tblBank_Sk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBorrowMoney_Sk> tblBorrowMoney_Sk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDebitCards_Sk> tblDebitCards_Sk { get; set; }
    }
}
