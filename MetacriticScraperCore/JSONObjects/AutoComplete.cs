using System.Collections.Generic;

namespace MetacriticScraperCore.JSONObjects
{
    public class RootObject
    {
        public AutoComplete AutoComplete { get; set; }
    }

    public class AutoComplete
    {
        public Totals Totals { get; set; }
        public List<Result> Results { get; set; }
    }
}
