using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcTill22Aug.Models;
using System.Data.Entity;
using WebMvcTill22Aug.ViewModel;
using System.Web.UI;
using System.Windows.Forms;

namespace WebMvcTill22Aug.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext _context;
		// GET: Movies

		public MoviesController()
		{
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var movieIndex = _context.Movies.Include(f=>f.Genre).ToList();
            return View(movieIndex);
        }

        public ActionResult Details(int? id)
        {
            var selectMovie = _context.Movies.Include("Genre").SingleOrDefault(c => c.Id == id);
        
            return View(selectMovie);
        }

        public ActionResult New()
        {
            var genreList = _context.Genres.ToList();
            var addedList = new MovieGenreViewModel
            {
                Genres = genreList
            };
            return View(addedList);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");

        }

        public ActionResult Edit(int? id)
        {
            var selectMovie = _context.Movies.SingleOrDefault(c => c.Id == id);
            var sam = new SelectList(_context.Genres, "Id", "GenreName", selectMovie.GenreId);
            return View(selectMovie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            var deleted = _context.Movies.Where(c => c.Id == movie.Id).FirstOrDefault();;
            _context.Movies.Remove(deleted);
            return RedirectToAction("Index", "Movies");
            
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var selectedMovie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            
            _context.Movies.Remove(selectedMovie);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}