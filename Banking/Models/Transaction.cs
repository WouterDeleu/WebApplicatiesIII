using System;
using System.Collections.Generic;
using System.Text;
using Banking.Models;

namespace Banking.Models
{
    class Transaction
    {
        #region Fields
        private decimal _amount;
        #endregion

        #region Properties
        public decimal Amount { get; set; }
        public DateTime DateOfTrans { get; set; }
        
        public TransactionType TransactionType { get; set; } 
        #endregion

        
        #region Constructor
        public Transaction(decimal amount, TransactionType type)
        {
            TransactionType = type;
            Amount = amount;
            DateOfTrans = DateTime.Today;
        }
        #endregion

        public bool IsDeposit { 
            get { return TransactionType == TransactionType.type.Deposit};
        }
        public bool IsWithdraw { 
           get { return TransactionType == TransactionType.Withdraw};
        }

    }
}
