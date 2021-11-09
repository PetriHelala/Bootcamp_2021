using System;
using System.Collections.Generic;

#nullable disable

namespace MvcDatabaseDemo2.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
