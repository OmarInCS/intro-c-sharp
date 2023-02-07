using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20221106.Week4.Day2 {
    internal class Account {

        public string name;
        private double balance;
        public static double annualRate = 0.04;

        public double Balance { 
            get { return balance; } 
            set {
                balance = value;
            } 
        }

        public Account(string name, double balance) {
            this.name = name;
            this.balance = balance;
        }

        public static double MonthlyRate => annualRate / 12;

        public double MonthlyInterest => MonthlyRate * balance;

        public void Deposit(int amount) {
            balance += amount;
        }

        public void Withdraw(int amount) {
            balance -= amount;
        }


    }
}
