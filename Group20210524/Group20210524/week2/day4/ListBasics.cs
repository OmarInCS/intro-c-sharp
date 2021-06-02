using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210524.week2.day4 {
    class ListBasics {
        //static void Main(string[] args) {
        //    List<int> marks = new List<int>();
        //    marks.Add(19);
        //    marks.Add(21);
        //    marks.Add(23);
        //    marks.Add(24);

        //    PrintList(marks);

        //    marks.Insert(0, 13);
        //    PrintList(marks);

        //    //marks.Remove(21);
        //    //PrintList(marks);
        //    marks.RemoveAt(2);
        //    PrintList(marks);

        //    Console.WriteLine(marks.Max());
        //    Console.WriteLine(marks.Average());
        //}

        public static void PrintList(List<int> lst) {
            Console.Write("[");
            foreach (int e in lst) {
                Console.Write(e + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
