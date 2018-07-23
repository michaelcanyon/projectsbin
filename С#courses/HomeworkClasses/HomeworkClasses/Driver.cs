using System;
namespace HomeworkClasses
{
    class Driver : Worker
    {
        private int _hoursQuantity;
        public Driver(string name, int age, long inn, int hoursquantity, double rate, double minimalsalary)
            : base(name, age, inn, rate, minimalsalary)
        {
            HoursQuantity = hoursquantity;

        }
        public int HoursQuantity
        {
            get
            {
                return _hoursQuantity;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Incorrect quantity format");
                }
                else
                {
                    _hoursQuantity = value;
                }
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Profession: Driver" + "\n" + "Hours quantity per month: " + HoursQuantity + "\n" + "Salary per month: " + GetSalary() + "RUB" + "\n");
        }
        protected override double GetSalary()
        { return 30000 + HoursQuantity * Rate; }
    }
}
