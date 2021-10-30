using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Service
{
    public interface IMathService
    {
        public decimal Addition(decimal a, decimal b);

        public decimal Subtraction(decimal a, decimal b);

        public decimal Multiplication(decimal a, decimal b);

        public decimal Division(decimal a, decimal b);
    }
}
