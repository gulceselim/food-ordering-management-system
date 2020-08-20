using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodOrderingManagementSystem.ViewModels
{
    public partial class OrderVM
    {
        [Key]
        public int order_id { get; set; }

        [Required]
        [StringLength(50)]
        public string order_type { get; set; }

        [Required]
        public string order_details { get; set; }

        [Required]
        [StringLength(50)]
        public string price { get; set; }

        [Required]
        [StringLength(50)]
        public string product_name { get; set; }

        [Required]
        [StringLength(50)]
        public string shipper_name{ get; set; }

        [Required]
        [StringLength(50)]
        public string user_name { get; set; }

    }
}