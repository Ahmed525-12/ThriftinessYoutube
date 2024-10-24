using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftinessDomain.Entities.AppEntity
{
    public class Expense : BaseEntity
    {
        public string Title { get; set; }
        public double Money { get; set; }
        public bool Priorty { get; set; } = false;
        public DateTime ExpenseDate { get; set; } = DateTime.Now;

        public MonthExpense MonthExpense { get; set; }

        [ForeignKey(nameof(MonthExpense))]
        public int MonthExpenseId { get; set; }

        public string UserId { get; set; }
    }
}