using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppClassDemo.Models;
using MVCAppClassDemo.View_Model;

namespace MVCAppClassDemo.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>{
            new Movie { Id = 1, Name = "prince" }
            };
        }


        public ActionResult CustIndex()
        {
            var customer = GetCustomer();
            return View(customer);
        }
        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer{ Name="Samiran"},
                new Customer{ Name="Priyanka"}
            };
        }


        // GET: Movies
        //public ActionResult Random() //i can give any name
        //{
        //    //var movies = new MVCAppClassDemo.Models.Movie()//instance creation
        //    //{
        //    //    Name = "Gunjan Pal"
        //    //};

        //    var movies = new Movie[]
        //    {
        //        new Movie{Id=1,Name="Shrek" },
        //        new Movie{ Id=2, Name="Home Alone"}
        //    };
        //    return View(movies);
        //    //return Content("MoviesApplication");
        //    //return HttpNotFound();
        //   //return RedirectToAction("Index", "Home", new { Page = 1, SortBy = "Name" });
           
        //}
        //public ActionResult Edit(int id)
        //{
        //    return Content($"id={id}");
        //}
        //public ActionResult Index(int? pageIndx, string sortBy)
        //{
        //    if (pageIndx.HasValue)
        //    {
        //        pageIndx = 1;
        //    }
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(string.Format("PageIndex={0}  &sortBy={1}", pageIndx, sortBy));



        //}

        //[Route("Movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year+"/"+month);
        //}

        //public ActionResult PassingDataToView()
        //{
        //    var singleMovie = new Movie() {Name= "prince" };
        //    ViewData["Movie"] = singleMovie;
        //    return View("Random");
        //}

        //public ActionResult PassingDataViewBag()
        //{
        //    var hindiMov = new Movie() {Name="Dangal" };
        //    ViewBag.HindiMov = hindiMov;
        //    return View("Random");
        //}

        //public ActionResult PassingByTempdata()
        //{
        //    var tamilMovie = new Movie()
        //    {
        //         Name="Dangerous"
        //    };
        //    TempData["tamil"] = tamilMovie;
        //    return View("Random");
        //}
        //public ActionResult RandomVIewModel()
        //{
        //    var movie = new Movie() { Name = "Gunjan Saxena" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer{ Name="Samiran"},
        //        new Customer{ Name="Sam"},
        //        new Customer{ Name="Samir"},
        //        new Customer{ Name="Amir"},
        //        new Customer{ Name="Amir"},
        //        new Customer{ Name="Amir"}
        //    };

        //    var viewModel = new CustMovViewModel()
        //    {
        //        Movie = movie,
        //        Customers=customers
        //    };
        //    return View(viewModel);
        //}
    }
}