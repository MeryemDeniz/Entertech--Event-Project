using System;
using System.Collections.Generic;

namespace Event_Project.EntityLayer.Concrete
{
    public partial class Category
    {
        public Category()
        {
            Events = new HashSet<Event>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Event>? Events { get; set; }
    }
}
