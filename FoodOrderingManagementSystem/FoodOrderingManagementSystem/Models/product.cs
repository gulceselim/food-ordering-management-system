namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            order_product = new HashSet<order_product>();
        }

        [Key]
        public int product_id { get; set; }

        [Required]
        [StringLength(50)]
        public string product_name { get; set; }

        [Required]
        [StringLength(50)]
        public string details { get; set; }

        [Required]
        [StringLength(50)]
        public string price { get; set; }

        public bool active { get; set; }

        [Required]
        [StringLength(50)]
        public string product_image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_product> order_product { get; set; }
    }
}
