// using AbsenzAPPDBHosting.Models;
// using Microsoft.AspNetCore.Mvc;
//
// namespace AbsenzAPPDBHosting.Controllers
// {
//     public class LoginController : Controller
//     {
//         [HttpGet]
//         public IActionResult Index()
//         {
//             return View();
//         }
//         
//         [HttpPost]
//         public IActionResult Index(LoginViewModel model)
//         {
//             if (ModelState.IsValid)
//             {
//                 // Validate the user credentials
//                 if (Users.TryGetValue(model.Username, out var password) && password == model.Password)
//                 {
//                     // Set the user session (you can use claims or cookies for real applications)
//                     HttpContext.Session.SetString("Username", model.Username);
//
//                     // Redirect to a secure area or home page
//                     return RedirectToAction("Index", "Home");
//                 }
//                 else
//                 {
//                     ModelState.AddModelError(string.Empty, "Invalid login attempt.");
//                 }
//             }
//
//             return View(model); // Return the view with the model if login fails
//         }
//         
//         public IActionResult Logout()
//         {
//             HttpContext.Session.Clear();
//             return RedirectToAction("Index");
//         }
//     }
// }