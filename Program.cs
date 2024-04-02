using GitClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GitClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();

            Console.Write("Введите радиус окружности  ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону квадрата  ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь окружности - {circle.CalculateAreaCircle(R)}");
            Console.WriteLine($"Периметр окружности - {circle.CalculatePerimetrCircle(R)}");

            Console.WriteLine($"Площадь квадрата - {square.CalculateAreaSquare(A)}");
            Console.WriteLine($"Периметр квадрата - {square.CalculatePerimetrSquare(A)}");
        }
    }
}