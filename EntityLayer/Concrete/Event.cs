using System;
using System.Collections.Generic;

namespace Event_Project.EntityLayer.Concrete
{
    public partial class Event
    {
        public Event()
        {
            EntegratorEvents = new HashSet<CompanyEvent>();
            EventAttendances = new HashSet<EventAttendee>();
        }

        public int EventId { get; set; }
        public string? EventName { get; set; } = null!;
        public DateTime EventDate { get; set; }
        public string? Description { get; set; }
        public int Quato { get; set; }
        public string? Address { get; set; } = null!;
        public int? UserId { get; set; }
        public int? CityId { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Fare { get; set; }
        public bool IsTicketed { get; set; }
        public bool? IsApproved { get; set; }

        public virtual Category? Category { get; set; }
        public virtual City? City { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<CompanyEvent>? EntegratorEvents { get; set; }
        public virtual ICollection<EventAttendee>? EventAttendances { get; set; }
    }
}
