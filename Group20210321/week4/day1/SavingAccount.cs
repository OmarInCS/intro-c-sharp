using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210321.week4.day1 {
    class SavingAccount : Account{

        public SavingAccount(string name, double balance) : base(name, balance) {

        }

        public override void Withdraw(double amount) {
            if (Balance - amount >= 0) {
                base.Withdraw(amount);
            }
        }

    }
}
