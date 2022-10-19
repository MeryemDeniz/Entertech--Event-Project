using System.Text.Json.Serialization;

namespace Event_Project.Models.Entity
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime FeedbackDate { get; set; }
        public bool IsSeen { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Users User { get; set; }
    }
}

