﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        public bool isSubcribedToNewsletter { get; set; }
        public MembershipType membershipType { get; set; }
        public byte membershipTypeId { get; set; }
    }
}