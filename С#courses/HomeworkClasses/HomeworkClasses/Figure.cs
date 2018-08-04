using System;
namespace HomeworkClasses
{
    abstract class Figure
    {
        // TODO: Раскрыть в свойства с приватным полем.+ Проверь в конце центр.

        private string _name;
        private string _colour;
        protected Figure(string name, string colour, Point center)
        {
            Name = name;
            Colour = colour;
            Center = center;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("Name field isn't filled in"); }
                _name = value;
            }
        }
        public string Colour
        {
            get { return _colour; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("Colour field isn't filled in"); }
                _colour = value;
            }
        }
        public Point Center { get; set; }
        // TODO: Создать абстрактный метод для рассчета площади фигуры и периметра и переопределить в фигурах+
        protected abstract double GetPerimetr();
        protected abstract double GetSquare();

        public virtual void ShowInfo()
        {// TODO: перенеси сюда печать свойств из фигур+
            Console.WriteLine("figure:" + Name);
            Console.WriteLine("Colour:" + Colour);
            Center.ShowInfo();
            Console.WriteLine("S=" + GetSquare() + ";   P=" + GetPerimetr());
        }

    }
}
