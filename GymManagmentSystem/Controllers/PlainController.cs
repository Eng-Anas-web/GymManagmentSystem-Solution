using GymManagmentSystem.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Controllers
{
    public class PlainController : Controller
    {
            private GymDbContext dbContext = new GymDbContext();
        public async Task<IActionResult> Index()
        {
            var Plans = await dbContext.Plains.ToListAsync();
            return View(Plans);
        }
    }
}
