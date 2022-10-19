namespace Event_Project.EntityLayer.Concrete
{
    public partial class EventAttendee
    {
        public int AttendeeId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }

        public virtual Event? Event { get; set; } = null!;
        public virtual User? User { get; set; } = null!;
    }
}
