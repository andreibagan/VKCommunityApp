using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VKCommunity.DAL.Models;
using VKCommunity.RepositoryStorage.Repository;
using VKCommunityWebApi.Controllers.Base;

namespace VKCommunityWebApi.Controllers
{
    public class PostMessagesController : WebApiBase<PostMessage, PostMessagesController>
    {
        public PostMessagesController(IRepository<PostMessage> repository, ILogger<PostMessagesController> logger) : base(repository, logger)
        {

        }
    }
}
