using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers {
    public class HomeController : Controller {
        /// <summary>Log</summary>
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();


        public ActionResult Index() {
            logger.Info("我是 Index() action");
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.22222222222222222222222222";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.2222222222222222222222222222222222222222222222222222";

            return View();
        }
    }
}