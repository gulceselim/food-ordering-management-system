namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public payment()
        {
            users = new HashSet<user>();
        }

        [Key]
        public int payment_id { get; set; }

        [Required]
        [StringLength(50)]
        public string card_number { get; set; }

        [Required]
        [StringLength(50)]
        public string card_date { get; set; }

        [Required]
        [StringLength(50)]
        public string card_cvv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
