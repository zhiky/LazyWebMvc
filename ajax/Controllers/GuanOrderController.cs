using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class GuanOrderController : Controller
    {
        // GET: GuanOrder
        public ActionResult GuanOrderShow()
        {
            return View();
        }
        public ActionResult Filled()
        {
            return View();
        }
    }
}