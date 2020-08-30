using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class RestaurantUserController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: RestaurantUser
        public ActionResult Index(int id)
        {
            List<product> products = models.products.Where(x => x.restaurant_id == id).ToList();
            var model = models.comments.Where(x => x.restaurant_id == id).ToList();

            ViewBag.restaurantID = id;  

            if(model.Count != 0)
            {
                ViewBag.comments = model;
            }
            else
            {
                ViewBag.message = "Yorum yok!";
                ViewBag.comments = null;
            }
    
            return View(products);
        }


    }
}