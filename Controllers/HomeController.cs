using System;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using babel_web_app.Models;

namespace babel_web_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [LanguageFilter]
        public IActionResult Index(string lang)
        {
            var language = GetLanguage(lang);
            var viewModel = new IndexViewModel(language);
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string lang)
        {
            var language = GetLanguage(lang);
            return View(new ErrorViewModel(language) { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string GetLanguage(string parmLang) {
            string result = parmLang;
            if (HttpContext.Session.TryGetValue("lang", out byte[] res)) {
                result = Encoding.UTF8.GetString(res);
            }
            return result;
        }
    }
}
