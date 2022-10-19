using Event_Project.Models.Entity;
using System.Text.Json.Serialization;

namespace Event_Project.Models.Entity
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LastAttendDate { get; set; }
        public string? Description { get; set; }
        public int Quato { get; set; }
        public string Address { get; set; }
        public int? UserId { get; set; }
        public int? CityId { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Fare { get; set; }
        public bool IsTicketed { get; set; }
        public bool? IsApproved { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public category? Category { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CityDto? City { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Users? User { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CompanyEvent> EntegratorEvents { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<attendee> EventAttendances { get; set; }
    }
}