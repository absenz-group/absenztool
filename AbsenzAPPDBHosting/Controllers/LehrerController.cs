using Microsoft.AspNetCore.Mvc;

namespace AbsenzAPPDBHosting.Controllers
{
    public class LehrerController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/LehrerAnsichten/LehrerFilterPage.cshtml");
        }
    }
}
