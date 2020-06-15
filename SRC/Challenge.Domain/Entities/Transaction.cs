using System;
using Challenge.Domain.Enums;

namespace Challenge.Domain.Entities
{
    public class Transaction
    {
        public Transaction(int id, ETransactionType transctionType, DateTime transactionDate, long checkNum, double transactionValue, string description)
        {
            Id = id;
            TransctionType = transctionType;
            TransactionDate = transactionDate;
            CheckNum = checkNum;
            TransactionValue = transactionValue;
            Description = description;
        }

        public int Id { get; set; }
        public ETransactionType TransctionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public long CheckNum { get; set; }
        public double TransactionValue { get; set; }
        public string Description { get; set; }
    }
}
