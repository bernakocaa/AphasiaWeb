using Microsoft.AspNetCore.Mvc;

namespace Aphasia.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult FileView(string lang, string file)
        {
            file = file.Replace("-", "");
            ViewData["FileName"] = file;
            string view = $"/views/admin/{file}.cshtml";

            return View(view);
        }
    }   
}
