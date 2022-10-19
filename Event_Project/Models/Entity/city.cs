using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Text.Json.Serialization;

namespace Event_Project.Models.Entity;

public class City
{
    public int CityId { get; set; }
    public string CityName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Event> Events { get; set; }
}