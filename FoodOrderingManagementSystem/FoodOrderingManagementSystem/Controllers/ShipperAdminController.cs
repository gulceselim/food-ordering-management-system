using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class ShipperAdminController : Controller
    {

        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: ShipperAdmin
        public ActionResult Index()
        {
            List<shipper> shippers = models.shippers.ToList();
            ViewBag.restaurants = models.restaurants.ToList();
            return View(shippers);
        }
        public ActionResult ShipperUpdate(int id)
        {
            shipper shipper = models.shippers.FirstOrDefault(x => x.shipper_id == id);
            return View(shipper);
        }

        [HttpPost]

        public ActionResult ShipperUpdate(shipper s)
        {
            shipper shipper = models.shippers.FirstOrDefault(x => x.shipper_id == s.shipper_id);
            shipper.first_name = s.first_name;
            shipper.last_name = s.last_name;
            shipper.identification_number = s.identification_number;
            models.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ShipperAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ShipperAdd(shipper s)
        {
            models.shippers.Add(s);
            models.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ShipperDelete(int id)
        {
            shipper shipper = models.shippers.FirstOrDefault(x => x.shipper_id == id);

            models.shippers.Remove(shipper);
            models.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}