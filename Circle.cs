using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitClass
{
    public class Circle
    {
        public double CalculateAreaCircle(double R)
        {
            double result = Math.PI * Math.Pow(R, 2);
            return result;
        }

        public double CalculatePerimetrCircle(double R)
        {
            double result = Math.PI * R * 2;
            return result;
        }
    }
}
