using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppbagdatatemplayout.Models;

namespace WebAppbagdatatemplayout.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        static List<Customer> ListC = new List<Customer>
        {
            new Customer{CId=1,CName="sandy",CAddress="Hyd",CSalary=23000},
            new Customer{CId=2,CName="kiru",CAddress="Blr",CSalary=24000},
            new Customer{CId=3,CName="Malu",CAddress="Chennai",CSalary=25000},
            new Customer{CId=4,CName="Manju",CAddress="Vellore",CSalary=26000},
            new Customer{CId=5,CName="Divya",CAddress="Salem",CSalary=27000},
            new Customer{CId=6,CName="Ila",CAddress="Ooty",CSalary=28000},


        };
        public ActionResult Index()
        {
            ViewBag.msg = "Welcome All";
            ViewBag.noCustomer = ListC.Count;
            return View(ListC);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["msg"] = "Customer Loggedin";
            return View(new Customer());
        }
        [HttpPost]
        public ActionResult Create(Customer custom)
        {
            if (ModelState.IsValid)
            {
                ListC.Add(custom);
                TempData["tempmsg"] = "Customer loggedin successfully ";
                return RedirectToAction("Index");
            }
            else
            {
                return View(custom);
            }
        }

        [HttpGet]
        public ActionResult Delete(int cid)
        {
            Customer custom = ListC.SingleOrDefault(e => e.CId == cid);

            return View(custom);
        }

        [HttpPost]
        public ActionResult Delete(int? cid)
        {
            Customer custom = ListC.SingleOrDefault(e => e.CId == cid);
            if (custom != null)
            {
                ListC.Remove(custom);
            }
            return RedirectToAction("Index");

        }
    }
}