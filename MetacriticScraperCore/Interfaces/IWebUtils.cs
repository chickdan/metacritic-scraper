using System.Threading.Tasks;

namespace MetacriticScraperCore.Interfaces
{
    public interface IWebUtils
    {
        Task<string> HttpPost(string url, string strPostData, string referer, int timeout);

        Task<string> HttpGet(string url, string referer, int timeout);
    }
}
