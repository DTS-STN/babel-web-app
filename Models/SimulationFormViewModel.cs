using System.ComponentModel.DataAnnotations;

namespace babel_web_app.Models
{
    public class SimulationFormViewModel : BaseViewModel
    {
        public SimulationCaseViewModel BaseCase { get; set; }
        public SimulationCaseViewModel VariantCase { get; set; }
        [Required]
        public string SimulationName { get; set; }

        public SimulationFormViewModel(SimulationCaseViewModel baseCase, SimulationCaseViewModel variantCase, string name, string language) : base(language) {
            BaseCase = baseCase;
            VariantCase = variantCase;
            SimulationName = name;
        }

        public SimulationFormViewModel(): base(""){
        }

    }
}