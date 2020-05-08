using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class CarInforController : Controller
    {
        // GET: CarInfor
        //购物车
        public ActionResult Car()
        {
            return View();
        }
        public ActionResult Del()
        {
            return View();
        }
    }
}