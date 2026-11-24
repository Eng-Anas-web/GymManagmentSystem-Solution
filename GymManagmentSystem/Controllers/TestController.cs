using Microsoft.AspNetCore.Mvc;

namespace GymManagmentSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
