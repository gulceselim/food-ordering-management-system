using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class OrderAdminController : Controller
    {

        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: OrderAdmin
        [Authorize(Roles = "restaurant")]

        public ActionResult Index()
        {
            ViewBag.restaurants = models.restaurants.Where(x => x.username == User.Identity.Name).ToList();

            restaurant restaurant = models.restaurants.FirstOrDefault(x => x.username == User.Identity.Name);

            List<order_product> order_Products = models.order_product.Where(x => x.product.restaurant_id == restaurant.restaurant_id).ToList();
            
            return View(order_Products);
        }



    }
}