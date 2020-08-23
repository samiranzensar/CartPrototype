using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppClassDemo.Models;

namespace MVCAppClassDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1,Name="David"},
                new Customer{Id=2,Name="David Smith"},
                new Customer{Id=3,Name="David Bekar"},
                new Customer{Id=4,Name="David Allen"},
                new Customer{Id=5,Name="David Bannerjee"}
            };
        }


        public ActionResult Details(int id)
        {
			var singleCustomer = GetCustomers().SingleOrDefault(c=>c.Id==id);
            if (singleCustomer == null)
            {
                return HttpNotFound();
            }
            return View(singleCustomer);
        }
        
    }
}