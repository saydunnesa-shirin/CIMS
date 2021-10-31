using System;

namespace CIMS.Service
{
    public class MathService : IMathService
    {
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal Addition(decimal a, decimal b) => a + b;

        /// <summary>
        /// Subtract two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal Subtraction(decimal a, decimal b) => a - b;

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal Multiplication(decimal a, decimal b) => a * b;

        /// <summary>
        /// Divide two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public decimal Division(decimal a, decimal b) => a / b;

    }
}
