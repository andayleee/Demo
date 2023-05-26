namespace DemoExam8800
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int IDCart { get; set; }

        public int BookID { get; set; }

        public int OrderID { get; set; }

        public int CountOfBook { get; set; }

        public virtual Book Book { get; set; }

        public virtual Order Order { get; set; }
    }
}
