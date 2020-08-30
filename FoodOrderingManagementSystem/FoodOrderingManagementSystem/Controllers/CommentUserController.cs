using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class CommentUserController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        DateTime now = DateTime.Now;

        [HttpPost]
        [Authorize(Roles = "user")]

        public ActionResult CommentAdd(comment c)
        {
            var userName = User.Identity.Name;
            user user = models.users.FirstOrDefault(x => x.username == userName);
            user.comment_count += 1;
            c.comment_time = now;
            c.users_id = user.users_id;
            models.comments.Add(c);
            models.SaveChanges();
            return RedirectToAction("Index","RestaurantUser",new { @id = c.restaurant_id });
        }
    }
}