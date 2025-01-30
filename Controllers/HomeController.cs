using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using moment2_dt191g.Models;

namespace moment2_dt191g.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/omsidan")]
    [HttpGet("/om")]
    public IActionResult About()
    {
        return View();
    }

    [HttpGet("/resor")]
    public IActionResult Trips ()
    {
        return View();
    }

    [HttpPost("/resor")]
    public IActionResult Trips(TripModel model)
    {
        // Validerar input
        if (ModelState.IsValid)
        {
            // Läser in trips.json
            string jsonStr = System.IO.File.ReadAllText("trips.json");

            // Deserialiserar JSON
            var trips = JsonSerializer.Deserialize<List<TripModel>>(jsonStr);

            // Lägg till ny resa
            if (trips != null)
            {
                trips.Add(model);
            
                // Serialiserar JSON
                jsonStr = JsonSerializer.Serialize(trips);

                // Skriv ändringar till trips.json
                System.IO.File.WriteAllText("trips.json", jsonStr);
            }

            ModelState.Clear(); // Rensar formulär efter inskick
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
