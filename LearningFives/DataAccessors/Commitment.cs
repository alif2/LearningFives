//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessors
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commitment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commitment()
        {
            this.CoachSignUps = new HashSet<CoachSignUp>();
            this.StudentSignUps = new HashSet<StudentSignUp>();
        }
    
        public int CommitmentID { get; set; }
        public int CommitmentLevel { get; set; }
        public int SeriousnessLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoachSignUp> CoachSignUps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentSignUp> StudentSignUps { get; set; }
    }
}
