﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    class BankAccount
    {
        #region Fields
        private string _accountNumber;
        private List<Transaction> _transactions;
        #endregion

        #region Properties
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int NumberOfTransactions
        {
            get { return _transactions.Count; }
        }
        #endregion

        #region Constructor
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
            _transactions = new List<Transaction>();
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
            Balance += amount;
        }

        public bool Equals(object obj)
        {

        }

        public int getHashCode()
        {

        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime till)
        {
            IList<Transaction> translist = new List<Transaction>();
            foreach(Transaction t in _transactions)
            {
                if(t.DateOfTrans >= from && t.DateOfTrans <= till)
                {
                    translist.Add(t);
                }
            }
            return translist;
        }

        public string ToString()
        {

        }

        public virtual void Withdraw(decimal amount)
        {
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
            Balance = Balance - amount;
            
        }
        #endregion
    }
}
