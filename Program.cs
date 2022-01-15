using System;

namespace ConsoleApp7
{
    class Program 
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle("circle") { Radius = 4 };

            var shape1 = new Rectangle("rectangle") { Height = 3, Width = 5 };
            var shape2 = new Triangle("triangle") { a = 3, b = 4, c = 5, h = 2 };

            shape.Show();
            shape1.Show();
            shape2.Show();

            ShowInfo(shape);
            ShowInfo(shape1);
            // ShowInfo(shape2);

            double r = shape2.Check(3, 4, 5);
            if(r == 1)
            {
                ShowInfo(shape2);
            }
          


            Console.ReadKey();
        }
        
        

        public static void ShowInfo(Shape shape)
        {
            Console.WriteLine($"Периметр: {shape.GetPerimeter()}, Площадь: {shape.GetSquare()}");
        }
        
    }
}
