﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Web;

namespace ODataActionSample
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public IDictionary<string, object> Properties { get; set; }

        public IList<Order> Orders { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }

        public double Price { get; set; }
    }

    public class Address
    {
        public string City { get; set; }

        public IDictionary<string, object> Properties { get; set; }
    }
}