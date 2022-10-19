using System;
using System.Collections.Generic;

namespace Event_Project.EntityLayer.Concrete
{
    public partial class User
    {
        public User()
        {
            EventAttendances = new HashSet<EventAttendee>();
            Events = new HashSet<Event>();
            Feedbacks = new HashSet<Feedback>();
        }

        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte Role { get; set; }

        public virtual ICollection<EventAttendee>? EventAttendances { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Feedback>? Feedbacks { get; set; }
    }
}
