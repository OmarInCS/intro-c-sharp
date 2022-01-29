using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day6 {
    class Account {
        public string name;
        private double balance;
        public static double annualRate = 0.04;

        public double Balance {
            get { return balance;  }
        }

        public Account (string name, double balance) {
            this.name = name;
            this.balance = balance;
        }

        //public static double GetMonthlyRate {
        //    get {
        //        return annualRate / 12;
        //    }
        //}

        public static double MonthlyRate => annualRate / 12;

        public double MonthlyInterest => MonthlyRate * balance;

        public void Deposit(double amount) {
            balance += amount;
        }

        public virtual void Withdraw(double amount) {
            balance -= amount;
        }

        public static Account operator +(Account lhs, double rhs) {
            lhs.balance += rhs;
            return lhs;
        }

        public static Account operator -(Account lhs, double rhs) {
            lhs.balance -= rhs;
            return lhs;
        }

    }
}
