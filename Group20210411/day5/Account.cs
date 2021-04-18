using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day5 {
    class Account {
        public string name;
        private double balance;
        public static double annualRate = 0.04;

        public Account(string name, double balance) {
            this.name = name;
            this.balance = balance;
        }

        public static double getMonthlyRate() {
            return annualRate / 12;
        }

        public double getMonthlyInt() {
            return getMonthlyRate() * balance;
        }

        public virtual void withdraw(int amount) {
            balance -= amount;
        }

        public void deposit(int amount) {
            balance += amount;
        }

        public double getBalance() {
            return balance;
        }
    }
}
