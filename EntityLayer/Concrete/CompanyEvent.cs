using System;
using System.Collections.Generic;

namespace Event_Project.EntityLayer.Concrete
{
    public partial class CompanyEvent
    {
        public int CompaniesId { get; set; }
        public int CompanyId { get; set; }
        public int EventId { get; set; }

        public virtual Company? Company { get; set; } = null!;
        public virtual Event? Event { get; set; } = null!;
    }
}
