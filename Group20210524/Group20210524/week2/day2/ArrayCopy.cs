using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day2 {
    class ArrayCopy {
        //static void Main(string[] args) {
        //    int[] x = { 10, 20, 30 };
        //    //int[] y = x;
        //    int[] y = (int[]) x.Clone();

        //    y[1] += 3;

        //    PrintArray(x);
        //    PrintArray(y);
        //}

        static void PrintArray(int[] arr) {
            Console.Write("[ ");
            foreach (int a in arr) {
                Console.Write(a + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
