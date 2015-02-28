using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebASPMVC_BS.Models
{
    public class HomeModel
    {
        public HomeModel() { footerText = "RolloRama Productions."; }

        public string footerText { get; set; }
        public int headerText { get; set; }
    }
}