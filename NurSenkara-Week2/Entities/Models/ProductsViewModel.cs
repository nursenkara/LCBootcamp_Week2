﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
    }
}
