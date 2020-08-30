using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    [Authorize(Roles = "admin")]
    public class CategoryAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: CategoryAdmin
        public ActionResult Index()
        {
            List<category> categories = models.categories.ToList();
            return View(categories);

        }
        public ActionResult CategoryAdd()
        {
            return View("CategoryAddOrUpdate", new category());
        }


        [ValidateAntiForgeryToken]
        public ActionResult Save(category c)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("CategoryAddOrUpdate");
            }
            models.categories.AddOrUpdate(c);
            models.SaveChanges();
            return RedirectToAction("Index","CategoryAdmin");
        }
        public ActionResult CategoryUpdate(int id)
        {
            category category = models.categories.Find(id);
            if (category == null)
                return HttpNotFound();

            return View("CategoryAddOrUpdate",category);
        }


        [HttpPost]
        public ActionResult CategoryDelete(int id)
        {
            category category = models.categories.FirstOrDefault(x => x.category_id == id);
            if (category == null)
                return HttpNotFound();
            models.categories.Remove(category);
            models.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}