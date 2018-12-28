using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    class SavingsAccount : BankAccount
    {
        protected const decimal WithdrawCost = 0.25M;
        public decimal InterestRate { get; private set; }

        public SavingsAccount(string bankAccountNumber, decimal interestRate) : base(bankAccountNumber)
        {            
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }

        public override string Print()
        {
            return $"Savingsaccount balance = {Balance}";
        }
    }
}
