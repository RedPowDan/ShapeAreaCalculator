using System;
using NUnit.Framework;
using ShapeAreaCalculator.Calculators;
using ShapeAreaCalculator.FigureFactory;

namespace Tests
{
    [TestFixture]
    public class TestsForFigures
    {
        private readonly IFigureCalculator _figureCalculator;
        private readonly IFigureFactory _figureFactory;
        
        public TestsForFigures()
        {
            this._figureCalculator = new FigureCalculator();
            this._figureFactory = new FigureFactory();
        }
        
        /// <summary>
        /// Проверка на правильность расчитывания площади круга.
        /// </summary>
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            const int radius = 5;
            var expectedArea = Math.PI * Math.Pow(radius, 2);
            var circle = this._figureFactory.CreateCircle(radius);
            
            var actualArea = this._figureCalculator.CalculateArea(circle);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        
        [Test]
        public void CreateCircle_ZeroRadius_ThrowsArgumentException()
        {
            // Arrange
            const int radius = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateCircle(radius));
        }
        
        [Test]
        public void CreateCircle_NegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            const int radius = -10;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateCircle(radius));
        }
        
        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            const int side1 = 3;
            const int side2 = 4;
            const int side3 = 5;
            const int expectedArea = 6;
            var triangle = this._figureFactory.CreateTriangle(side1, side2, side3);

            // Act
            var actualArea = this._figureCalculator.CalculateArea(triangle);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
        
        [Test]
        public void CreateTriangle_ZeroSide1_ThrowsArgumentException()
        {
            // Arrange
            const int side1 = 0;
            const int side2 = 4;
            const int side3 = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateTriangle(side1, side2, side3));
        }
        
        [Test]
        public void CreateTriangle_ZeroSide2_ThrowsArgumentException()
        {
            // Arrange
            const int side1 = 3;
            const int side2 = 0;
            const int side3 = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateTriangle(side1, side2, side3));
        }
        
        [Test]
        public void CreateTriangle_ZeroSide3_ThrowsArgumentException()
        {
            // Arrange
            const int side1 = 3;
            const int side2 = 4;
            const int side3 = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateTriangle(side1, side2, side3));
        }

        [Test]
        public void CreateTriangle_NegativeSide1_ThrowsArgumentException()
        {
            // Arrange
            const int side1 = -3;
            const int side2 = 4;
            const int side3 = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateTriangle(side1, side2, side3));
        }

        [Test]
        public void CreateTriangle_NegativeSide2_ThrowsArgumentException()
        {
            // Arrange
            const int side1 = 3;
            const int side2 = -4;
            const int side3 = 5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateTriangle(side1, side2, side3));
        }

        [Test]
        public void CreateTriangle_NegativeSide3_ThrowsArgumentException()
        {
            // Arrange
            const int side1 = 3;
            const int side2 = 4;
            const int side3 = -5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._figureFactory.CreateTriangle(side1, side2, side3));
        }
        
        [Test]
        public void IsRightTriangle_ValidSides_ReturnsCorrectAnswer()
        {
            // Arrange
            const int side1 = 17;
            const int side2 = 15;
            const int side3 = 8;
            var triangle = this._figureFactory.CreateTriangle(side1, side2, side3);

            // Act
            var actualResult = this._figureCalculator.IsRightTriangle(triangle);

            // Assert
            Assert.IsTrue(actualResult);
        }
        
                
        [Test]
        public void IsRightTriangle_ValidSides_ReturnsIncorrectAnswer()
        {
            // Arrange
            const int side1 = 17;
            const int side2 = 15;
            const int side3 = 6;
            var triangle = this._figureFactory.CreateTriangle(side1, side2, side3);

            // Act
            var actualResult = this._figureCalculator.IsRightTriangle(triangle);

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}