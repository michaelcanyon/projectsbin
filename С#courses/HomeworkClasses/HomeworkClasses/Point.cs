using System;
namespace HomeworkClasses
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Central point: X: " + X + " Y: " + Y);
        }
    }
}
