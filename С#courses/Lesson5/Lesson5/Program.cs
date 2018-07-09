using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle();
            //int side = tr.Side;
            Console.WriteLine(tr.Side);
            tr.Side = 5;
            tr.Color = "White";
            tr.Center = new Point() { X = 5, Y = 7 };
            tr = new Triangle(5, "White", new Point() { X = 5, Y = 7 });
            Console.ReadLine();

        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public void ShowInfo()
            {
                Console.WriteLine(" point X: " + X + ", Y: " + Y);
            }
        }
        class Triangle
        {
            //порядок коментирования элементов класса
            //Статические члены
            //приватные поля 
            //Конструкторы
            //Публичные свойства и методы
            //Приватные методы
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
            public readonly int SomeField;//переменная, которую можно изменить только в конструкторе




            //public void SetSide(int value)
            //{
            //    //if (value <= 0)
            //    //{
            //    //    Console.WriteLine("Length of the triangles edge can't be lower or equal null");
            //    //}
            //    //else
            //    //    _side = value;
            //    _side = value;
            //}

            //public int GetSide()
            //{
            //    return _side;
            //}

            //public int Side { get; set; }//свойство - это эквивалент с 28-42 строку

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
                Console.WriteLine("Color: "+Color);
                Console.WriteLine("Cente  triangle:");
                Center.ShowInfo();
                Console.WriteLine("Perimetr: " + GetPerimetr());
                Console.WriteLine("Area: " + GetSquare());
            }

            public Triangle()
            {
                SomeField = 42;//в конструкторе
                Name = "Triangle";
                Side = 1;
                Color = "Without color";
            }
            public Triangle(int side, string Color, Point center )
            {
                Side = side;
                this.Color = Color;
                center = center;
            }
        }

        class Circle
        {

        }
        class Square
        {

        }
    }
}
