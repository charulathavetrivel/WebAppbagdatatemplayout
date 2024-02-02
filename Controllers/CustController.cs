using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppbagdatatemplayout.Models;

namespace WebAppbagdatatemplayout.Controllers
{
    public class CustController : Controller
    {
        // GET: Cust
        public ActionResult Index()
        {
            ViewBag.msg = "Customer home page";
            return View();
        }
        public ActionResult CustList()
        {
            List<string> list = new List<string>()
            {
                "charu",
                "Abi",
                "Mani",
                "Tamil"
            };
            ViewBag.CustList = list;
            return View();
        }
    }
}