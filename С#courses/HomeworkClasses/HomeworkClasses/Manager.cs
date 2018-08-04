using System;
namespace HomeworkClasses
{
    class Manager : Worker
    {
        private int _projectsQuantity;
        public Manager(string name, int age, string inn, int projectsquantity, double rate, double minimalsalary)
           : base(name, age, inn, rate, minimalsalary)
        {
            ProjectsQuantity = projectsquantity;
        }
        public int ProjectsQuantity
        {
            get
            {
                return _projectsQuantity;
            }

            set
            {
                if (value < 0)
                {
                   throw new ArgumentException("Incorrect quantity format");
                }
                    _projectsQuantity = value;
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Profession: Manager" + "\n" + "Projects quantity per month: " + ProjectsQuantity + "\n" + "Salary per month: " + GetSalary() + "RUB" + "\n");
        }
        protected override double GetSalary()
        { return 30000 + ProjectsQuantity * Rate; }
    }
}
