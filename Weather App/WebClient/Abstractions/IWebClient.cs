using System.Threading.Tasks;

namespace WebClient.Abstractions
{
    public interface IWebClient
    {
        Task<string> GetDataAsync();
        void ChangeUrl(string url);
    }
}
