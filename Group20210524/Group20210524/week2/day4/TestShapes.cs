using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day4 {
    class TestShapes {
        static void Main(string[] args) {
            Rectangle r1 = new Rectangle(4, 5, ConsoleColor.Green);
            Circle c1 = new Circle(3, ConsoleColor.Red);

            r1.PrintWithColor();
            c1.PrintWithColor();
            //Console.WriteLine($"{r1.width}, {r1.length}, {r1.GetArea()}");
            //Console.WriteLine(r1);
        }
    }
}
