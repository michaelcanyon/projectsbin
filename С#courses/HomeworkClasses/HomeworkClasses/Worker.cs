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
        //public long INN//инн имеет 12 цифр - 
        //{
        //    get
        //    {
        //        return _INN;
        //    }
        //    set
        //    {
        //        long b = value;
        //        int i = 0;
        //        for (; b != 0; i++)
        //        {
        //            b = b / 10;
        //        }
        //        if (i != 12 || value < 0)
        //        {
        //            Console.WriteLine("INN nuber is incorrect");
        //        }
        //        else
        //        {
        //            _INN = value;
        //        }
        //    }
        //}
        public string INN
        {
            get { return _INN; }
            set
            {
                if (value == null) // TODO: расписать 3 исключения по этим условиям+
                { throw new ArgumentNullException(" INN field is empty "); }
                else if (value == "")
                { throw new ArgumentException("INN field is empty"); }
                else if (value.Length != 12)
                { throw new ArgumentException("INN nuber is incorrect"); }
                // TODO: сделать проверку каждого символа на то, является ли он числом в цикле+
                //char.IsDigit
                for (int i = 0; i < value.Length; i++)
                {
                    if ((char.IsDigit(value[i])) == false)
                    { throw new ArgumentException("Error! INN field has to contain nothing except digits."); }
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
