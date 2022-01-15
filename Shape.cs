using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Shape
    {
        public string Name { get; set; }
        
       

        public Shape(string name)
        {
            this.Name = name;
        }
        public void Show()
        {
            Console.WriteLine(Name + " ");
            
        }
        public abstract double GetPerimeter();
        abstract public double GetSquare();
    }
}
