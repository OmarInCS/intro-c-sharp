using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week3.day1 {
    class ArrayCopy {
        //static void Main(string[] args) {
        //    int[] x = { 10, 20, 30 };
        //    //int[] y = x;
        //    int[] y = new int[x.Length];
        //    Array.Copy(x, y, x.Length);

        //    y[0] += 3;

        //    PrintArray(x);
        //    PrintArray(y);

        //    Console.WriteLine(Max(x));
        //    Console.WriteLine(Max(13, 17, 12));
        //}

        static void PrintArray(int[] arr) {
            Console.Write("[ ");
            foreach (int e in arr) {
                Console.Write(e + ", ");
            }
            Console.WriteLine(" ]");
        }

        static int Max(params int[] arr) {
            int best = arr[0];
            foreach (int e in arr) {
                if (e > best) {
                    best = e;
                }
            }

            return best;
        }
    }
}
