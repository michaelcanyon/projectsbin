namespace HomeworkClasses
{
    /// <summary>
    /// Интерфейс с полями и методами для создания объемной фигуры
    /// </summary>
    interface IVoulumeFigure
    {
        /// <summary>
        /// Высота фигуры
        /// </summary>
        double height { get; set; }

        /// <summary>
        /// Объем фигуры
        /// </summary>
        /// <returns></returns>
        double GetVolume();

        /// <summary>
        /// Площадь поверхности фигуры
        /// </summary>
        /// <returns></returns>
        double GetVolumeSquare();
    }
}
