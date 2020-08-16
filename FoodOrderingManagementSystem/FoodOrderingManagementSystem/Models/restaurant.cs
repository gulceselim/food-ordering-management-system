namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class restaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public restaurant()
        {
            city_restaurant = new HashSet<city_restaurant>();
        }

        [Key]
        public int restaurant_id { get; set; }

        [Required]
        [StringLength(50)]
        public string restaurant_name { get; set; }

        [Required]
        [StringLength(255)]
        public string restaurant_address { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_number { get; set; }

        public int? rating { get; set; }

        public DateTime? order_time_planned { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<city_restaurant> city_restaurant { get; set; }
    }
}
