using System.Threading.Tasks;

namespace VKCommunity.Service.Services.VKServices
{
    public interface IVKService
    {
        Task<string> GetHtmlSource(string url);
    }
}
