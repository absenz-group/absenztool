using Microsoft.AspNetCore.Mvc;

namespace AbsenzAPPDBHosting.Controllers
{
    public class SchulerController : Controller
    {
        public IActionResult Index()
        {
            return View("GesamtUbersicht");
        }
    }
}
