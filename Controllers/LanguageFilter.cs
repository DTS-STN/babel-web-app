using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;
 
  
namespace babel_web_app.Controllers  
{  
    public class LanguageFilter : ActionFilterAttribute 
    {
        private static readonly string DEFAULT_LANGUAGE = "en";
        private static readonly List<string> VALID_LANGUAGES = new List<string>() {"en", "fr"};
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = context.HttpContext.Session;
            string sessionLanguage = "";

            if (session.TryGetValue("lang", out byte[] res)) {
                sessionLanguage = Encoding.UTF8.GetString(res);
            }

            // If parameter is present, use it to set session (if not already the same)
            if (context.ActionArguments.TryGetValue("lang", out object value))
            {
                var parmLanguage = value.ToString();

                // Ensure the parameter is a valid language
                if (!VALID_LANGUAGES.Contains(parmLanguage)) {
                    parmLanguage = "en";
                }

                // Get the session language
                if (sessionLanguage != parmLanguage) {
                    var langBytes = Encoding.UTF8.GetBytes(parmLanguage);
                    session.Set("lang", langBytes);
                }
            } else {
                // If no parameter present, and no session present, then default to "en"
                if (String.IsNullOrEmpty(sessionLanguage)) {
                    var langBytes = Encoding.UTF8.GetBytes(DEFAULT_LANGUAGE);
                    session.Set("lang", langBytes);
                }
            }
        }
    }

}