namespace DemoExam8800
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        public int IDBook { get; set; }

        [Required]
        [StringLength(20)]
        public string NameOfBook { get; set; }

        public decimal CostOfBook { get; set; }

        [Required]
        [StringLength(20)]
        public string AuthorOfBook { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
