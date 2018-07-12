using System;
namespace HomeworkClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            circle1.Name = "circle 1";
            circle1.radius = 34;
            circle1.Center = new Point(21, 24);
            circle1.ShowInfo();
            Console.WriteLine();

            Square square1 = new Square("figure", "Green", 2, new Point(4, 15));
            square1.ShowInfo();
            Console.WriteLine();

            Triangle triangle1 = new Triangle("Ето треугольник", "цвета радуги", 7, 8, 9, new Point(5, 17));
            triangle1.ShowInfo();

            Console.WriteLine();

            Worker Sam = new Manager("Sam", 25, 234543691543, 3);
            Worker Jim = new Driver("Jim", 40, 143562184564, 207);
            Sam.ShowInfo();
            Console.WriteLine();
            Jim.ShowInfo();
            Console.ReadLine();

        }
    }
}
