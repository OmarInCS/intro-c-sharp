using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20220619.week3.day1 {
    internal class Patient {
        public string name;
        public double weight;
        public double height;

        public Patient(string name, double weight, double height) {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }

        public double CalcBMI() {
            return this.weight / Math.Pow(this.height / 100, 2);
        }

        public double BMI {
            get {
                return this.weight / Math.Pow(this.height / 100, 2);
            }
        }

        public string GetStatus() {
            double bmi = CalcBMI();
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Normal";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }
    }
}
