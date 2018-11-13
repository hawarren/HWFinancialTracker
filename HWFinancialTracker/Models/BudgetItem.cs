﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    public class BudgetItem
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public int CategoryId { get; set; }
        public int BudgetId { get; set; }

        public virtual Budget Budgets { get; set; }
        public virtual Category Categories { get; set; }
    }
}