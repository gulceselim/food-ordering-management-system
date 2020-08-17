namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            comments = new HashSet<comment>();
            orders = new HashSet<order>();
        }

        [Key]
        public int users_id { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string user_password { get; set; }

        [Required]
        [StringLength(50)]
        public string user_email { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_number { get; set; }

        [StringLength(50)]
        public string user_address { get; set; }

        public int? user_score { get; set; }

        public int? order_count { get; set; }

        public int role_id { get; set; }

        public int city_id { get; set; }

        public int payment_id { get; set; }

        public virtual city city { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }

        public virtual payment payment { get; set; }

        public virtual role role { get; set; }
    }
}
