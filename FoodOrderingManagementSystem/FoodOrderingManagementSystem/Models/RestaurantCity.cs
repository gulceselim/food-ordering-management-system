namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantCity")]
    public partial class RestaurantCity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int restaurant_id { get; set; }

        public string city_name { get; set; }

        public string image { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int city_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string restaurant_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string username { get; set; }

        [Key]
        [Column(Order = 4)]
        public string restaurant_address { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string phone_number { get; set; }

        public int? rating { get; set; }
    }
}
