//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vidly.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int Id { get; set; }
        public System.DateTime DateRented { get; set; }
        public Nullable<System.DateTime> DateReturned { get; set; }
        public int Customer_Id { get; set; }
        public int Movie_Id { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Movy Movy { get; set; }
    }
}
