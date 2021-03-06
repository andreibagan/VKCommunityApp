using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;
using VKCommunityWebApi.Controllers.Base;

namespace VKCommunityWebApi.Controllers
{
    public class UsersController : WebApiBase<User, UsersController>
    {
        public UsersController(IRepository<User> userRepository, ILogger<UsersController> logger) : base(userRepository, logger)
        {

        }
    }
}
