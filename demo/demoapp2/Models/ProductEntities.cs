using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoapp2.Models
{
    public class ProductEntities
    {       
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string PictureData { get; set; }
    }
}
