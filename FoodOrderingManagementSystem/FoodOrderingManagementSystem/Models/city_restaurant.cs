namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class city_restaurant
    {
        [Key]
        public int city_restaurant_id { get; set; }

        public int city_id { get; set; }

        public int restaurant_id { get; set; }

        public virtual city city { get; set; }

        public virtual restaurant restaurant { get; set; }
    }
}
