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
        [Authorize(Roles = "restaurant,admin")]

        public ActionResult Index()
        {

            if(User.IsInRole("restaurant"))
            {
                ViewBag.restaurants = models.restaurants.Where(x => x.username == User.Identity.Name).ToList();
            }
            else
            {
                ViewBag.restaurants = models.restaurants.ToList();
            }

            List<product> products = models.products.ToList();

            return View(products);
        }

        [Authorize(Roles = "restaurant")]
        public ActionResult ProductUpdate(int id)
        {
            product products = models.products.FirstOrDefault(x => x.product_id == id);
            ViewBag.categories = models.categories.ToList();
            return View(products);
        }

        [HttpPost]
        [Authorize(Roles = "restaurant")]
        public ActionResult ProductUpdate(product p)
        {
            product product = models.products.FirstOrDefault(x => x.product_id == p.product_id);

            product.product_name = p.product_name;
            product.details = p.details;
            product.price = p.price;
            product.active = p.active;
            product.category_id = p.category_id;
            models.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpPost]
        [Authorize(Roles = "restaurant")]

        public ActionResult ProductDelete(int id)
        {
            product product = models.products.FirstOrDefault(x => x.product_id == id);

            models.products.Remove(product);
            models.SaveChanges();
            return RedirectToAction("Index");

        }

        [Authorize(Roles = "restaurant")]

        public ActionResult ProductAdd(int id)
        {
            restaurant restaurant = models.restaurants.FirstOrDefault(x => x.restaurant_id == id);
            ViewBag.categories = models.categories.ToList();
            return View(restaurant);
        }
        [HttpPost]
        [Authorize(Roles = "restaurant")]

        public ActionResult ProductAdd(product p)
        {
            models.products.Add(p);
            models.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}