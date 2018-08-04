using System;
namespace HomeworkClasses
{
    struct Point
    { //TODO: Подумать - класс или структура(+-)
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
