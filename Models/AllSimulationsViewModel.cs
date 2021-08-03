using esdc_simulation_classes.MaternityBenefits;

namespace babel_web_app.Models
{
    public class AllSimulationsViewModel : BaseViewModel
    {
        public AllSimulationsResponse Response { get; set; }
        public AllSimulationsViewModel(AllSimulationsResponse response, string lang) : base(lang) {
            Response = response;
        }
    }
}