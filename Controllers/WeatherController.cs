using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using weatherMvc.Data;
using weatherMvc.Models;
using System.Text.RegularExpressions;
using weatherMvc.Interfaces;
using SQLitePCL;

namespace weatherMvc.Controllers
{
    public partial class WeatherController : Controller, ILocationService
    {
        private readonly WeatherMvcDbContext _context;

        private readonly ILocationService _location;

        public WeatherController(WeatherMvcDbContext context)
        {
            _context = context;
        }

        Task<LocationData> ILocationService.LocationSearch(string searchAddress)
        {
            return _location.LocationSearch(searchAddress);
        }

        public void SaveLocationData(LocationData location)
        {
            _location.SaveLocationData(location);
        }

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
                WeatherData weather = CallDarkSky(longitude, latitude).Result;
                ViewData["weatherData"] = weather;
                return View();
            }
            else
            {
                // use LocationService to get location data and save the location object:
                LocationData geocode = _location.LocationSearch(rawAddress).Result;
                _location.SaveLocationData(geocode);

                ViewData["location"] = geocode;

                if (geocode is null)
                {
                    return View("error");
                }
                else
                {
                    double result_lat = geocode.results[0].geometry.location.lat;
                    double result_lng = geocode.results[0].geometry.location.lng;

                    WeatherData weather = CallDarkSky(result_lng, result_lat).Result;

                    ViewData["weatherData"] = weather;

                    return View();
                }
            }
        }

        public async Task<WeatherData> CallDarkSky(double longitude, double latitude)
        {
            WeatherData weather_data = new WeatherData();
            HttpClient httpclient = new HttpClient();

            string weather_uri = $"https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/{latitude},{longitude}?exclude=minutely,hourly";
            // 41.443423,-81.775168

            try
            {
                HttpResponseMessage response = await httpclient.GetAsync($"{weather_uri}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                WeatherData deserializedWeather = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                weather_data = deserializedWeather;

                _context.Add(weather_data);

                await _context.SaveChangesAsync();

                return weather_data;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Reach Dark Sky...");
                Console.WriteLine($"Reason: {e}");
                return weather_data;
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