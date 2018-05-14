using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using mvctest.Models;
using mvctest.ViewModels;

namespace mvctest.Controllers
{
    public class HomeController : Controller
    {
        private ViewModels.RandomMovieViewModel viewModel;

        public HomeController()
        {
            var movie = new Movie() { name = "Destructor" };

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

            this.viewModel = new RandomMovieViewModel()
            {
                customers = customers,
                movie = movie
            };
        }

        public ActionResult Index()
        {
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(this.viewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}