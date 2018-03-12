using System.Collections.Generic;
using MetacriticScraperCore.Scraper;

namespace MetacriticScraperCore.Interfaces
{
    public interface IScrapable<T>
    {
        List<string> Urls { get; set; }
        List<UrlResponsePair> Scrape();
        T Parse(UrlResponsePair urlResponsePair);
        string RequestId { get; }
    }
}
