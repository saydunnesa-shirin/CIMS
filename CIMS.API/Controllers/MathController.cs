using CIMS.Service;
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
        private readonly IMathService _mathService;
        public MathController(IMathService mathService)
        {
            _mathService = mathService;
        }
        [HttpPost]
        [Route("Addition")]
        public decimal Addition(decimal a, decimal b)
        {
            return _mathService.Addition(a, b);
        }

        [HttpPost]
        [Route("Subtraction")]
        public decimal Subtraction(decimal a, decimal b)
        {
            return _mathService.Subtraction(a, b);
        }

        [HttpPost]
        [Route("Multiplication")]
        public IActionResult Multiplication(decimal a, decimal b)
        {
            var result = _mathService.Multiplication(a, b);
            return Ok(result);
        }

        [HttpPost]
        [Route("Division")]
        public decimal Division(decimal a, decimal b)
        {
            return _mathService.Division(a, b);
        }
    }
}
