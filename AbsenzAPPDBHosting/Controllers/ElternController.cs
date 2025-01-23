using Microsoft.AspNetCore.Mvc;

namespace AbsenzAPPDBHosting.Controllers;

public class ElternController : Controller
{
    public IActionResult Elternansicht()
    {
        return View("~/Views/Shared/Eltern/Elternansicht.cshtml");
    }
}