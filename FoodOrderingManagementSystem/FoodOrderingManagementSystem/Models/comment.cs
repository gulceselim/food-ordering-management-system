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
        public string comment_text { get; set; }

        public int users_id { get; set; }

        public int restaurant_id { get; set; }

        public virtual restaurant restaurant { get; set; }

        public virtual user user { get; set; }
    }
}
