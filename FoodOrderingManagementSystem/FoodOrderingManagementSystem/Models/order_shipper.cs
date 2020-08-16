namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order_shipper
    {
        [Key]
        public int order_shipper_id { get; set; }

        public int order_id { get; set; }

        public int shipper_id { get; set; }

        public virtual order order { get; set; }

        public virtual shipper shipper { get; set; }
    }
}
