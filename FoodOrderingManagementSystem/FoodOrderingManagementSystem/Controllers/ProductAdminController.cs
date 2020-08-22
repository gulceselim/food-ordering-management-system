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
            ViewBag.restaurant = models.restaurants.ToList();
            List<product> products = models.products.ToList();

            return View(products);
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