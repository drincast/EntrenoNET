using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvctest.Models;
using mvctest.ViewModels;

namespace mvctest.Controllers
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
            return new List<Movie>()
            {
                new Movie { id = 1, name = "Shrek" },
                new Movie { id = 2, name = "Wall-e" }
            };
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Destructor" };

            //ViewData["RandomMovie"] = movie;
            //ViewBag.Movie2 = movie;

            var viewResult = new ViewResult();

            var customers = new List<Customer>()
            {
                new Customer
                {
                    name = "customer 01"
                },
                new Customer()
                {
                    name = "customer 02"
                },
            };

            var viewModel = new RandomMovieViewModel()
            {
                customers = customers,
                movie = movie
            };

            //return View(movie);
            //return Content("Destructor !!");
            //return Redirect("https://www.google.com");
            //return Json(movie, JsonRequestBehavior.AllowGet);
            return View(viewModel);
        }

        public ActionResult Index2(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        } 

        [Route("movies/released/{year}/{month:regex(\\d{2})}") ]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult test(int year, int month)
        {
            var movie = new Movie() { name = "Destructor" };

            ViewData["Movie"] = movie;

            return Content(year + "/" + month);
        }

        
    }
}