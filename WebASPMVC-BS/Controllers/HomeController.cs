using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using WebASPMVC_BS.FirstDBModel;
using WebASPMVC_BS.Models;

namespace WebASPMVC_BS.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context();


        Models.HomeModel _homeModel;
        
        public HomeController()
        {
            _homeModel = new HomeModel();
        }
      
        public ActionResult Index()
        {
            ViewBag.Message = ".";

            ViewData.Add("FooterText", _homeModel.footerText);

            if ((Request!=null) && Request.IsAjaxRequest())
            {
                return PartialView("_SearchList");
            }

            return View(db.TRACKs.ToList());
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
