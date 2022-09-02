using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week3.day3 {
    internal class Course {
        private string title;

        public string Title {
            get {
                return title;
            }

            set {
                if (value.Length > 5) {
                    title = value;
                }
            }
        }
        public double Price { get; set; }
        public List<string> Students { get; set; }

        public Course(string title, double price) {
            this.Title = title;
            this.Price = price;
            this.Students = new List<string>();
        }

        public void AddStudent(string name) {
            Students.Add(name);
        }

        public void DropStudent(string name) {
            Students.Remove(name);
        }

        public int NumOfStudents => Students.Count;

        public void ShowStudents() {
            Console.Write("[ ");
            foreach (string name in Students) {
                Console.Write(name + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
