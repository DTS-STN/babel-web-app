﻿using System;
using Microsoft.AspNetCore.Mvc;

using babel_web_app.Models;
using babel_web_app.Lib;
using babel_web_app.Lib.Results;

using esdc_simulation_classes.MaternityBenefits;

namespace babel_web_app.Controllers
{
    public class MaternityBenefitsController : Controller
    {
        private readonly IHandleSimulationRequests _handler;

        public MaternityBenefitsController(IHandleSimulationRequests handler)
        {
            _handler = handler;
        }

        public IActionResult Index()
        {
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
            
            var viewModel = new SimulationFormViewModel(baseCase, variantCase, name);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(SimulationFormViewModel formViewModel)
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
            return View("Index", formViewModel);
        }

        public IActionResult Results(Guid id) {
            try {
                var simResults = _handler.GetSimulationResults(id);
                var resultsSummary = new ResultsSummary(simResults.Simulation, simResults.Result.PersonResults);
                var viewModel = new ResultsViewModel(resultsSummary);
                return View(viewModel);
            }
            catch (Exception ex) {
                var message = String.IsNullOrEmpty(ex.Message) ? "The requested simulation no longer exists." : ex.Message;
                return RedirectToAction("Error", new { message });
            }
        }

        public IActionResult Error(string message)
        {
            return View(new ErrorViewModel() {
                ErrorMessage = message
            });
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
    }
}
