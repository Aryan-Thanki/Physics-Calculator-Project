using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Calculator
{
    class OperationCalculation
    {
        /// <summary>
        /// Addition Operation Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Addition(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Subtraction Operation Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// Multiplication Operation Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// Divisiion Operation Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Division(double a, double b)
        {
            return a / b;
        }
    }
}
