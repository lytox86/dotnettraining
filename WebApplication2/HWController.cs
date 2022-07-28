using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2
{
    [Route("api/[controller]")]
    [ApiController]
    public class HWController : ControllerBase
    {
        [HttpGet]
        public IResult GetHelloWorld()
        {
            return Results.Ok("Hello!");
        }
    }
}
