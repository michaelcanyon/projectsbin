﻿using System;
namespace Figures
{
    abstract class FigureWithSide : Figure
    {
        private int _side;

        /// <summary>
        /// Конструктор фигуры с учетом её стороны.
        /// </summary>
        /// <param name="name">Название фигуры</param>
        /// <param name="colour">Цвет фигуры</param>
        /// <param name="center">Центр фигуры</param>
        /// <param name="side">Сторона фигуры</param>
        protected FigureWithSide(string name, string colour, Point center, int side)
            : base(name, colour, center)
        {
            Side = side;
        }

        /// <summary>
        /// Сторона фигуры
        /// </summary>
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Side can't be negative or null");
                _side = value;
            }
        }
    }
}
