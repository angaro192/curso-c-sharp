using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(8010, "Bob", 100.0, 500.0);
            //Console.WriteLine("Primeira consulta: " + account.Balance);
            //Console.WriteLine(account.Loan(500.01));
            //Console.WriteLine("Segunda consulta: " + account.Balance);
            //Console.WriteLine(account.Loan(100));
            //Console.WriteLine("Saldo atual: " + account.Balance);

            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //// UpCastting
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //// DowCastting
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingAccount(1004, "Anna", 500, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
