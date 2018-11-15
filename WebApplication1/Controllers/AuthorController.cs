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
            ViewData["msg"] = "Hello~~~~";
            int[] arr = new int[3];
            for (int i = 0; i < 20; i++) {
                arr[i] = i + 1;
            }
            string str = string.Join("-", arr);
            
            return View();
        }
    }
}