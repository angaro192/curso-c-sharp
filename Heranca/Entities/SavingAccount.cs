using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class SavingAccount: Account
    {
        public double IterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double iterestRate)
            : base(number, holder, balance)
        {
            IterestRate = iterestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * IterestRate;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            // base.Withdraw(amount);
        }
    }
}
