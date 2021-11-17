using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;

namespace VKCommunityWebApi.Controllers.Base
{
    public class UserCommunitiesController : WebApiBase<UserCommunity, UserCommunitiesController>
    {
        public UserCommunitiesController(IRepository<UserCommunity> repository, ILogger<UserCommunitiesController> logger) : base(repository, logger)
        {

        }
    }
}
