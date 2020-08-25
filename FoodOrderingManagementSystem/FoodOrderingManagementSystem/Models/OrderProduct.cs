namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderProduct")]
    public partial class OrderProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string order_type { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string price { get; set; }

        [Key]
        [Column(Order = 3)]
        public string order_details { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string product_name { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string first_name { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string last_name { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string uFirstName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string uLastName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string restaurant_name { get; set; }
    }
}
