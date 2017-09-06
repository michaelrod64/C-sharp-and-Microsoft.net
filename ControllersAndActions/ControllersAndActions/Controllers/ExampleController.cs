using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        
        public ViewResult Index()
        {

            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Data"];
            return View();
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToAction("Index", "Basic");
        }

        public HttpStatusCodeResult StatusCode()
        {
            return new HttpUnauthorizedResult();
        }

        public RedirectToRouteResult RedirectToRoute()
        {
            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }

    }
}
