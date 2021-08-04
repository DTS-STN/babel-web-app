using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace babel_web_app.Models
{
    public class SimulationCaseViewModel
    {
        [DisplayName("Percentage")] 
        [Required]
        [Range(1, 100)]
        public double Percentage { get; set; }

        [DisplayName("Maximum Weekly Amount")] 
        [Required]
        [Range(100, 2000)]
        public decimal MaxWeeklyAmount { get; set; }

        [DisplayName("Number of Weeks")] 
        [Required]
        [Range(1, 52)]
        public int NumWeeks { get; set; }
    }
}