using System;
using System.Collections.Generic;

namespace Event_Project.EntityLayer.Concrete
{
    public partial class City
    {
        public City()
        {
            Events = new HashSet<Event>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;

        public virtual ICollection<Event>? Events { get; set; }
    }
}
