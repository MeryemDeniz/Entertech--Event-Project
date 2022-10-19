using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Text.Json.Serialization;

namespace Event_Project.Models.Entity;

public class category
{

    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Event> Events { get; set; }
}

