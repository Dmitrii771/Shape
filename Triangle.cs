using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Triangle : Shape 
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double h { get; set; }

        public Triangle(string name)
            :base(name)
        {

        }

        public double Check(double a, double b, double c)
        {
            if(a > b + c || b > a + c || c > a + b)
            {
                Console.WriteLine("Треугольник не существует");
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        public override double GetPerimeter() => a + b + c;
        public override double GetSquare() => (c * h) / 2;
      

    }
}
