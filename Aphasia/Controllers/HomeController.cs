using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aphasia.Models;

namespace Aphasia.Controllers;

public class HomeController : Controller
{
    public IActionResult FileView(string file)
    {
        if (string.IsNullOrEmpty(file))
        {
            return NotFound();
        }

        file = file.Replace("-", "");
        ViewData["FileName"] = file;
        string view = $"/views/home/{file}.cshtml";

        return View(view);
    }


    [HttpGet("register")]
    public IActionResult Register()
    {
        return View();
    }

    [HttpGet("login")]
    public IActionResult Login()
    {
        return View();
    }

    [HttpGet("contact")]
    public IActionResult Contact()
    {
        return View();
    }    
    // [HttpGet("aboutus")]
     public IActionResult AboutUs()
    {
        return View();
    }

}