using System;
namespace HomeworkClasses
{
    abstract class Person
    {
        private int _Age;
        public string Name { get; set; }
        public int Age
        {
            get
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
