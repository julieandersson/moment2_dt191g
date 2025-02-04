using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using moment2_dt191g.Models;

namespace moment2_dt191g.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Läser in trips.json
            string jsonStr = System.IO.File.ReadAllText("trips.json");

            // Deserialiserar JSON
            var trips = JsonSerializer.Deserialize<List<TripModel>>(jsonStr);

            // Skickar en hälsning till vyn via ViewBag
            ViewBag.Message = "Välkommen till resedagboken!";
            // Skickar dagens datum till vyn
            ViewBag.Today = DateTime.Now.ToString("yyyy-MM-dd");

            // Hämtar senaste resan från session och skicka till vyn
            ViewBag.LatestTripLocation = HttpContext.Session.GetString("LatestTripLocation");

            return View(trips); // skickar med listan med resor
        }

        [HttpGet("/omsidan")]
        [HttpGet("/om")]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet("/resor")]
        public IActionResult Trips()
        {
            return View();
        }

        [HttpPost("/resor")]
        public IActionResult Trips(TripModel model)
        {
            if (ModelState.IsValid)
            {
                // Läser in trips.json
                string jsonStr = System.IO.File.ReadAllText("trips.json");

                // Deserialiserar JSON, eller skapa en ny lista om den är null
                var trips = JsonSerializer.Deserialize<List<TripModel>>(jsonStr) ?? new List<TripModel>();

                // Lägg till den nya resan
                trips.Add(model);

                // Serialisera JSON och skriv tillbaka till filen
                jsonStr = JsonSerializer.Serialize(trips);
                System.IO.File.WriteAllText("trips.json", jsonStr);

                // Sparar den senaste resans plats i sessionen
                HttpContext.Session.SetString("LatestTripLocation", $"{model.City}, {model.Country}");

                ModelState.Clear(); // Rensar formulär efter inskick

                return RedirectToAction("Index", "Home"); // Omdirigera till startsidan
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}