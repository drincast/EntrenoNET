using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using mvctest.Models;

namespace mvctest.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);    
        }

        // GET: Customers        
        public ActionResult Index()
        {
            //var customers = GetCustomers();
            var customers = this._context.Customers.Include(c => c.membershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.id == id);
            var customer = this._context.Customers.SingleOrDefault(c => c.id == id);

            if (customer == null)
                return null;

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer { id = 1, name = "John Smith" },
                new Customer { id = 2, name = "Mary Williams" }
            };
        }
    }
}