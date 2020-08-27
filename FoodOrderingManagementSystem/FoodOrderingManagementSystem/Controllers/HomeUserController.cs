using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class HomeUserController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: HomeUser
        public ActionResult Index()
        {
            List<restaurant> restaurants = models.restaurants.ToList();
            return View(restaurants);
        }


    }
}