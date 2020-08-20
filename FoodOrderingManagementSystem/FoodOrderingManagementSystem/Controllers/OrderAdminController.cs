using FoodOrderingManagementSystem.Models;
using FoodOrderingManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderingManagementSystem.Controllers
{
    public class OrderAdminController : Controller
    {

        FoodOrderingMSModel models = new FoodOrderingMSModel();
        // GET: OrderAdmin
        public ActionResult Index()
        {
            List<OrderVM> orderVMList = new List<OrderVM>();

            var orderList = (from order in models.orders
                                  from shipper in models.shippers
                                  from os in models.order_shipper
                                  from user in models.users
                                  from product in models.products
                                  from op in models.order_product
                                  where
                                  order.order_id == os.order_id && shipper.shipper_id == os.shipper_id && product.product_id == op.product_id && op.order_id == order.order_id && order.users_id == user.users_id
                                  select new
                                  {
                                      order.order_id,
                                      userName = user.first_name + " " + user.last_name,
                                      product.product_name,
                                      order.order_type,
                                      order.price,
                                      shipperName = shipper.first_name + " " + shipper.last_name,
                                      order.order_details,
                                  }).ToList();

            foreach (var item in orderList)
            {
                OrderVM order = new OrderVM();
                order.order_id = item.order_id;
                order.user_name = item.userName;
                order.product_name = item.product_name;
                order.order_type = item.order_type;
                order.price = item.price;
                order.shipper_name = item.shipperName;
                order.order_details = item.order_details;
                orderVMList.Add(order);
            }

            return View(orderVMList);
        }


    }
}