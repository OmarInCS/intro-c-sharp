using Group20211224.day6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20211224.day7 {
    class SavingAccount : Account {
        public double limit;

        public SavingAccount(string name, double balance, double limit) : base(name, balance) {
            this.limit = limit;
        }

        public override void Withdraw(double amount) {
            if (Balance - amount >= limit) {
                base.Withdraw(amount);
            }
        }
    }
}
