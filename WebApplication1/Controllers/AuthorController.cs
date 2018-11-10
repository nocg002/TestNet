using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            string str = "Hello~ controller";
            ViewData["msg"] = str + "<br/>我要加油加油";
            
            return View();
        }
    }
}