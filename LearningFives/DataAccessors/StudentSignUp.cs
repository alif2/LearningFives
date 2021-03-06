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
    
    public partial class StudentSignUp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentSignUp()
        {
            this.CoachPlayers = new HashSet<CoachPlayer>();
        }
    
        public int StudentSignUpID { get; set; }
        public int StudentStatus { get; set; }
        public int SummonerInfoID { get; set; }
        public int RoleInfoID { get; set; }
        public int AvailabilityInfoID { get; set; }
        public string Languages { get; set; }
        public string PairedPlayers { get; set; }
        public string PlayerStrengths { get; set; }
        public string PlayerImprovement { get; set; }
        public string PlayerExpectations { get; set; }
        public int CommitmentID { get; set; }
        public int ToxicID { get; set; }
        public string MoreInformation { get; set; }
        public bool EmailSignUp { get; set; }
    
        public virtual AvailabilityInfo AvailabilityInfo { get; set; }
        public virtual Commitment Commitment { get; set; }
        public virtual RoleInfo RoleInfo { get; set; }
        public virtual SummonerInfo SummonerInfo { get; set; }
        public virtual Toxic Toxic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoachPlayer> CoachPlayers { get; set; }
    }
}
