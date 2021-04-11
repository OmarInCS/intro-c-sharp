using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week4.day1 {
    class Rectangle : Shape {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle() : base(ConsoleColor.Red) {

        }

        public Rectangle(double width, double length, ConsoleColor color) : base(color) {
            this.Width = width;
            this.Length = length;
        }

        public double GetArea() {
            return this.Width * this.Length;
        }

        public override string ToString() {
            return $"Rectangle [Area: {GetArea()}]";
        }
    }
}
