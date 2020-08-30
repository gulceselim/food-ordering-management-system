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
    public class RoleAdminController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: RoleAdmin
        public ActionResult Index()
        {
            List<role> roles = models.roles.ToList();

            return View(roles);
        }
        public ActionResult RoleAdd()
        {
            return View("RoleAddOrUpdate",new role());
        }

        [ValidateAntiForgeryToken]
        public ActionResult Save(role r)
        {
            models.roles.AddOrUpdate(r);
            models.SaveChanges();
            return RedirectToAction("Index","RoleAdmin");
        }
        public ActionResult RoleUpdate(int id)
        {
            role role = models.roles.FirstOrDefault(x => x.role_id == id);
            if (role == null)
                return HttpNotFound();
            return View("RoleAddOrUpdate",role);
        }

        [HttpPost]
        public ActionResult RoleDelete(int id)
        {
            role role = models.roles.FirstOrDefault(x => x.role_id == id);
            if (role == null)
                return HttpNotFound();
            models.roles.Remove(role);
            models.SaveChanges();

            return RedirectToAction("Index");
        }

        
    }
}