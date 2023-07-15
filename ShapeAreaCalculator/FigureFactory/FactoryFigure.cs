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
            var circle = new Circle(radius);
            circle.ValidateFigure();

            return circle;
        }

        /// <inheritdoc />
        public Triangle CreateTriangle(
            double side1,
            double side2,
            double side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            triangle.ValidateFigure();

            return triangle;
        }

        #endregion
    }
}