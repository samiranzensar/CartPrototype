using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppsCart.Models;

namespace WebAppsCart.Controllers
{
    public class ProductController : Controller
    {
        AppsDb _context;
		public ProductController()
		{
            _context = new AppsDb();
		}
        // GET: Product
        public ActionResult Index()
        {
            var prod = _context.Products.ToList();

            return View(prod);
        }
    }
}