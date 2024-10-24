using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftinessDomain.Entities.AppEntity
{
    public class Goal : BaseEntity
    {
        public string Title { get; set; }
        public double MoneyAmount { get; set; }

        public string UserId { get; set; }
    }
}