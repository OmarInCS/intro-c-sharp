using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day5 {
    class Circle : Shape{

        public double Radius { get; set; }

        public Circle(double radius, ConsoleColor color) : base(color) {
            Radius = radius;
        }

        public override double GetArea() {
            return Math.PI * Radius * Radius;
        }

        public override string ToString() {
            return $"Circle [Area: {GetArea()}]";
        }

    }
}
