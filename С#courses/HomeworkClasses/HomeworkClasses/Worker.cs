using System;
namespace HomeworkClasses
{
    abstract class Worker : Person
    {
        private string _INN;
        private double _rate;
        private double _miminalSalary;

        /// <summary>
        /// Конструктор рабочего. Так же, как и человек, используется только в классах-наследниках
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="inn"></param>
        /// <param name="rate"></param>
        /// <param name="minimalSalary"></param>
        protected Worker(string name, int age, string inn, double rate, double minimalSalary)
            : base(age, name)
        {
            INN = inn;
            Rate = rate;
            MinimalSalary = minimalSalary;
        }

        /// <summary>
        /// Минимальная заработная плата
        /// </summary>
        public double MinimalSalary
        {
            get { return _miminalSalary; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Error!MInSalary can't be negative or null.");
                _miminalSalary = value;
            }
        }

        /// <summary>
        /// Ставка, по которой начисляется ЗП
        /// </summary>
        public double Rate
        {
            get { return _rate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Error!Rate can't be negative or null.");
                _rate = value;
            }
        }

        /// <summary>
        /// ИНН рабочего
        /// </summary>
        public string INN
        {
            get { return _INN; }
            set
            {
                //ИНН физ.лица должен содержать ровно 12 цифр.
                if (string.IsNullOrEmpty(value))
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

        /// <summary>
        /// Печать информации о рабочем
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.Write("Name: " + Name + "\n" + "Age: " + Age + "\n" + "ИНН: " + INN + "\n");
        }

        /// <summary>
        /// Рассчёт ЗП
        /// </summary>
        /// <returns></returns>
        abstract protected double GetSalary();
    }
}
