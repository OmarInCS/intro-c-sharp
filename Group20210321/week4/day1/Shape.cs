using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week4.day1 {
    class Shape : Object{
        public ConsoleColor Color { get; set; }

        public Shape(ConsoleColor color) {
            this.Color = color;
        }

        public void PrintWithColor() {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(this);
            Console.ResetColor();
        }
    }
}
