using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class triangle
    {
    }
    class Triangle
    { 
        int X { get; set; }
        int Y { get; set; }

        /// <summary>
        /// Имя треугольника
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// цвет треугольника
        /// </summary>
        public string Color { get; set; }
        //private int _side;




        
        /// <summary>
        /// Сторона треугольника
        /// </summary>
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length of the triangles edge can't be lower or equal null");
                }
                else { _side = value; }
            }
        }
        private int GetPerimetr()
        {
            return Side * 3;
        }
        private double GetSquare()
        {
            return Math.Pow(Side, 2) * Math.Sqrt(3) / 4;

        }

        /// <summary>
        /// Печать информации о треугольнике
        /// </summary>
        ///<returns> Площадь треуголньика </returns>>
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Cente  triangle:");
            Center.ShowInfo();
            Console.WriteLine("Perimetr: " + GetPerimetr());
            Console.WriteLine("Area: " + GetSquare());
        }

        public Triangle()
        {
            Name = "Triangle";
            Side = 1;
            Color = "Without color";
        }
        public Triangle(int side, string Color, Point center)
        {
            Side = side;
            this.Color = Color;
            center = center;
        }
    }

}
}
