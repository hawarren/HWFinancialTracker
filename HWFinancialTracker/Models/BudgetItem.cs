using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    public class BudgetItem
    {
        //primary key of this budget item (e.g. "gas", which would go in the transportation budget)
        public int Id { get; set; }

        //the amount that the budget costs (e.g. gas cost $150 last month)
        public int Amount { get; set; }

        // primary key of the category this budget belongs to. can use to list the Category name
        public int CategoryId { get; set; }

        //primary key of the category this budget belongs to. Can use to list the
        public int BudgetId { get; set; }

        //these navigation properties create the relationship (1 to many, 1 Budget has many Budget Items)
        public virtual Budget Budgets { get; set; }

        //these navigation properties create the relationship (1 to many, 1 Category has many Budget Items)
        public virtual Category Categories { get; set; }
    }
}