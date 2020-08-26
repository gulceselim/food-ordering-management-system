using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
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

        public ActionResult RoleUpdate(int id)
        {
            role role = models.roles.FirstOrDefault(x => x.role_id == id);

            return View(role);
        }

        [HttpPost]

        public ActionResult RoleUpdate(role r)
        {
            role role = models.roles.FirstOrDefault(x => x.role_id == r.role_id);
            role.role_name = r.role_name;
            models.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RoleDelete(int id)
        {
            role role = models.roles.FirstOrDefault(x => x.role_id == id);
            models.roles.Remove(role);
            models.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult RoleAdd()
        {
            List<role> roles = models.roles.ToList();
            return View(roles);
        }
        [HttpPost]
        public ActionResult RoleAdd(role r)
        {
            models.roles.Add(r);
            models.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}