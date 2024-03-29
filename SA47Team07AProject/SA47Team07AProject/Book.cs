//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA47Team07AProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public System.DateTime YearOfPublication { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string BookType { get; set; }
        public string Genre { get; set; }
        public string LocationNo { get; set; }
        public short TotalStock { get; set; }
        public short NoOfBorrowBooks { get; set; }
    
        public virtual Location Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
