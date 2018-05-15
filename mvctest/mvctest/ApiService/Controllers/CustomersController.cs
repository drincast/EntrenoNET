using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ApiService.Models;

namespace ApiService.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public IHttpActionResult Get()
        {
            var customers = CrearCustomers();

            return Ok(customers); //new string[] { "value1", "value2" };
        }

        // GET: api/Customers/5
        public string Get(int id)
        {
            var customer = RetornarCustomer(id);
            return "value";
        }

        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }

        private List<Customer> CrearCustomers()
        {
            List<Customer> list = new List<Customer>()
            {
                new Customer()
                {
                    id = 1,
                    isSubcribedToNewsletter = false,
                    membershipType = new MembershipType()
                    {
                        id = 0,
                        signUpFee = 0,
                        durationInMonths = 0,
                        DiscountRate = 0,
                        name = "Pay as You Go"
                    },
                    membershipTypeId = 0,
                    name = "Andres"
                },
                new Customer()
                {
                    id = 2,
                    isSubcribedToNewsletter = true,
                    membershipType = new MembershipType()
                    {
                        id = 1,
                        signUpFee = 30,
                        durationInMonths = 1,
                        DiscountRate = 10,
                        name = "Monthly"
                    },
                    membershipTypeId = 1,
                    name = "Marian Antonia"
                },
                new Customer()
                {
                    id = 3,
                    isSubcribedToNewsletter = true,
                    membershipType = new MembershipType()
                    {
                        id = 3,
                        signUpFee = 90,
                        durationInMonths = 3,
                        DiscountRate = 15,
                        name = "Quarterly"
                    },
                    membershipTypeId = 3,
                    name = "Doctor Chapatin"
                },
            };

            return list;
        }

        private Customer RetornarCustomer(int id)
        {
            var customers = CrearCustomers();

            var customer = customers.Find(c => c.id == id);

            return customer;
        }
    }
}
