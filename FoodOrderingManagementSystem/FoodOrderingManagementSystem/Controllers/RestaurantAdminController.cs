using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            var cityList = from restaurant in models.restaurants
                           from city in models.cities
                           from rc in models.city_restaurant
                           where
                           restaurant.restaurant_id == rc.restaurant_id && city.city_id == rc.city_id
                           select new
                           {
                               cityID = city.city_id,
                               restID = restaurant.restaurant_id,
                               city = city.city_name
                           };
            ViewBag.cityList = cityList;
            return View(restaurants);
        }

        public ActionResult RestaurantUpdate(int id)
        {
            restaurant rest = models.restaurants.FirstOrDefault(x => x.restaurant_id == id);
            ViewBag.cities = models.cities.ToList();

            

            return View(rest);
        }

        [HttpPost]

        public ActionResult RestaurantUpdate(restaurant r)
        {
            restaurant restaurant = models.restaurants.FirstOrDefault(x => x.restaurant_id == r.restaurant_id);
            //city_restaurant city_Restaurant = models.city_restaurant.FirstOrDefault(x => x.restaurant_id == r.restaurant_id);
            //city city = models.cities.FirstOrDefault(x => x.city_id == city_Restaurant.city_id);

            restaurant.restaurant_name = r.restaurant_name;
            restaurant.username = r.username;
            restaurant.restaurant_address = r.restaurant_address;
            restaurant.phone_number = r.phone_number;

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