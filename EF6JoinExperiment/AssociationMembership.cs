//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6JoinExperiment
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssociationMembership
    {
        public int Id { get; set; }
        public int AssociationId { get; set; }
        public int TutorId { get; set; }
    
        public virtual Tutor Tutor { get; set; }
        public virtual TutorAssociation TutorAssociation { get; set; }
    }
}
