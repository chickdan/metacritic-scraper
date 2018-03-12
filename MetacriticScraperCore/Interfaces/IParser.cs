using MetacriticScraperCore.RequestData;

namespace MetacriticScraperCore.Interfaces
{
    public interface IParser
    {
        bool ParseRequestUrl(string id, string url, out string keyword, out string title,
            out string yearOrSeason, out string thirdLevelReq);

        bool ParseRequestUrl(string id, string url, out string keyword, out string title,
            out string yearOrSeason, out string thirdLevelReq, ref string parameters);

        RequestItem CreateRequestItem(string id, string keyword, string title, string yearOrSeason,
            string thirdLevelReq);

        RequestItem CreateRequestItem(string id, string keyword, string title, string yearOrSeason,
            string thirdLevelReq, string parameters);
    }
}
