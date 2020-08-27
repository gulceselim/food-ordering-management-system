using FoodOrderingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class CategoryUserController : Controller
    {
        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: CategoryUser
        public ActionResult Index(int id)
        {
            List<product> products = models.products.Where(x => x.category_id == id).ToList();
            return View(products);

        }

    }
}