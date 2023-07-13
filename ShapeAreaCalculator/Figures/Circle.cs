using System;

namespace ShapeAreaCalculator.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : FigureBase
    {
        #region Constructors

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        internal Circle(double radius)
        {
            this._radius = radius;
        }

        #endregion

        #region Public Properties

        private double _radius;

        #endregion

        #region Public Methods

        /// <inheritdoc />
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this._radius, 2);
        }

        #endregion
    }
}