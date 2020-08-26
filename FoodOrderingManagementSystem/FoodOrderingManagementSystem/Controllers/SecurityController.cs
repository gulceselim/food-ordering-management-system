using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;

namespace FoodOrderingManagementSystem.Controllers
{

    public class SecurityController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: Security
        [AllowAnonymous]
        public ActionResult Login()
        {
            
            ViewBag.cities = models.cities.ToList();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]

        public ActionResult Login(user u)
        {
            ViewBag.cities = models.cities.ToList();

            var user = models.users.FirstOrDefault(x => x.username == u.username && x.user_password == u.user_password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.username, false);
                return RedirectToAction("Index", "HomeUser");
            }
            else
            {
                ViewBag.message = "* We can't find that your account";
                return View();
            }


        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        [HttpPost]
        [AllowAnonymous]

        public ActionResult Register(user u)
        {
            u.role_id = 3;

            models.users.Add(u);
            models.SaveChanges();
            return RedirectToAction("Login");

        }

        [AllowAnonymous]
        public ActionResult LoginRestaurant()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]

        public ActionResult LoginRestaurant(restaurant r)
        {
           
            var restaurants = models.restaurants.FirstOrDefault(x => x.username == r.username && x.restaurant_password == r.restaurant_password);
            if (restaurants != null)
            {
                FormsAuthentication.SetAuthCookie(restaurants.username, false);
                return RedirectToAction("Index", "HomeUser");
            }
            else
            {
                ViewBag.messageForRestaurant = "* We can't find that your account";
                return RedirectToAction("Login");
            }

           


        }
    }
}