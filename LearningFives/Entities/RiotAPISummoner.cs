//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class RiotAPISummoner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RiotAPISummoner()
        {
            this.RiotAPILeagues = new HashSet<RiotAPILeague>();
        }
    
        public long RiotAPISummonerID { get; set; }
        public int SummonerInfoID { get; set; }
        public long ProfileIconID { get; set; }
        public long RevisionDate { get; set; }
        public long SummonerLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiotAPILeague> RiotAPILeagues { get; set; }
        public virtual SummonerInfo SummonerInfo { get; set; }
    }
}
