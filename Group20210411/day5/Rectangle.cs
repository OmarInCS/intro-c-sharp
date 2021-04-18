using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day5 {
    class Rectangle : Shape {
        public double width;
        public double height;
        
        public Rectangle() : base(ConsoleColor.White) {
            Random rand = new Random();
            width = Math.Round(rand.NextDouble() * 10, 2);
            height = Math.Round(rand.NextDouble() * 10, 2);
        }

        public Rectangle(double width, double height, ConsoleColor color) : base(color) {
            this.width = width;
            this.height = height;
        }
        
        public override double GetArea() => this.width * this.height;

        public override string ToString() {
            return $"Rectangle [Area: {GetArea()}]";
        }
    }
}
