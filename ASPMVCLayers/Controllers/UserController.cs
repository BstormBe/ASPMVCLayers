using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVCLayers.Controllers
{
    public class UserController : Controller
    {

        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View(_userService.GetAll());
        }
    }
}
