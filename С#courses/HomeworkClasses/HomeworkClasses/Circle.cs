using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeworkClasses
{
    class Circle:BasicParametrs
    {
      
        private int _radius;
        
        public int radius
        {
            get { return _radius; }
            set
            {
            if (value <= 0)
            {
                    Console.WriteLine("Incorrect radius meaning. It can't be negative or null.");

            }
            else
             { _radius = value; }
            }
        }
        private int GetPerimetr()
        {
            return 2*radius * (int)Math.PI;   
        }
        private int GetSquare()
        {
            return (int)Math.PI * (int)Math.Pow(radius, 2);
        }

        public void ShowInfo()
        {
            Console.WriteLine("figure:" + Name);
            Console.WriteLine("Colour:" + Colour);
            Console.WriteLine("Radius equals " + radius);
            Center.ShowInfo();
            Console.WriteLine("S=" + GetSquare() + ";   P=" + GetPerimetr());
        }
        public Circle()
        {
            Name = "Default Circle";
            Colour = "Black like your ex's blood";
            radius = 666;
            Center = new Point(6, 9);


        }
        public Circle(string name, string colour, int Radius, Point center)
        {
            Name = name;
            Colour = colour;
            radius = Radius;
            Center = center;

        }


    }
}
