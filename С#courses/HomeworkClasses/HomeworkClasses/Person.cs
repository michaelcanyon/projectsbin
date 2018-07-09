using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    abstract class Person
    {
        public string Name { get; set; }

        private int _Age; 
        public int Age
        { get
            {
                return _Age;
            }
            set
            {
                if (value < 14 || value > 120)
                {
                    Console.WriteLine("Perdon is too young or old for work");
                }
                else
                {
                    _Age = value;
                }
            }
        }
    }
}
