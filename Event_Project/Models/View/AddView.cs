using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Xunit;

namespace Event_Project.Models.View
{
    public class AddView
    {
        [Required(ErrorMessage = "Event name should not be left blank...")]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [Display(Name = "Event Time")]
        [DataType(DataType.Date)]
        [ValidDateTime(ErrorMessage = "The event must not be out of date...")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Category field should not be left blank..")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "City field should not be left blank...")]
        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Address field should not be left blank...")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Event details should not be left blank...")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Range(2, 300, ErrorMessage = "The quota must be chosen at least 2 and at most 300...")]
        [Display(Name = "Quota")]
        public int Quota { get; set; }
        
        public decimal? Fare { get; set; }

        public bool IsTicketed { get; set; }
    }
}
