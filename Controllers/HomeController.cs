using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNet;
using DotNet.Models;


namespace DotNet.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult e404()
        {
            return View();
        }
        public ActionResult Index()
        {
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            else if (Request.HttpMethod == "POST")
            {
                Session["UID"] = Request.Form["klantid"];
            }
            return Redirect("/Home/e404");

        }
        public ActionResult Reserv()
        {
            data data = new data();
            if (Request.HttpMethod == "GET")
            {
                
                Session["data"] = data;
                return View();
            }
            else if (Request.HttpMethod == "POST")
            {
                data.Reserveer((int)Session["UID"], (int) Convert.ToInt32(Request.Form["SLOC"]), Convert.ToInt32(Request.Form["ELOC"]), Convert.ToInt32(Request.Form["VEHI"]), Request.Form["STAR"], Convert.ToInt32(Request.Form["DLEN"]));
                return Redirect("/Home/Overzicht");
            }
            return Redirect("/Home/e404");
            

        }

        public ActionResult Regis()
        {
            return View();
        }
    }
}