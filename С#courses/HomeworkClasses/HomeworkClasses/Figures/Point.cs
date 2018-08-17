using System;
namespace Figures
{
    struct Point
    {
        /// <summary>
        /// X координата центра
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y координата центра
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Конструктор центра фигуры
        /// </summary>
        /// <param name="x">Х координата</param>
        /// <param name="y">У координата</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Печать информации о центре на экран
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Central point: X: " + X + " Y: " + Y);
        }
    }
}
