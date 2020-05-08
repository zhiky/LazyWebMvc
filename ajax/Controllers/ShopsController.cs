using ajax.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class ShopsController : Controller
    {
        //登录
        public ActionResult Login()
        {
            return View();
        }
        //商品列表
        // GET: Shops
        public ActionResult Show()
        {
            return View();
        }
        /// <summary>
        /// 详情详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Find()
        {
            return View();
        }
    }
}