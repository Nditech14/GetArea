using System;
    namespace GetArea
{
    public  class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(16);
            Console.WriteLine($"Area of Rectangle: {circle.GetArea()}");
            var cone = new Cone(4, 6);
            Console.WriteLine($"Area of Cone: {cone.GetArea()}");
            var triangle = new Triangle(8, 4);
            Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");
            var rectangle = new Rectangle(10, 4);
            Console.WriteLine($"Area of Cone: {rectangle.GetArea()}");
        }
    }
}