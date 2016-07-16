using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult ListPage()
        {
            return View();
        }

        public ActionResult EditPage(int id)
        {
            ViewBag.InfoId = id;
            return View();
        }

        [Authorize]
        public ActionResult Delete()
        {
            return View();
        }
       
    }
}