namespace Figures
{
    /// <summary>
    /// Интерфейс с полями и методами для создания объемной фигуры
    /// </summary>
    interface IVoulumeFigure
    {
        /// <summary>
        /// Объем фигуры
        /// </summary>
        /// <returns>Объем фигуры</returns>
        double GetVolume();

        /// <summary>
        /// Площадь поверхности фигуры
        /// </summary>
        /// <returns>Объем фигуры</returns>
        double GetVolumeSquare();
    }
}
