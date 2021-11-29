using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }
        public string Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
                LoanLimit -= amount;
                return "Emprestimo de R$" + amount + " recebido com sucesso!"; 
            }else
            {
                return "Limite de emprestimo foi excedido.";
            }
        }
    }
}
