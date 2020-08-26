using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class CommentAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: CommentAdmin
        [Authorize(Roles = "restaurant,admin")]
        public ActionResult Index()
        {
            List<comment> comments = models.comments.ToList();
            if (User.IsInRole("restaurant"))
            {
                ViewBag.restaurants = models.restaurants.Where(x => x.username == User.Identity.Name).ToList();
            }
            else
            {
                ViewBag.restaurants = models.restaurants.ToList();
            }

            return View(comments);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]

        public ActionResult CommentDelete(int id)
        {
            comment comment = models.comments.FirstOrDefault(x => x.comment_id == id);

            models.comments.Remove(comment);
            models.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}