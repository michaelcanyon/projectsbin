using System;
namespace HomeworkClasses
{
    abstract class Figure
    {
        private string _name;
        private string _colour;

        /// <summary>
        /// Конструктор абстрактной фигуры. Используется в классах-наследниках.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="center"></param>
        protected Figure(string name, string colour, Point center)
        {
            Name = name;
            Colour = colour;
            Center = center;
        }

        /// <summary>
        /// Имя фигуры
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value ?? throw new ArgumentNullException("Name field isn't filled in");
            }
        }

        /// <summary>
        /// Цвет фигуры
        /// </summary>
        public string Colour
        {
            get { return _colour; }
            set
            {
                _colour = value ?? throw new ArgumentNullException("Colour field isn't filled in");
            }
        }

        /// <summary>
        /// Инициализация поля центра фигуры
        /// </summary>
        public Point Center { get; set; }

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double GetPerimetr();

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double GetSquare();

        /// <summary>
        /// Печать информации о фигуре
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine("figure:" + Name);
            Console.WriteLine("Colour:" + Colour);
            Center.ShowInfo();
            Console.WriteLine("S=" + GetSquare() + ";   P=" + GetPerimetr());
        }

    }
}
