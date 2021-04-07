using Group20210321.week3.day3;
using System;
using System.Collections.Generic;


namespace Group20210321.week3.day4 {
    class Course {
        private string title;
        private List<Student> students;

        public string Title {
            get {
                return title;
            }
        }

        public List<Student> Students {
            get {
                return students;
            }
        }

        public Course(string title) {
            this.title = title;
            this.students = new List<Student>();
        }

        public void AddStudent(Student st) {
            students.Add(st);
        }

        public void DropStudent(string name) {
            foreach (Student st in students) {
                if (st.name == name) {
                    students.Remove(st);
                    return;
                }
            }
        }

        public int GetNumOfStudents() {
            return students.Count;
        }

        public void PrintStudents() {
            Console.Write("[");
            foreach (Student e in students) {
                Console.Write(e + ", ");
            }
            Console.WriteLine("]");
        }

        public static bool operator >(Course c1, Course c2) {
            return c1.GetNumOfStudents() > c2.GetNumOfStudents();
        }

        public static bool operator <(Course c1, Course c2) {
            return c1.GetNumOfStudents() < c2.GetNumOfStudents();
        }

        public static Course operator +(Course c, Student st) {
            c.AddStudent(st);
            return c;
        }
    }
}
