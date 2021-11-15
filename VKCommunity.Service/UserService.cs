using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;

namespace VKCommunity.Service
{
    public interface IUserService
    {
        bool UserExists(int userId);

    }

    class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public bool UserExists(int userId)
        {
            return _userRepository.Get(userId) != null;
        }
    }
}
