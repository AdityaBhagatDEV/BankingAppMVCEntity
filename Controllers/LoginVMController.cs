using BankingAppMVCEntity.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BankingAppMVCEntity.Controllers
{
    public class LoginVMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return Ok(model);
        }
    }
}
