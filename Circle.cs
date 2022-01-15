using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Circle : Shape
    {
        public double Radius { get; set; }
      

        public Circle(string name)
            : base(name)
        {
            
        }

        public override double GetPerimeter() => 2 * Math.PI * Radius;

        public override double GetSquare() => Math.PI * Math.Pow(Radius, 2);
       
    }
}
