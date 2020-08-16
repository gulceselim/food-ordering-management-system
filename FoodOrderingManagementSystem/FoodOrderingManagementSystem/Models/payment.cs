namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class payment
    {
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
    }
}
