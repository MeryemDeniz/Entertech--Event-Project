using Event_Project.Models.Entity;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace Event_Project.Models.View
{
    public class DetailsView
    {
        public Event Event { get; set; }
        public bool IsAttended { get; set; }
        public List<company> Companies { get; set; }
    }
}
