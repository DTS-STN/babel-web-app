using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using babel_web_app.Models;
using babel_web_app.Lib;
using babel_web_app.Lib.Results;

using esdc_simulation_classes.MaternityBenefits;

namespace babel_web_app.Controllers
{
    public class MaternityBenefitsController : Controller
    {
        private readonly IHandleSimulationRequests _handler;
        private readonly string _powerBiLink;

        public MaternityBenefitsController(
            IHandleSimulationRequests handler,
            IOptions<PowerBiOptions> powerBiOptions
        )
        {
            _handler = handler;
            _powerBiLink = powerBiOptions.Value.Link;
        }

        [LanguageFilter]
        public IActionResult Index(string admin, string lang)
        {
            var language = GetLanguage(lang);
            var results = _handler.GetAllSimulations();
            var viewModel = new AllSimulationsViewModel(results, language);
            ViewBag.IsAdmin = (admin == "admin");
            return View(viewModel);
        }


        public IActionResult Delete(Guid id) {
            try {
                _handler.DeleteSimulation(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex) {
                var message = String.IsNullOrEmpty(ex.Message) ? "The requested simulation no longer exists." : ex.Message;
                return RedirectToAction("Error", new { message });
            }
        }

        [LanguageFilter]
        public IActionResult Form(string lang)
        {
            var language = GetLanguage(lang);

            var baseCase = new SimulationCaseViewModel() {
                Percentage = 55,
                NumWeeks = 15,
                MaxWeeklyAmount = 595
            };
            var variantCase = new SimulationCaseViewModel() {
                Percentage = 55,
                NumWeeks = 15,
                MaxWeeklyAmount = 595
            };
            var name = $"Simulation_{DateTime.Now.ToString("yyyyMMddHHmm")}";
            
            var viewModel = new SimulationFormViewModel(baseCase, variantCase, name, language);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult RunSim(SimulationFormViewModel formViewModel)
        {
            if (ModelState.IsValid) {
                CreateSimulationRequest simulationRequest = Convert(formViewModel);
                
                try {
                    var result = _handler.CreateNewSimulation(simulationRequest);
                    var id = result.Id;
                    return RedirectToAction("Results", new { id });
                }
                catch (Exception ex) {
                    return RedirectToAction("Error", new { message = ex.Message });
                }
            }
            return View("Form");
        }

        [LanguageFilter]
        public IActionResult Results(Guid id, string lang) {
            try {
                string language = GetLanguage(lang);
                var simResults = _handler.GetSimulationResults(id);
                var resultsSummary = new ResultsSummary(simResults.Simulation, simResults.Result.PersonResults);
                var viewModel = new ResultsViewModel(resultsSummary, language);
                return View(viewModel);
            }
            catch (Exception ex) {
                var message = String.IsNullOrEmpty(ex.Message) ? "The requested simulation no longer exists." : ex.Message;
                return RedirectToAction("Error", new { message });
            }
        }

        [LanguageFilter]
        public IActionResult Error(string message, string lang)
        {
            var language = GetLanguage(lang);
            return View(new ErrorViewModel(language) {
                ErrorMessage = message
            });
        }

        private string GetLanguage(string parmLang) {
            try {
                // May not even need the parm in here. Handled by the filter...
                string result = parmLang;
                if (HttpContext.Session.TryGetValue("lang", out byte[] res)) {
                    result = Encoding.UTF8.GetString(res);
                }
                return result;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return "en";
            }
        }

        private CreateSimulationRequest Convert(SimulationFormViewModel vm) {
            return new CreateSimulationRequest() {
                SimulationName = vm.SimulationName,
                BaseCaseRequest = Convert(vm.BaseCase),
                VariantCaseRequest = Convert(vm.VariantCase)
            };
        }

        private CaseRequest Convert(SimulationCaseViewModel vm) {
            return new CaseRequest() {
                NumWeeks = vm.NumWeeks,
                MaxWeeklyAmount = vm.MaxWeeklyAmount,
                Percentage = vm.Percentage
            };
        }

        private string BuildPowerBiLink(SimulationResponse sim) {
            return $"{_powerBiLink}&filter=MaternityBenefitsSimulation/SimulationName eq '{sim.SimulationName}'";
        }
    }
}
