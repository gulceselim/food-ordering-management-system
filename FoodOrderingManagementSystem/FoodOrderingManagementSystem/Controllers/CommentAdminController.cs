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
        public ActionResult Index()
        {
            List<comment> comments = models.comments.ToList();
            ViewBag.restaurants = models.restaurants.ToList();
            return View(comments);
        }

        [HttpPost]
        public ActionResult CommentDelete(int id)
        {
            comment comment = models.comments.FirstOrDefault(x => x.comment_id == id);

            models.comments.Remove(comment);
            models.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}