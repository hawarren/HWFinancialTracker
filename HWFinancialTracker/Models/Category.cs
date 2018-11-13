using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWFinancialTracker.Models
{
    public class Category
    {
        public Category()
        {
            this.Households = new HashSet<Household>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation property
        public int HouseholdId { get; set; }

        public virtual ICollection<Household> Households { get; set; }


    }
}