using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiqroMoney.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Money On Demand.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Info.";

            return View();
        }

        public ActionResult FAQs()
        {
            ViewBag.Message = "Frequently Asked Questions.";

            return View();
        }

        public ActionResult Borrow()
        {
            ViewBag.Message = "How much can I borrow?";

            return View();
        }

        public ActionResult Benefits()
        {
            ViewBag.Message = "Benefits.";

            return View();
        }

        public ActionResult Requirements()
        {
            ViewBag.Message = "Requirements.";

            return View();
        }

        public ActionResult Repayment()
        {
            ViewBag.Message = "Repayment.";

            return View();
        }

    }
}
