namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class city
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public city()
        {
            city_restaurant = new HashSet<city_restaurant>();
        }

        [Key]
        public int city_id { get; set; }

        [Required]
        [StringLength(50)]
        public string city_name { get; set; }

        public int city_zip_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<city_restaurant> city_restaurant { get; set; }
    }
}
