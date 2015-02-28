using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebASPMVC_BS.Models;

namespace WebASPMVC_BS.Controllers
{
    public class HomeController : Controller
    {

        Models.HomeModel _homeModel;
        
        public HomeController()
        {
            _homeModel = new HomeModel();
        }
      
        public ActionResult Index()
        {
            ViewBag.Message = ".";

            ViewData.Add("FooterText", _homeModel.footerText);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
