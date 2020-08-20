using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodOrderingManagementSystem.ViewModels
{
    public partial class RestaurantVM
    {
        [Key]
        public int restaurant_id { get; set; }

        [Required]
        [StringLength(50)]
        public string restaurant_name { get; set; }

        [Required]
        public string restaurant_address { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_number { get; set; }

        public int? rating { get; set; }

        public int role_id { get; set; }

        [Required]
        [StringLength(50)]
        public string city_name { get; set; }

        [Required]
        [StringLength(50)]
        public string city_zip_code { get; set; }
    }
}