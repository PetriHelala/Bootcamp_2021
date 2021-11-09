using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTestController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public string Hello()
        {
            return "Hello World!";
        }
    }
}