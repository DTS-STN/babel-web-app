using System;
using System.Collections.Generic;
using System.Linq;

using babel_web_app.Lib.Results;

namespace babel_web_app.Models
{
    public class ResultsViewModel : BaseViewModel
    {
        public ResultsSummary Results { get; set; }

        public ResultsViewModel(ResultsSummary results, string language) : base(language) {
            Results = results;
        }

    }
}