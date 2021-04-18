using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day5 {
    class TestShapes {
        //static void Main(string[] args) {
        //    Rectangle r1 = new Rectangle(4, 5, ConsoleColor.Red);
        //    Circle c1 = new Circle(3, ConsoleColor.Green);
        //    //Shape s1 = new Shape(ConsoleColor.Yellow);

        //    //Console.WriteLine(r1.GetType());
        //    //Console.WriteLine(r1.TimeCreated);
        //    //r1.PrintWithColor();
        //    //Console.WriteLine("-----------------");
        //    //Console.WriteLine(c1.GetType());
        //    //Console.WriteLine(c1.TimeCreated);
        //    //c1.PrintWithColor();
        //    PrintShapeDetails(r1);
        //    PrintShapeDetails(c1);

        //}

        static void PrintShapeDetails(Shape s) {
            Console.WriteLine(s.GetType());
            Console.WriteLine(s.TimeCreated);
            s.PrintWithColor();
            Console.WriteLine(s.GetArea());
            //if (s is Rectangle) {
            //    Console.WriteLine((s as Rectangle).GetArea());
            //}
            //else if (s is Circle) {
            //    Console.WriteLine((s as Circle).GetArea());
            //}
            Console.WriteLine("-------------------");
        }
    }
}
