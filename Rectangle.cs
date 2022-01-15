using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
       

        public Rectangle(string name)
            :base(name)
        {

        }

        public override double GetPerimeter() => (Height + Width) * 2;

        public override double GetSquare() => Height * Width;
    }
}
