using ShapeAreaCalculator.Figures;

namespace ShapeAreaCalculator.Calculators
{
    /// <summary>
    /// Калькулятор для фигуры.
    /// </summary>
    public class FigureCalculator : IFigureCalculator
    {
        #region Public Methods

        /// <inheritdoc />
        public double CalculateArea(FigureBase figure)
        {
            return figure.CalculateArea();
        }

        /// <inheritdoc />
        public bool IsRightTriangle(Triangle triangle)
        {
            return triangle.IsRightTriangle();
        }

        #endregion
    }
}