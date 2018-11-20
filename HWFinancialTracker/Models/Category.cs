using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    //Per SRS, Transactions and Expenses are categorized (i.e. what did you spend $5000 on???? a new hat?!)
    public class Category
    {
        //this ensures that every category object comes with "space" for the households that are on it.  It will "roll up"
        public Category()
        {
            //"roll up" ticket histories into a collection (doesn't have to be HashSet) and include it the Category object when it gets instantiated.
            this.Households = new HashSet<Household>();
        }
        //primary key for Categories
        public int Id { get; set; }
        //name of the Category (e.g.
        public string Name { get; set; }

        //foreign key for Households
        public int HouseholdId { get; set; }

        //navigation property to connect the Household to Categories
        public virtual ICollection<Household> Households { get; set; }


    }
}