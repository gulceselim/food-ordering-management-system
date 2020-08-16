namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
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
    }
}
