using System;
using Challenge.Domain.Enums;
using Challenge.Shared.Entities;

namespace Challenge.Domain.Entities
{
    public class Transaction : Entity
    {
        public Transaction(ETransactionType transctionType, DateTime transactionDate, long checkNum, double transactionValue, string description)
        {
            
            TransctionType = transctionType;
            TransactionDate = transactionDate;
            CheckNum = checkNum;
            TransactionValue = transactionValue;
            Description = description;
        }

        public ETransactionType TransctionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public long CheckNum { get; set; }
        public double TransactionValue { get; set; }
        public string Description { get; set; }
    }
}
