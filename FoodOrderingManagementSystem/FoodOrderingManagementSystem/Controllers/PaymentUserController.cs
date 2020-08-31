using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    [Authorize(Roles = "user")]
    public class PaymentUserController : Controller
    {
        // GET: PaymentUser
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        public ActionResult PaymentAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PaymentAdd(payment p)
        {
            models.payments.Add(p);
            user user = models.users.FirstOrDefault(x => x.username == User.Identity.Name);
            user.payment_id = p.payment_id;
            models.SaveChanges();

            return RedirectToAction("Index","ProfilUser");
        }

        [HttpPost]
        

        public ActionResult PaymentDelete(int id)
        {
            payment payment = models.payments.FirstOrDefault(x => x.payment_id == id);
            user user = models.users.FirstOrDefault(x => x.username == User.Identity.Name);
            user.payment_id = null;
            models.payments.Remove(payment);
            models.SaveChanges();
            return RedirectToAction("Index", "ProfilUser");


        }
    }
}