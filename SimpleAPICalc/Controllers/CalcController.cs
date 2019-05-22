using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPICalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : Controller
    {
        [HttpGet("add/{value1}/{value2}")]
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        [HttpGet("sub/{value1}/{value2}")]
        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        [HttpGet("mul/{value1}/{value2}")]
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        [HttpGet("div/{value1}/{value2}")]
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }

        [HttpGet]
        public string Get()
        {
            return "Simple Web Calculator";
        }
    }
}
