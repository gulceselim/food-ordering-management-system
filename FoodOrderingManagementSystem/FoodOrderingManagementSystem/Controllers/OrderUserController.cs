using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    [Authorize(Roles = "user")]

    public class OrderUserController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        DateTime now = DateTime.Now;
        // GET: OrderUser
        public ActionResult Index()
        {
            List<order_product> order_Products = models.order_product.Where(x => x.order.user.username == User.Identity.Name).ToList();
            ViewBag.orders = models.orders.Where(x => x.user.username == User.Identity.Name).ToList(); 
            return View(order_Products);
        }

        [HttpPost]
        public ActionResult OrderAdd(order o)
        {
            order_product op = new order_product();
            user user = models.users.FirstOrDefault(x => x.username == User.Identity.Name);
            List<basket> baskets = models.baskets.Where(x => x.user.username == User.Identity.Name).ToList();
          


            if(o.order_type == "Kart" && user.payment == null)
            {
                return RedirectToAction("Index", "ProfilUser");
            }
            else
            {
                o.users_id = user.users_id;
                o.order_address = user.user_address;
                o.order_time = now;
                models.orders.Add(o);
                models.SaveChanges();
                foreach (var model in baskets)
                {
                    op.order_id = o.order_id;
                    op.product_id = model.product_id;
                    models.order_product.Add(op);
                    models.baskets.Remove(model);
                    models.SaveChanges();

                }
                return RedirectToAction("Index","OrderUser");

            }
            

        }
    }
}