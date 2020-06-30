using System;

namespace EncapsulationInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var mAcct = new BankAccount(400);

            mAcct.Deposit(30000);

            var bal = mAcct.GetBalance();

            mAcct.Withdraw(300);
        }
    }
}
