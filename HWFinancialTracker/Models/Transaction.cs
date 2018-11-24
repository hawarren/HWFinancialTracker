using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    public class Transaction
    {
        //primary key of the transaction ID, to keep track of each transaction
        public int Id { get; set; }
        //i.e. what is this transaction? ("sneaker purchase")
        public string Description { get; set; }
        //date the transaction was made (with the time too)
        public int Date { get; set; }
        //how much did it cost or how much was earned/refunded?
        public int Amount { get; set; }
        //type of transaction (purchase/expense?)
        public string Type { get; set; }

        //how much needs to be reconciled (ie accounted for in final balance?)
        public int Reconciled { get; set; }
        //What the balance is after reconciliation
        public int ReconciledAmount { get; set; }

        //foreign key connecting this transaction to an account
        public int AccountId { get; set; }
        //foreign key connecting this transaction to a specific category
        public int CategoryId { get; set; }
        //foreign key connecting to the person that entered this transaction
        public string EnteredById { get; set; }

        //navigation property to the Financial Account this transation belongs to
        public virtual FinancialAccounts FinancialAccounts { get; set; }
        //navigation property to the category this account belongs to
        public virtual Category Category { get; set; }
        //navigation property to the User who entered this transaction
        public virtual ApplicationUser EnteredBy { get; set; }

    }
}