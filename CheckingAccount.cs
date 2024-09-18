using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class CheckingAccount : Account
    {
        const double TRANSACTION_FEE_DEPOSIT = 5.45;
        const double TRANSACTION_FEE_WITHDRAW = 3.25;

        public double Limit {  get; set; }

        public CheckingAccount(int number, string name, double balance, double limit): base(number, name, balance)
        {
            Limit = limit;
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
