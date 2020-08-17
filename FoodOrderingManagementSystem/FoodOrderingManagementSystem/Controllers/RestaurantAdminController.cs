﻿using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class RestaurantAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();

        // GET: Restaurant
        public ActionResult Index()
        {
            List<restaurant> restaurants = models.restaurants.ToList();

            return View(restaurants);
        }

        public ActionResult RestaurantUpdate(int id)
        {
            restaurant rest = models.restaurants.FirstOrDefault(x => x.restaurant_id == id);

            return View(rest);
        }

        [HttpPost]

        public ActionResult RestaurantUpdate(restaurant r)
        {
            restaurant restaurant = models.restaurants.FirstOrDefault(x => x.restaurant_id == r.restaurant_id);
            restaurant.restaurant_name = r.restaurant_name;
            restaurant.restaurant_address = r.restaurant_address;
            restaurant.phone_number = r.phone_number;
            restaurant.username = r.username;
            models.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RestaurantDelete(int id)
        {
            restaurant r = models.restaurants.FirstOrDefault(x => x.restaurant_id == id);
            models.restaurants.Remove(r);
            models.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}