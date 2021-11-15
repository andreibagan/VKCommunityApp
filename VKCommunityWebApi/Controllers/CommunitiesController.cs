using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;

namespace VKCommunityWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommunitiesController : WebApiBase<Community, CommunitiesController>
    {
        public CommunitiesController(IRepository<Community> communityRepository, ILogger<CommunitiesController> logger) : base(communityRepository, logger)
        {

        }
    }
}
