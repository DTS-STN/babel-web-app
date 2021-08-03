using babel_web_app.Lib.Language;

namespace babel_web_app.Models
{
    public class BaseViewModel
    {
        public string Language { get; set; }
        public Translator TextSet { get; set; }

        public BaseViewModel(string language) {
            TextSet = new Translator(language);
            Language = language;
        }
    }
}