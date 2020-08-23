using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcTill22Aug.Models;
using System.Data.Entity;
using WebMvcTill22Aug.ViewModel;

namespace WebMvcTill22Aug.Controllers
{
    public class CustomersController : Controller
    {
        ApplicationDbContext _context;
		// GET: Customers
		public CustomersController()
		{
            _context = new ApplicationDbContext();
		}
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(x => x.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int? id)
        {
            var singleCustomer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(k=>k.Id==id);
            if (singleCustomer == null)
                return HttpNotFound();
            return View(singleCustomer);
        }
        public ActionResult New()
        {
            var newCustomer = _context.MembershipTypes.ToList();
            var viewModel = new CustomerMemberViewModel
            {
                MembershipTypes = newCustomer
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Delete(int? id)
        {
            var selectCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (selectCustomer == null)
                return HttpNotFound();
            _context.Customers.Remove(selectCustomer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

    }
}