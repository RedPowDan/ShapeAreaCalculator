using ShapeAreaCalculator.Figures;

namespace ShapeAreaCalculator.FigureFactory
{
    /// <summary>
    /// Фабрика создания фигур.
    /// </summary>
    public interface IFigureFactory
    {
        /// <summary>
        /// Создает круг.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        /// <returns>Круг.</returns>
        public Circle CreateCircle(double radius);

        /// <summary>
        /// Создает треугольник по трем сторонам.
        /// </summary>
        /// <param name="side1">Первая сторона.</param>
        /// <param name="side2">Вторая сторона.</param>
        /// <param name="side3">Третья сторона.</param>
        /// <returns>Треугольник.</returns>
        public Triangle CreateTriangle(double side1, double side2, double side3);
    }
}