namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("basket")]
    public partial class basket
    {
        [Key]
        public int basket_id { get; set; }

        public int total_price { get; set; }

        public int product_id { get; set; }

        public int user_id { get; set; }

        public virtual product product { get; set; }

        public virtual user user { get; set; }
    }
}
