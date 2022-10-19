using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Text.Json.Serialization;

namespace Event_Project.Models.Entity
{
    public class CompanyEvent
    {
        public int CompanyId { get; set; }
        
        public int EventId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public company Company { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Event Event { get; set; }
    }
}
