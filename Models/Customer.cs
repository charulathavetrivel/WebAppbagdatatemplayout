using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppbagdatatemplayout.Models
{
    public class Customer
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string CAddress { get; set; }
        public int CSalary { get; set; }
    }
}