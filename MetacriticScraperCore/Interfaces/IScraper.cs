using MetacriticScraperCore.Scraper;

namespace MetacriticScraperCore.Interfaces
{
    public interface IScraper
    {
        bool AddItem(string id, string url);
        IParser UrlParser { get; set; }
    }
}
