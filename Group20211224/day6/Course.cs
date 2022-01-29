using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day6 {
    class Course {
        private string title;
        private double price;
        private List<string> students;

        public string Title {
            get {
                return title;
            }

            set {
                title = value;
            }
        }

        public double Price {
            get {
                return price;
            }

            set {
                price = value;
            }
        }

        public List<string> Students {
            get {
                return students;
            }
        }

        public Course(string title, double price) {
            this.title = title;
            this.price = price;
            this.students = new List<string>();
        }

        public void AddStudent(string name) {
            students.Add(name);
        }

        public void DropStudent(string name) {
            students.Remove(name);
        }

        public int GetNumOfStudents() {
            return students.Count;
        }

        public void WriteAllStudents() {
            Console.Write("[ ");
            foreach (var n in students) {
                Console.Write(n + ", ");
            }
            Console.WriteLine(" ]");
        }

        public static bool operator >(Course lhs, Course rhs) {
            return lhs.Price > rhs.Price;
        }

        public static bool operator <(Course lhs, Course rhs) {
            return lhs.Price < rhs.Price;
        }

        public static Course operator +(Course lhs, string rhs) {
            lhs.students.Add(rhs);
            return lhs;
        }
    }
}
