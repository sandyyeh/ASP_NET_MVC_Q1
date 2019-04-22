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
           
            return View();
        }

        public ActionResult Check()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check(string name, string phone, string email)
        {
            CustomerModel model = new CustomerModel();
            model.Name = name;
            model.Phone = phone;
            model.Email = email;
            return View(model);
        }
    }
}