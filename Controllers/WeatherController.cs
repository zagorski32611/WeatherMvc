using System;
using Microsoft.AspNetCore.Mvc;
using weatherMvc.Data;
using weatherMvc.Models;
using weatherMvc.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace weatherMvc.Controllers
{
    public partial class WeatherController : Controller
    {
        private readonly WeatherMvcDbContext _context;
        private readonly ILocationService _location;
        private readonly IWeatherService _weatherService;

        public WeatherController(WeatherMvcDbContext context, ILocationService location, IWeatherService weatherService)
        {
            _context = context;
            _location = location;
            _weatherService = weatherService;
        }

        // actual controller methods:
        public IActionResult setLocation()
        {
            var ViewModel = new LocationData();
            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult setLocation(LocationData model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "weather", new { longitude = model.searchLng, latitude = model.searchLng, rawAddress = model.searchAddress });
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Index(double longitude, double latitude, string rawAddress = "")
        {
            ViewData["weatherData"] = new WeatherData();
            ViewData["location"] = new LocationData();

            if (rawAddress.Length == 0)
            {
                WeatherData weather = _weatherService.CallDarkSky(longitude, latitude).Result;
                ViewData["weatherData"] = weather;
                return View();
            }
            else
            {
                // use LocationService to get location data and save the location object:
                LocationData geocode = _location.LocationSearch(rawAddress).Result;

                ViewData["location"] = geocode;

                if (geocode is null)
                {
                    return View("error");
                }
                else
                {
                    double result_lat = geocode.results[0].geometry.location.lat;
                    double result_lng = geocode.results[0].geometry.location.lng;

                    WeatherData weather = _weatherService.CallDarkSky(result_lng, result_lat).Result;

                    ViewData["weatherData"] = weather;

                    return View();
                }
            }
        }

        public static DateTime GetDateTime(long unixTimeStamp)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, kind: System.DateTimeKind.Utc);

            long unixTimeStampInTicks = (long)(unixTimeStamp * TimeSpan.TicksPerSecond);

            DateTime dateTime = new DateTime(ticks: unixStart.Ticks + unixTimeStampInTicks, kind: System.DateTimeKind.Utc);
            return dateTime.ToLocalTime();
        }
    }
}