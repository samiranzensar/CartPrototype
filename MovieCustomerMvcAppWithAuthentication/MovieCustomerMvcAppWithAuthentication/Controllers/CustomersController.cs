using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieCustomerMvcAppWithAuthentication.Models;
using System.Data.Entity;
using MovieCustomerMvcAppWithAuthentication.ViewModel;

namespace MovieCustomerMvcAppWithAuthentication.Controllers
{

    public class CustomersController : Controller
    {
        // GET: Customers

        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(k => k.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var singleCustomer = _context.Customers.Include(k => k.MembershipType).SingleOrDefault(c => c.Id == id);
            if (singleCustomer == null)
            {
                return HttpNotFound();
            }
            return View(singleCustomer);
        }

        public ActionResult MovieIndex()
        {
            var movie = _context.Movies.ToList();
            return View(movie);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }
		protected override void Dispose(bool disposing)
		{
            _context.Dispose();
		}


	}
}