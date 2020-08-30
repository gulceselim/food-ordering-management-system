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

        [Required(ErrorMessage = "*The product name field is required.")]
        [StringLength(50)]
        [Display(Name = "Product Name")]
        public string product_name { get; set; }

        [Required(ErrorMessage = "*The detail field is required.")]
        [Display(Name = "Detail")]
        public string details { get; set; }

        [Required(ErrorMessage = "*The price field is required.")]
        [StringLength(50)]
        [Display(Name = "Price")]
        public string price { get; set; }

        [Required(ErrorMessage = "*The image field is required.")]
        public string image { get; set; }

        public bool active { get; set; }

        public int category_id { get; set; }

        public int restaurant_id { get; set; }

        public virtual category category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_product> order_product { get; set; }

        public virtual restaurant restaurant { get; set; }
    }
}
