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
        public ActionResult Detail(CustomerModel model)
        {
           
            return View();
        }

        public ActionResult Check()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check(CustomerModel customer)
        {

            CustomerModel model = new CustomerModel();
            if (ModelState.IsValid)
            {
                model.Name = customer.Name;
                model.Phone = customer.Phone;
                model.Email = customer.Email;
                return View(model);
            }            
            return View("Detail");
        }
    }
}