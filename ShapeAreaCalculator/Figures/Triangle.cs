using System;

namespace ShapeAreaCalculator.Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : FigureBase
    {
        internal Triangle(double side1, double side2, double side3)
        {
            this._side1 = side1;
            this._side2 = side2;
            this._side3 = side3;
        }

        private double _side1;
        private double _side2;
        private double _side3;

        /// <inheritdoc />
        public override double CalculateArea()
        {
            var perimeter = (this._side1 + this._side2 + this._side3) / 2;
            return Math.Sqrt(
                perimeter * (perimeter - this._side1) * (perimeter - this._side2) * (perimeter - this._side3));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            double hypotenuse, cathetus1, cathetus2;

            if (this._side1 >= this._side2 && this._side1 >= this._side3)
            {
                hypotenuse = this._side1;
                cathetus1 = this._side2;
                cathetus2 = this._side3;
            }
            else if (this._side2 >= this._side1 && this._side2 >= this._side3)
            {
                hypotenuse = this._side2;
                cathetus1 = this._side1;
                cathetus2 = this._side3;
            }
            else
            {
                hypotenuse = this._side3;
                cathetus1 = this._side1;
                cathetus2 = this._side2;
            }

            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2))) < 0.0001;
        }
    }
}