using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public object SayHello(HelloData data)
        {

            NorthwindContext context = new();
            Category category = new()
            {
                CategoryName = data.Username,
                Description = "Shoe number: " + data.Shoenumber
            };
            context.Categories.Add(category);
            context.SaveChanges();

            return new
            {
                Text = $"Hello {data.Username} from C#!"
            };
        }
    }
}