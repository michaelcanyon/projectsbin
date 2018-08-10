using System;
namespace HomeworkClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c2 = new Circle();
            Circle circle1 = new Circle("circle 1", "white", 34, new Point(21, 24));
            circle1.ShowInfo();
            Console.WriteLine();

            Square square1 = new Square("figure", "Green", 2, new Point(4, 15));
            square1.ShowInfo();
            Console.WriteLine();

            Triangle triangle1 = new Triangle("Ето треугольник", "цвета радуги", 7, new Point(5, 17));
            triangle1.ShowInfo();

            Console.WriteLine();

            Worker Sam = new Manager("Sam", 25, "234553691543", 3, 40000, 50000);
            Worker Jim = new Driver("Jim", 40, "143532184564", 207, 250, 30000);
            Sam.ShowInfo();
            Console.WriteLine();
            Jim.ShowInfo();
            Console.WriteLine();

            Cube cube = new Cube("Cube", "Bright", 2, new Point(3, 75));
            Orb orb = new Orb("Orb", "white", 34, new Point(21, 24));
            Tetrahedron T = new Tetrahedron("Ето тетраэдр", "цвета радуги", 7, new Point(6, 12));
            cube.ShowInfo();
            Console.WriteLine();
            orb.ShowInfo();
            Console.WriteLine();
            T.ShowInfo();
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
