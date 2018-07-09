using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Worker : Person
    {
        private long _INN;
        public long INN
        {
            get
            {
                return _INN;
            }
            set
            {
                long b = value;
                int i = 0;
                for (; b != 0; i++)
                {
                    b=b/10;
                }
                if (i != 12 || value < 0)
                {
                    Console.WriteLine("INN nuber is incorrect");
                }
                else
                {
                    _INN = value;
                }
            }
        }

        public virtual void ShowInfo()
        {
            Console.Write("Name: " + Name+"\n"+"Age: "+Age+"\n"+"ИНН: "+INN+"\n");

        }
        public Worker(string name, int age, long inn)
        {
            Name = name;
            Age = age;
            INN = inn;
        }
    }

    class Manager : Worker
    {
        public int _ProjectsQuantity;
        public int ProjectsQuantity
        {
            get
            {
                return _ProjectsQuantity;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Incorrect quantity format");
                }
                else
                {
                    _ProjectsQuantity = value;
                }
            }
        }
        private int GetSalary()
        { return 30000 + ProjectsQuantity * 40000; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Profession: Manager" + "\n" + "Projects quantity per month: " + ProjectsQuantity + "\n" + "Salary per month: " + GetSalary() + "RUB"+"\n");
        }
        public Manager(string name, int age, long inn, int projectsquantity)
            : base(name, age, inn)
        {
            ProjectsQuantity = projectsquantity;
        }
    }
    class Driver : Worker
    {
        public int _HoursQuantity;
        public int HoursQuantity
        {
            get
            {
                return _HoursQuantity;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Incorrect quantity format");
                }
                else
                {
                    _HoursQuantity = value;
                }
            }
        }
        private int GetSalary()
        { return 30000 + HoursQuantity * 500; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Profession: Driver" + "\n" + "Hours quantity per month: " + HoursQuantity + "\n" + "Salary per month: " + GetSalary() + "RUB"+"\n");
        }
        public Driver(string name, int age, long inn, int hoursquantity)
            : base(name, age, inn)
        {
           HoursQuantity = hoursquantity;
        }


    }
}
