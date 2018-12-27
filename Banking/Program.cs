using System;
using Banking.Models;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("123-123123-12");
            myAccount.Balance = 200M;
        }
    }
}
