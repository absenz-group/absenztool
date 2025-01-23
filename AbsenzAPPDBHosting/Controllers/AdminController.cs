using Microsoft.AspNetCore.Mvc;

namespace AbsenzAPPDBHosting.Controllers;

public class AdminController : Controller
{
    public IActionResult AlleSchueler()
    {
        return View("~/Views/Shared/Admin/AdminAlleSchueler.cshtml");
    }
    
    public IActionResult DetailsSchueler()
    {
        return View("~/Views/Shared/Admin/AdminDetailsSchueler.cshtml");
    }
    
    public IActionResult PdfHochladen()
    {
        return View("~/Views/Shared/Admin/AdminPdfHochladen.cshtml");
    }
}