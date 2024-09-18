using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class SavingsAccount: Account
    {
        const double TRANSACTION_FEE_DEPOSIT = 2.25;
        const double TRANSACTION_FEE_WITHDRAW = 1.35;

        public double Interest { get; set; }

        public SavingsAccount(int number, string name, double balance, double interest): base(number, name, balance)
        {
            Interest = interest;
        }

        public override void Deposit(double amount)
        {
            Balance = Balance + amount - TRANSACTION_FEE_DEPOSIT;
        }

        public override void Withdraw(double amount)
        {
            Balance = Balance - amount - TRANSACTION_FEE_WITHDRAW;
        }

    }
}
