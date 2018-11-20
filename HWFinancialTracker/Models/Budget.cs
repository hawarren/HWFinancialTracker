using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    public class Budget
    {
        //primary key of the my budget
        public  int Id { get; set; }
        //Identifiable name of that budget e.g. "Travel budget"
        public int Name { get; set; }
        //Primary key of the household to which this budget belongs. It goes hand in hand with the navigation property
        public int HouseholdId { get; set; }

        //navigation property of my household, it creates the relationship using entity framework and it allows e.g. me to click "back to household" and it will show the household (and all budgets the household belongs to)
        public virtual Household Household { get; set; }
    }
}