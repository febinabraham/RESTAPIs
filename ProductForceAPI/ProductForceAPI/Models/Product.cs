﻿using ProductForceAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductForceAPI.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }

    
}