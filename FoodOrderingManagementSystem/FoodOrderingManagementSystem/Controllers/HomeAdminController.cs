﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: HomeAdmin
        [Authorize(Roles = "admin,restaurant")]
        public ActionResult Index()
        {
            return View();
        }
    }
}