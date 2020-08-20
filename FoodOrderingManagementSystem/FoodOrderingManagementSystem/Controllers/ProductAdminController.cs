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
        public ActionResult Index(string words)
        {
            ViewBag.restaurant = models.restaurants.ToList();
            return View(models.products.Where(x => x.product_name.Contains(words) || words == null).ToList());
        }

        public ActionResult ProductUpdate(int id)
        {
            product products = models.products.FirstOrDefault(x => x.product_id == id);
            ViewBag.categories = models.categories.ToList();
            return View(products);
        }

        [HttpPost]

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
        public ActionResult ProductDelete(int id)
        {
            product product = models.products.FirstOrDefault(x => x.product_id == id);

            models.products.Remove(product);
            models.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}