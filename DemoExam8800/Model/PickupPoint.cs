namespace DemoExam8800
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PickupPoint")]
    public partial class PickupPoint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PickupPoint()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int IDPickupPoint { get; set; }

        [Required]
        [StringLength(20)]
        public string PickupPointCity { get; set; }

        [Required]
        [StringLength(20)]
        public string PickupPointStreet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
