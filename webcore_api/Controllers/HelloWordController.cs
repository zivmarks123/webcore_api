using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcore_api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class HelloWordController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            return Ok("Hello Developer Nir");
        }
    }
}
