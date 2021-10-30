using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpPost]
        [Route("Addition")]
        public decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        [HttpPost]
        [Route("Subtraction")]
        public decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        [HttpPost]
        [Route("Multiplication")]
        public decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        [HttpPost]
        [Route("Division")]
        public decimal Division(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
