//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinansalCrm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bank()
        {
            this.BankProcesses = new HashSet<BankProcess>();
        }
    
        public int BankId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankTitle { get; set; }
        public Nullable<decimal> BankBalance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankProcess> BankProcesses { get; set; }
    }
}
