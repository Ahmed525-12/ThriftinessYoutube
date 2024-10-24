using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftinessDomain.Entities.Identity
{
    public class UserAccount : IdentityUser
    {
        public double MonthlySalary { get; set; }
        public int MonthlyDateDay { get; set; }
    }
}