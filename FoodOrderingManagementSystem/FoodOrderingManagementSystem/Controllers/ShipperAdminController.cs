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
            return View(shippers);
        }
    }
}