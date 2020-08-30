using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace FoodOrderingManagementSystem.Controllers
{
    [Authorize(Roles = "admin")]
    public class RestaurantAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();

        // GET: Restaurant
        public ActionResult Index()
        {
            List<RestaurantCity> restaurants = models.RestaurantCities.GroupBy(r => r.restaurant_id).Select(x => x.FirstOrDefault()).ToList();
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
            city_restaurant cr = models.city_restaurant.FirstOrDefault(x => x.restaurant_id == id);
            models.city_restaurant.Remove(cr);
            models.restaurants.Remove(r);
            models.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult RestaurantAdd()
        {
            List<city> cities = models.cities.ToList();
            return View(cities);
        }
        [HttpPost]

        public ActionResult RestaurantAdd(restaurant r, city c, HttpPostedFileBase file)
        {
            city_restaurant cityRestaurant = new city_restaurant();
            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.Combine(Server.MapPath("~/Content/assets_1/img/"),Path.GetFileName(file.FileName));
                file.SaveAs(fileName);
                string filePath = "/Content/assets_1/img/" + file.FileName;
                r.image = filePath;
                r.role_id = 2;
                cityRestaurant.city_id = c.city_id;
                cityRestaurant.restaurant_id = r.restaurant_id;
                models.city_restaurant.Add(cityRestaurant);
                models.restaurants.Add(r);
                models.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Try again";
                return View("RestaurantAdd");
            }
            
            
        }
    }
}