using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Webform()
        {
            return View();
        }

        public ActionResult LayoutDemos()
        {
            return View();
        }

        public ActionResult ClientSideDemo()
        {
            return View();
        }

        public ActionResult Absolute() 
        {
            return View();
        }

        public ActionResult Static()
        {
            return View();
        }

        public ActionResult Float()
        {
            return View();
        }

        public ActionResult ServerSideDemo()
        {
            return View();
        }

        public ActionResult FormatPhoneNumber(string inputNumber)
        {

            if (string.IsNullOrEmpty(inputNumber) || inputNumber.Length != 10)
            {
                //return Content("Invalid input. Please enter a 10 digit phone number.");
                string formatted = "";
                return View((object)formatted);
            }
            else
            {
                string formatted = formatNumber(inputNumber);
                return View((object)formatted);
            }
        }

        private string formatNumber(string inputNumber)
        {
            string areaCode = inputNumber.Substring(0, 3);
            areaCode = areaCode.Insert(0, "(").Insert(4, ")");
            string phoneNumber = inputNumber.Substring(3, 3) + "-" + inputNumber.Substring(6, 4);
            string formattedNumber = areaCode + " " + phoneNumber;
            return formattedNumber;
        }

        public ActionResult AboutMe()
        {
            return View();
        }

    }
}
