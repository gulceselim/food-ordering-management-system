using FoodOrderingManagementSystem.Models;
using FoodOrderingManagementSystem.ViewModels;
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
            List<RestaurantVM> restaurantVMList = new List<RestaurantVM>();

            var restaurantList = (from restaurant in models.restaurants
                                  from city in models.cities
                                  from rc in models.city_restaurant
                                  where
                                  restaurant.restaurant_id == rc.restaurant_id && city.city_id == rc.city_id
                                  select new
                                  {
                                      city.city_id,
                                      restaurant.restaurant_id,
                                      restaurant.restaurant_name,
                                      restaurant.username,
                                      restaurant.restaurant_address,
                                      city.city_name,
                                      restaurant.phone_number,
                                      restaurant.rating
                                  }).ToList();

            foreach (var item in restaurantList)
            {
                RestaurantVM restaurant = new RestaurantVM();
                restaurant.restaurant_id = item.restaurant_id;
                restaurant.restaurant_name = item.restaurant_name;
                restaurant.city_name = item.city_name;
                restaurant.city_zip_code = item.city_id.ToString();
                restaurant.username = item.username;
                restaurant.restaurant_address = item.restaurant_address;
                restaurant.phone_number = item.phone_number;
                restaurant.rating = item.rating;
                restaurantVMList.Add(restaurant);
            }
            
            return View(restaurantVMList);
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