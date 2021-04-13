using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day3 {
    class ArrayMultiDim {
        //static void Main(string[] args) {
        //    //int[] marks = new int[5];
        //    //int[,] marks = {
        //    //    {23, 20, 17 },
        //    //    {19, 13, 18 },
        //    //    {25, 24, 25 },
        //    //    {10, 13, 12 }
        //    //};

        //    int[][] marks = {
        //        new int[] {23, 20, 17 },
        //        new int[] {19, 13, 18 , 21},
        //        new int[] {25, 24, 25 },
        //        new int[] {10, 13, 12 }
        //    };

        //    //Console.WriteLine(marks[1, 1]);
        //    //Console.WriteLine(marks[2, 1]);
        //    Console.WriteLine(marks[1][1]);
        //    Console.WriteLine(marks[2][1]);

        //    for (int i = 0; i < marks.Length; i++) {
        //        for (int j = 0; j < marks[i].Length; j++) {
        //            //if (marks[i, j] < 25) {
        //            //    marks[i, j] += 1;
        //            //}
        //            if (marks[i][j] < 25) {
        //                marks[i][j] += 1;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < marks.Length; i++) {
        //        for (int j = 0; j < marks[i].Length; j++) {
        //            //Console.Write(marks[i, j] + ", ");
        //            Console.Write(marks[i][j] + ", ");
        //        }
        //        Console.WriteLine();
        //    }

        //}

        public static void PrintArray(int[] arr) {
            Console.Write("[");
            foreach (int n in arr) {
                Console.Write(n + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
