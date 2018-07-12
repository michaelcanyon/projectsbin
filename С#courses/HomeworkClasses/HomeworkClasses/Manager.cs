using System;
namespace HomeworkClasses
{
    class Manager : Worker
    {
        private int _projectsQuantity;
        public Manager(string name, int age, long inn, int projectsquantity)
           : base(name, age, inn)
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
                    Console.WriteLine("Incorrect quantity format");
                }
                else
                {
                    _projectsQuantity = value;
                }
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Profession: Manager" + "\n" + "Projects quantity per month: " + ProjectsQuantity + "\n" + "Salary per month: " + GetSalary() + "RUB" + "\n");
        }
        protected override int GetSalary()
        { return 30000 + ProjectsQuantity * 40000; }
    }
}
