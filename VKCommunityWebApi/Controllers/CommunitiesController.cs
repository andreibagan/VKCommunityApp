using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;
using VKCommunityWebApi.Controllers.Base;

namespace VKCommunityWebApi.Controllers
{
    public class CommunitiesController : WebApiBase<Community, CommunitiesController>
    {
        public CommunitiesController(IRepository<Community> communityRepository, ILogger<CommunitiesController> logger) : base(communityRepository, logger)
        {

        }
    }
}
