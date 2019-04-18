using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sandy_MVC_20190415_Q1.Models;

namespace Sandy_MVC_20190415_Q1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Detail(string name,string phone,string email,CustomerModel model)
        {
        
                if (ModelState.IsValid)
                {
                    TempData["Name"] = name;
                    TempData["Phone"] = phone;
                    TempData["Email"] = email;
                    return RedirectToAction("Check", new { Name = name, Phone = phone, Email = email });
                }
          
                return View();
         
            
                      
        }

        public ActionResult Check()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check(string name, string phone, string email)
        {
            return RedirectToAction("Save","Data", new { Name = name, Phone = phone, Email = email });
        }
    }
}