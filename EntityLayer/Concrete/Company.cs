using System;
using System.Collections.Generic;

namespace Event_Project.EntityLayer.Concrete
{
    public partial class Company
    {
        public Company()
        {
            EntegratorEvents = new HashSet<CompanyEvent>();
        }

        public int CompanyId { get; set; }
        public string? CompanyName { get; set; } = null!;
        public string? EmailAdress { get; set; } = null!;
        public string? Password { get; set; } = null!;
        

        public virtual ICollection<CompanyEvent>? EntegratorEvents { get; set; }
    }
}
