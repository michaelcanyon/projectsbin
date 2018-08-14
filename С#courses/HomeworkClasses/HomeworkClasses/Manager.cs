using System;

namespace HomeworkClasses
{
    class Manager : Worker
    {
        private int _projectsQuantity;

        /// <summary>
        /// Конструктор рабочего-менеджера
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="inn"></param>
        /// <param name="projectsquantity"></param>
        /// <param name="rate"></param>
        /// <param name="minimalsalary"></param>
        public Manager(string name, int age, string inn, int projectsquantity, double rate, double minimalsalary)
           : base(name, age, inn, rate, minimalsalary)
        {
            ProjectsQuantity = projectsquantity;
        }

        /// <summary>
        /// Количество выполненных проектов
        /// </summary>
        public int ProjectsQuantity
        {
            get
            { return _projectsQuantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Incorrect quantity format");
                _projectsQuantity = value;
            }
        }

        /// <summary>
        /// Печать информации о менеджере
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Profession: Manager" + "\n" + "Projects quantity per month: " + ProjectsQuantity + "\n" + "Salary per month: " + GetSalary() + "RUB" + "\n");
        }

        /// <summary>
        /// Рассчёт ЗП менеджера
        /// </summary>
        /// <returns></returns>
        protected override double GetSalary()
        { return 30000 + ProjectsQuantity * Rate; }
    }
}
