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
    
    public partial class CoachPlayer
    {
        public int CoachPlayerID { get; set; }
        public int CoachSignUpID { get; set; }
        public int StudentSignUpID { get; set; }
    
        public virtual CoachSignUp CoachSignUp { get; set; }
        public virtual StudentSignUp StudentSignUp { get; set; }
    }
}
