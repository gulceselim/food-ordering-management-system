using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class ProductAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: ProductAdmin
        public ActionResult Index()
        {
            List<product> products = models.products.ToList();

            ViewBag.restaurant = models.restaurants.ToList();
            return View(products);
        }
    }
}