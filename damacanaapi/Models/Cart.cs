﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace damacanaapi.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateTime { get; set; }
        public List<Product> Cartproducts { get; set; }

    }
}