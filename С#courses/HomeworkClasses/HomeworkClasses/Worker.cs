using System;
namespace HomeworkClasses
{
    abstract class Worker : Person
    {
        private long _INN;
        protected Worker(string name, int age, long inn)
        {
            Name = name;
            Age = age;
            INN = inn;
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
        abstract protected int GetSalary();
    }
}
