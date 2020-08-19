using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class UserAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: UserAdmin
        public ActionResult Index()
        {
            List<user> users = models.users.ToList();
            return View(users);
        }

        public ActionResult UserUpdate(int id)
        {
            user user = models.users.FirstOrDefault(x => x.users_id == id);

            ViewBag.cities = models.cities.ToList();

            return View(user);
        }

        [HttpPost]

        public ActionResult UserUpdate(user u)
        {
            user user = models.users.FirstOrDefault(x => x.users_id == u.users_id);
            user.first_name = u.first_name;
            user.last_name = u.last_name;
            user.user_address = u.user_address;
            user.user_email = u.user_email;
            user.username = u.username;
            user.phone_number = u.phone_number;
            user.city_id = u.city_id;
            models.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UserDelete(int id)
        {
            user u = models.users.FirstOrDefault(x => x.users_id == id);
            models.users.Remove(u);
            models.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}