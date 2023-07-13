using System;
using ShapeAreaCalculator.Figures;

namespace ShapeAreaCalculator.FigureFactory
{
    /// <summary>
    /// Реализация фабрики создания фигур.
    /// </summary>
    public class FigureFactory : IFigureFactory
    {
        #region Public Methods
        
        /// <inheritdoc />
        public Circle CreateCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            return new Circle(radius);
        }

        /// <inheritdoc />
        public Triangle CreateTriangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Все стороны треугольника должны быть положительными числами.");
            }

            return new Triangle(side1, side2, side3);
        }

        #endregion
    }
}