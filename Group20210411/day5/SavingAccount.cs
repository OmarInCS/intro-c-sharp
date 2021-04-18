using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group20210411.day5 {
    class SavingAccount : Account{


        public SavingAccount(string name, double balance) : base(name, balance) {

        }

        public override void withdraw(int amount) {
            if (getBalance() - amount >= 0) {
                base.withdraw(amount);
            }
        }
    }
}
