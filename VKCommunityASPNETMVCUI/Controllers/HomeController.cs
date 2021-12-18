using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using VKCommunity.Service.Models;
using VKCommunity.Service.Services.EntityServices;
using VKCommunity.Service.Services.VKServices;
using VKCommunityASPNETMVCUI.Models;

namespace VKCommunityASPNETMVCUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IVKService _vKService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IUserService userService, IVKService vKService)
        {
            _logger = logger;
            _userService = userService;
            _vKService = vKService;
        }

        public async Task<IActionResult> Index(int id)
        {
            if (id != 0)
            {
                return View(await _userService.GetUserAsync(id));
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserModel user)
        {
            return Ok(await _userService.AddUserAsync(user));
        }

        public async Task<IActionResult> Privacy()
        {
            return View(await _vKService.GetHtmlSource("https://vk.com/animevostorg"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
