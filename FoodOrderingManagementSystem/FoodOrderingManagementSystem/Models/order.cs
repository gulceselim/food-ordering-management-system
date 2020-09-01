namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            order_product = new HashSet<order_product>();
            order_shipper = new HashSet<order_shipper>();
        }

        [Key]
        public int order_id { get; set; }

        [Required]
        [StringLength(50)]
        public string order_type { get; set; }

        public DateTime order_time { get; set; }

        [Required]
        [StringLength(50)]
        public string order_address { get; set; }

        [Required]
        public string order_details { get; set; }

        [Required]
        [StringLength(50)]
        public string price { get; set; }

        public int users_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_product> order_product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_shipper> order_shipper { get; set; }

        public virtual user user { get; set; }
    }
}
