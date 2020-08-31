using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodOrderingManagementSystem.Models;

namespace FoodOrderingManagementSystem.Controllers
{
    public class ProfilUserController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: ProfilUser
        public ActionResult Index()
        {
            var userName = User.Identity.Name;
            var user = models.users.FirstOrDefault(x => x.username == userName);
            List<payment> payments = models.payments.Where(x => x.payment_id == user.payment_id).ToList();
            ViewBag.payment = payments;
            ViewBag.cities = models.cities.ToList();
            return View(user);
        }

        [HttpPost]

        public ActionResult UserUpdate(user u)
        {
            bool control = true;
            user user = models.users.FirstOrDefault(x => x.users_id == u.users_id);
            user.user_address = u.user_address;
            user.user_email = u.user_email;
            if(u.username != user.username)
            {
                control = false;
            }
            user.username = u.username;
            user.phone_number = u.phone_number;
            user.city_id = u.city_id;
            models.SaveChanges();
            if(control == false)
            {
                return RedirectToAction("Logout","Security");

            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}