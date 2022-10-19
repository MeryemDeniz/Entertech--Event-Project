using System;
using System.Collections.Generic;

namespace Event_Project.EntityLayer.Concrete
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime FeedbackDate { get; set; }

        public virtual User? User { get; set; } = null!;
    }
}
