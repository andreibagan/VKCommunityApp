using System.Threading.Tasks;
using VKCommunity.DAL.Models;
using VKCommunity.Service.Models;
using VKCommunity.Service.Services.EntityServices.Base;

namespace VKCommunity.Service.Services.EntityServices
{
    public interface IUserService
    {
        Task<bool> UserExistsAsync(int userId);
        Task<bool> AddUserAsync(UserModel user);
        Task<UserModel> GetUserAsync(int id);
    }

    public class UserService : EntityServiceBase<UserModel>, IUserService
    {

        public UserService() : base("http://localhost:61770/api/Users")
        {
        }

        public async Task<bool> AddUserAsync(UserModel user)
        {
            return await PostAsync(user);
        }

        public async Task<UserModel> GetUserAsync(int id)
        {
            return await GetAsync(id);
        }

        public async Task<bool> UserExistsAsync(int userId)
        {
            return await GetAsync(userId) != null ? true : false;
        }
    }
}
