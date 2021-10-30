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
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Addition")]
        public decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtract two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Subtraction")]
        public decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Multiplication")]
        public decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }

        /// <summary>
        /// Devide two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Division")]
        public decimal Division(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
