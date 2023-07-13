using ShapeAreaCalculator.Figures;

namespace ShapeAreaCalculator.Calculators
{
    /// <summary>
    /// Калькулятор для фигур. В данном случае только считает площадь.
    /// </summary>
    public interface IFigureCalculator
    {
        #region Public Methods

        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <param name="figure">Фигура у которой нужно узнать площадь.</param>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea(FigureBase figure);

        public bool IsRightTriangle(Triangle figure);

        #endregion
    }
}