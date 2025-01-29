using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using moment2_dt191g.Models;

namespace moment2_dt191g.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/resor")]
    public IActionResult Trips ()
    {
        return View();
    }

    [HttpGet("/omsidan")]
    [HttpGet("/om")]
    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
