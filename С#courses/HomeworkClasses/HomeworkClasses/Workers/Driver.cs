using System;
namespace Workers

{
    class Driver : Worker
    {
        private int _hoursQuantity;

        /// <summary>
        /// Конструктор рабочего - водителя
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="inn"></param>
        /// <param name="hoursquantity"></param>
        /// <param name="rate"></param>
        /// <param name="minimalsalary"></param>
        public Driver(string name, int age, string inn, int hoursquantity, double rate, double minimalsalary)
            : base(name, age, inn, rate, minimalsalary)
        {
            HoursQuantity = hoursquantity;
        }

        /// <summary>
        /// Количество отработанных часов
        /// </summary>
        public int HoursQuantity
        {
            get
            {
                return _hoursQuantity;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Incorrect quantity format");
                else
                    _hoursQuantity = value;
            }
        }

        /// <summary>
        /// Печать инфрмации о водителе
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Profession: Driver" + "\n" + "Hours quantity per month: " + HoursQuantity + "\n" + "Salary per month: " + GetSalary() + "RUB" + "\n");
        }

        /// <summary>
        /// Рассчёт ЗП водителя
        /// </summary>
        /// <returns>ЗП водителя</returns>
        protected override double GetSalary()
        { return 30000 + HoursQuantity * Rate; }
    }
}
