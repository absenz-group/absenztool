using Microsoft.AspNetCore.Mvc;

namespace AbsenzAPPDBHosting.Controllers
{
    public class LehrerController : Controller
    {
        public IActionResult AbwesenheitSpeichern()
        {
            return View("~/Views/Shared/Lehrer/LehrerAbwesenheitSpeichern.cshtml");
        }
        
        public IActionResult AlleSchueler()
        {
            return View("~/Views/Shared/Lehrer/LehrerAlleSchueler.cshtml");
        }
        
        public IActionResult Index()
        {
            return View("~/Views/Shared/Lehrer/LehrerSchuelerstatusAktualisieren.cshtml");
        }
    }
}
