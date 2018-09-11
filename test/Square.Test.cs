using NUnit.Framework;
using Shapes;

namespace Shapes.Test {
    
    [TestFixture]
    public class SquareTest {

        [Test]
        public void TestInvalidSideLength() {
            Square square;
            square = Square.Create(-1);

            Assert.IsNull(square, "Square cannot have a negative side length");
        }

        [Test]
        public void TestDefaultSideLength() {
            Square square;
            square = Square.Create();

            Assert.AreEqual(10, square.SideLength, "default side length should be 10");
        }

        [Test]
        public void TestPerimeter() {
            Square square;
            square = Square.Create(5);

            var perimeter = square.CalculatePerimeter();
            Assert.AreEqual(20, perimeter, 0, "perimeter should be 20");
        }

        [Test]
        public void TestArea() {
            Square square;
            square = Square.Create(); // use default sideLength of 10

            var area = square.CalculateArea();
            Assert.AreEqual(100, area, 0, "area should be 100");
        }

        [Test]
        public void TestHypotenuse() {
            Square square;
            square = Square.Create(5);

            var hypotenuse = square.CalculateHypotenuse();
            Assert.AreEqual(7.07, hypotenuse, 0.01, "hypotenuse should be approx. 7.07");
        }
    }
}