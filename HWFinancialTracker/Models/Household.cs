using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    public class Household
    {

        public Household()

        {
            // Collection<ObjectType(instantiate this object)
            this.Users = new HashSet<ApplicationUser>();
            this.Budgets = new HashSet<Budget>();
            this.Categories = new HashSet<Category>();
            this.FinancialAccounts = new HashSet<FinancialAccounts>();
        }

        // primary key of the Household. Each user can only belong to one household
        public int Id { get; set; }

        // Name for the household, e.g. "Warren family"
        public string Name { get; set; }


        // this is the Head of Household ID, not a primary key
        [Display(Name = "HeadOfHousehold")]
        public string HHID { get; set; }

        // these are foreign keys to connect to : Household Id (the head of household), Category, Budget (every household has budgets), UseriD, and Financial Accounts
        public int? CategoryId { get; set; }

        public int? BudgetId { get; set; }

        //string can be null, no need to make nullable like I do with int
        public string UserId { get; set; }

        public int? AccountId { get; set; }

        // Each household can have several categories (which they added to their household and made up)
        public virtual ICollection<Category> Categories { get; set; }

        // Each household can have several budgts (travel budget, food budget, etc.)
        public virtual ICollection<Budget> Budgets { get; set; }

        // Each household can have several users be a part of it
        public virtual ICollection<ApplicationUser> Users { get; set; }

        // Each household can have several bank accounts that they use to feed their budget (and credit cards too)
        public virtual ICollection<FinancialAccounts> FinancialAccounts { get; set; }








    }
}