//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Research_Gate_1._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reaction
    {
        public int AuthorID { get; set; }
        public int PaperID { get; set; }
        public bool ReactionType { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Paper Paper { get; set; }
    }
}