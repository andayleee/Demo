namespace DemoExam8800
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        public int IDOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfOrder { get; set; }

        public int UserID { get; set; }

        public int PickupPoint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual PickupPoint PickupPoint1 { get; set; }

        public virtual User User { get; set; }
    }
}
