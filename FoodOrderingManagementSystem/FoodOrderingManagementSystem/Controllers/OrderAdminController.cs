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
        [Authorize(Roles = "restaurant,admin")]

        public ActionResult Index()
        {
            if (User.IsInRole("restaurant"))
            {
                ViewBag.restaurants = models.restaurants.Where(x => x.username == User.Identity.Name).ToList();
            }
            else
            {
                ViewBag.restaurants = models.restaurants.ToList();
            }

            List<OrderProduct> orders = models.OrderProducts.ToList();
            
            return View(orders);
        }

        [HttpPost]
        [Authorize(Roles = "restaurant")]

        public ActionResult OrderDelete(int id)
        {
            order order = models.orders.FirstOrDefault(x => x.order_id == id);

            models.orders.Remove(order);
            models.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}