using BLL.Forms;
using BLL.Services;
using BLL.ViewModel;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserForms userForms)
        {
            if (ModelState.IsValid)
            {
                if (_userService.Add(userForms))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(userForms);

            
        }
    }
}
