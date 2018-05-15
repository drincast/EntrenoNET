using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        public short signUpFee { get; set; }
        public byte durationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}