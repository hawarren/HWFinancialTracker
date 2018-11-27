using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    public class FinancialAccounts
    {
        //wraps up all the transactions on this account into a nice collection (for iterating over, adding them up, and other manipulations)
        public FinancialAccounts()
        {
            this.Transactions = new HashSet<Transaction>();
        }
        //primary key of the financial account
        public int Id { get; set; }

        //Name of the account (e.g. bank Account?) or billing account (PSEG?)
        public string Name { get; set; }

        //how much is remaining in the account before reconciliation?
        public int Balance { get; set; }

        //How much is remaining after balance is reconciled (e.g. when balancing checkbook, accounting for pending transactions)
        public int ReconciledBalance { get; set; }


        //foreign key for Household
        public int HouseholdId { get; set; }

        //foreign key for Transactions
        public int TransactionId { get; set; }

        //navigation property for Transactions (each account can/will have many transactions
        public virtual ICollection<Transaction> Transactions { get; set; }

        //navigation property for the Household (each Transaction belongs to a single Household)
        public virtual Household Household { get; set; }

    }
}