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
            this.Users = new HashSet<ApplicationUser>();
            this.Budgets = new HashSet<Budget>();
            this.Categories = new HashSet<Category>();
            this.FinancialAccounts = new HashSet<FinancialAccounts>();
        }


        public int Id { get; set; }
        public string Name { get; set; }
        //this is the Head of Household ID, not a primary key

        [Display(Name = "HeadOfHousehold")]
        public string HHID { get; set; }
        public int CategoryId { get; set; }
        public int BudgetId { get; set; }
        public string UserId { get; set; }
        public int AccountId { get; set; }

        //Each household can have several categories (which they added to their household and made up
        public virtual ICollection<Category> Categories { get; set; }
        //Each househould can have several budgts (travel budget, food budget, etc.)
        public virtual ICollection<Budget> Budgets { get; set; }
        //Each household can have several users be a part of it
        public virtual ICollection<ApplicationUser> Users { get; set; }
        //Each household can have several bank accounts that they use to feed their budget (and credit cards too)
        public virtual ICollection<FinancialAccounts> FinancialAccounts { get; set; }








    }
}