using System.Text.Json.Serialization;

namespace Event_Project.Models.Entity
{
    public class company
    {
        public int EntegratorId { get; set; }
        public string EntegratorName { get; set; }
        public string DomainName { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<company> CompanyEvents { get; set; }

    }
}
