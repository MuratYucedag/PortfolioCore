using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class SkillController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult SkillList()
        {
            return View();
        }
    }
}
