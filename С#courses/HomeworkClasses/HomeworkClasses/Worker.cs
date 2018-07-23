using System;
namespace HomeworkClasses
{
    abstract class Worker : Person
    {
        private long _INN;
        private double _rate;
        private double _miminalSalary;
        protected Worker(string name, int age, long inn, double rate, double minimalSalary)
        {
            Name = name;
            Age = age;
            INN = inn;
            Rate = rate;
            MinimalSalary = minimalSalary;
        }
        public double MinimalSalary
        {
            get { return _miminalSalary; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error!MInSalary can't be negative or null.");
                    return;
                }
                else { _miminalSalary = value; }
            }
        }
        public double Rate
        {
            get { return _rate; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error!Rate can't be negative or null.");
                    return;
                }
                else
                { _rate = value; }
            }
        }
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
                    b = b / 10;
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
            Console.Write("Name: " + Name + "\n" + "Age: " + Age + "\n" + "ИНН: " + INN + "\n");

        }
        abstract protected double GetSalary();
    }
}
