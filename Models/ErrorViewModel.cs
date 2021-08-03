using System;

namespace babel_web_app.Models
{
    public class ErrorViewModel : BaseViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string ErrorMessage { get; set; }

        public ErrorViewModel(string lang) : base(lang){}
    }
}
