using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class BasketUserController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        int totalPrice = 0;
        public ActionResult Index()
        {
            List<basket> baskets = models.baskets.ToList();
            foreach (var item in baskets)
            {
                totalPrice += item.total_price;
            }
            ViewBag.totalPrice = totalPrice;
            return View(baskets);
        }

        [HttpPost]
        public ActionResult BasketAdd(int id, basket b)
        {
            product product = models.products.FirstOrDefault(x => x.product_id == id);
            b.product_id = product.product_id;
            b.total_price = Convert.ToInt32(product.price);
            models.baskets.Add(b);
            models.SaveChanges();
            return RedirectToAction("Index","RestaurantUser", new { @id = product.restaurant_id });
        }

        [HttpPost]


        public ActionResult BasketDelete(int id)
        {
            basket basket = models.baskets.FirstOrDefault(x => x.basket_id == id);
            models.baskets.Remove(basket);
            models.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}