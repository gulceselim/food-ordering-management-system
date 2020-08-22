using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class CategoryAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: CategoryAdmin
        public ActionResult Index()
        {
            List<category> categories = models.categories.ToList();
            return View(categories);

        }
        public ActionResult CategoryUpdate(int id)
        {
            category category = models.categories.FirstOrDefault(x => x.category_id == id);

            return View(category);
        }

        [HttpPost]

        public ActionResult CategoryUpdate(category c)
        {
            category category = models.categories.FirstOrDefault(x => x.category_id == c.category_id);
            category.category_name = c.category_name;
            models.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult CategoryDelete(int id)
        {
            category category = models.categories.FirstOrDefault(x => x.category_id == id);
            models.categories.Remove(category);
            models.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(category c)
        {
            models.categories.Add(c);
            models.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}