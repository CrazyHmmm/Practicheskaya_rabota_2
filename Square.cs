using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitClass
{
    public class Square
    {
        public double CalculateAreaSquare(double A)
        {
            double result =  Math.Pow(A, 2);
            return result;
        }

        public double CalculatePerimetrSquare(double A)
        {
            double result =  A * 4;
            return result;
        }
    }
}
