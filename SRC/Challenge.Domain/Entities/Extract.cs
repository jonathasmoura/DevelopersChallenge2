using System;
using System.Collections.Generic;

namespace Challenge.Domain.Entities
{
    public class Extract
    {
        private readonly IList<Transaction> _transactions;
        public Extract(){}
        public Extract(DateTime startDate, DateTime endDate, string status, int bankAccounId, int extractSignOnId)
        {
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            BankAccounId = bankAccounId;
            ExtractSignOnId = extractSignOnId;
            _transactions = new List<Transaction>();
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int BankAccounId { get; set; }
        public int ExtractSignOnId { get; set; }
        public ExtractHeader ExtractHeader { get; set; }
        public BankAccount BanckAccount { get; set; }
        ICollection<Transaction> Transactions { get; set;}
    }
}
