using CelToFerTmp.Models;//when we use Class as input to ActionResult we have to add This Using Models
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CelToFerTmp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
           // CheckTemp.CalcTemp();
            return View();
        }
     
        [HttpPost]
        public ActionResult Index(string name,string hypo, string scale, int temp=0)
        {
            if (name!="")
            {
                CheckTemp.Name = name;
                CheckTemp.Temp =temp;

                  if (hypo == "hypothermia" && CheckTemp.Temp<32 )
                  {
                      ViewBag.hypo = "There is hypothermia";
                  }
                  else if (hypo == "hypothermia" && CheckTemp.Temp >= 32)
                  {
                      ViewBag.hypo = "There is no hypothermia";
                  }
                  else
                  {
                     ViewBag.hypo = "";
                  }

                  if (scale == "celsius")
                  {
                    CheckTemp.CalcTemp();
                    ViewBag.Fah = "";
                  }
                  else 
                  {
                      CheckTemp.CalcTemp();
                      ViewBag.Fah = CheckTemp.Temp * (9 / 5) + 32;
                  }
            }
            else
            {
                ViewBag.err="error,fill the name of patient";
            }
            return View();
        }
    }
}