using System;
namespace HomeworkClasses
{
    abstract class Worker : Person
    {
        private string _INN;
        private double _rate;
        private double _miminalSalary;
        protected Worker(string name, int age, string inn, double rate, double minimalSalary)
            : base(age, name)
        {
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
                    throw new ArgumentException("Error!MInSalary can't be negative or null.");
                }
                _miminalSalary = value;
            }
        }
        public double Rate
        {
            get { return _rate; }
            set
            {
                if (value <= 0)
                {
                    // TODO: Заменить на исключение+
                    throw new ArgumentException("Error!Rate can't be negative or null.");
                    //Environment.Exit(int code);
                }
                _rate = value;
            }
        }

        public string INN
        {
            get { return _INN; }
            set
            {
                if (string.IsNullOrEmpty(value)) // TODO: расписать 3 исключения по этим условиям+
                    throw new ArgumentNullException(" INN field is empty ");
                else if (value.Length != 12)
                    throw new ArgumentException("INN nuber is incorrect"); 
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(char.IsDigit(value[i])))
                        throw new ArgumentException("Error! INN field has to contain nothing except digits.");
                }
                _INN = value;
            }
        }
        public virtual void ShowInfo()
        {
            Console.Write("Name: " + Name + "\n" + "Age: " + Age + "\n" + "ИНН: " + INN + "\n");
        }
        abstract protected double GetSalary();
    }
}
