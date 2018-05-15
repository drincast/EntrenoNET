using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ApiService.Models;

namespace ApiService.Controllers
{
    public class MembershipTypesController : ApiController
    {
        // GET: api/MembershipTypes
        public IHttpActionResult Get()
        {
            var memberships = CrearMembershipTypes();

            return Ok(memberships);
        }

        // GET: api/MembershipTypes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MembershipTypes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MembershipTypes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MembershipTypes/5
        public void Delete(int id)
        {
        }

        private List<MembershipType> CrearMembershipTypes()
        {
            List<MembershipType> list = new List<MembershipType>()
            {
                new MembershipType()
                {
                    id = 1,
                    signUpFee = 0,
                    durationInMonths = 0,
                    DiscountRate = 0,
                    name = "Pay as You Go"
                },
                new MembershipType()
                {
                    id = 2,
                    signUpFee = 30,
                    durationInMonths = 1,
                    DiscountRate = 10,
                    name = "Monthly"
                },
                new MembershipType()
                {
                    id = 3,
                    signUpFee = 90,
                    durationInMonths = 3,
                    DiscountRate = 15,
                    name = "Quarterly"
                },
                new MembershipType()
                {
                    id = 4,
                    signUpFee = 300,
                    durationInMonths = 12,
                    DiscountRate = 30,
                    name = "Annual"
                },
            };

            return list;
        }
    }
}
