using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftinessDomain.Entities.AppEntity
{
    public class MonthExpense : BaseEntity
    {
        public double TotalSpent { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public string UserId { get; set; }
        public int MonthNum { get; set; }
    }
}