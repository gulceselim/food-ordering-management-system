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
        public ActionResult Index()
        {
            List<OrderProduct> orders = models.OrderProducts.ToList();
            ViewBag.restaurants = models.restaurants.ToList();
            return View(orders);
        }


    }
}