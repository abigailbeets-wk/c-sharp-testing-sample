using System;

namespace Shapes {

    public class Square {

        public int SideLength { get; }

        private Square(int sideLength) {
            this.SideLength = sideLength;
        }

        private Square() {
            this.SideLength = 10;
        }

        public static Square Create(int sideLength) {
            if (sideLength <= 0) {
                return null;
            }

            return new Square(sideLength);
        }

        public static Square Create() {
            return new Square();
        }
        
        public int CalculatePerimeter() {
            return this.SideLength * 4;
        }

        public int CalculateArea() {
            return this.SideLength * this.SideLength;
        }

        public double CalculateHypotenuse() {
            var sideSquared = this.SideLength * this.SideLength;

            return Math.Sqrt(sideSquared * 2);
        }
    }
}