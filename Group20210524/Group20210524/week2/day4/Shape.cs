using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day4 {
    class Shape {
        public ConsoleColor Color { get; set; }

        public Shape(ConsoleColor color) {
            Color = color;
        }

        public void PrintWithColor() {
            Console.ForegroundColor = Color;
            Console.WriteLine(this);
            Console.ResetColor();
        }
    }
}
