using System;
using System.Collections.Generic;

#nullable disable

namespace demoapp2.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public byte[] PictureData { get; set; }
    }
}
