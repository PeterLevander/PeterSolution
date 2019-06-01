using PeterWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeterWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Pension()
        {
            
            DateTime minPensionDate = new DateTime(2020, 02, 01);
            Pension myPension = new Pension();
            myPension.MyEndDate = minPensionDate;
            myPension.MonthsLeft = GetDifferenceBetwineDates(DateTime.Now, minPensionDate,"m");
            myPension.WeeksLeft = GetDifferenceBetwineDates(DateTime.Now, minPensionDate, "w");
            myPension.DaysLeft = GetDifferenceBetwineDates(DateTime.Now, minPensionDate, "d");
            myPension.HouresLeft = GetDifferenceBetwineDates(DateTime.Now, minPensionDate, "h");

            return View(myPension);

        }

        /// <summary>
        /// Returnera en siffer differens mellan två datum
        /// </summary>
        /// <param name="startDate">Startdatum</param>
        /// <param name="endDate">Slutdatum</param>
        /// <param name="type">Vilken typ M-months, W-weeks, d-Days</param>
        /// <returns>resultat med en siffra</returns>
        public static int GetDifferenceBetwineDates(DateTime startDate, DateTime endDate, string type)
        {
            int result = 0;
            if (type.ToLower() == "m")
            {
                result = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            }
            if (type.ToLower() == "w")
            {
                TimeSpan tt = startDate - endDate;
                result = tt.Days / 7;
            }
            if (type.ToLower() == "d")
            {
                TimeSpan tt = startDate - endDate;
                result = (int)tt.TotalDays;
            }
            if (type.ToLower() == "h")
            {
                TimeSpan tt = startDate - endDate;
                result = (int)tt.TotalHours;
            }


            return Math.Abs(result);
        }
    }
}