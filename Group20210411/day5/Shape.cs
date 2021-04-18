using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day5 {
    abstract class Shape : Object {
        public ConsoleColor Color { get; set; }
        public DateTime TimeCreated { get; private set; }

        public Shape(ConsoleColor color) {
            Color = color;
            TimeCreated = DateTime.Now;
        }

        public void PrintWithColor() {
            Console.ForegroundColor = Color;
            Console.WriteLine(this);
            Console.ResetColor();
        }

        public abstract double GetArea();
    }
}
