using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Orb:Circle, IVoulumeFigure
    {

        public double height { get; set; }
        public Orb(string name, string colour, int Radius, Point center)
            : base(name, colour, Radius, center)
        {}
  
        public double GetVolume()
        {
            return (4 / 3) * Math.PI * (Radius * Radius * Radius);
        }
        public double GetVolumeSquare()
        {
            return 4 * Math.PI * (Radius * Radius);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Volume equals " + GetVolume());
            Console.WriteLine("Orb square equals " + GetVolumeSquare());
        }
    }
}
