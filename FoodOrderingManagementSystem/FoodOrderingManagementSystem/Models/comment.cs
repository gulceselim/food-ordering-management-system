namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comment
    {
        [Key]
        public int comment_id { get; set; }

        public DateTime comment_time { get; set; }

        [Required]
        [StringLength(50)]
        public string comment_text { get; set; }
    }
}
