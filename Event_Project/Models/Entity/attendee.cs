using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Text.Json.Serialization;

namespace Event_Project.Models.Entity
{
    public class attendee
    {
        public int AttendanceId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Event Event { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Users User { get; set; }
    }
}

