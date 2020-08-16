namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class role
    {
        [Key]
        public int role_id { get; set; }

        [Required]
        [StringLength(50)]
        public string role_name { get; set; }
    }
}
