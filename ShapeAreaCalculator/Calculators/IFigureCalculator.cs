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

        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="triangle">Треугольник.</param>
        /// <returns>Результат проверки.</returns>
        public bool IsRightTriangle(Triangle triangle);

        #endregion
    }
}