using System;
using System.Collections.Generic;

#nullable disable

namespace demoapp2.Models
{
    public partial class TestTable
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PicFileName { get; set; }
        public byte[] PictureData { get; set; }
    }
}
