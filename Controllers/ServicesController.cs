using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiaphonV2.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Print()
        {
            ViewBag.Message = "This is the Print Service Page.";

            return View();
        }

        public ActionResult Branding()
        {
            ViewBag.Message = "This is the Branding & Design Service Page.";

            return View();
        }
        
        public ActionResult Digital()
        {
            ViewBag.Message = "This is the Digital Solutions Service Page.";

            return View();
        }
    }
}