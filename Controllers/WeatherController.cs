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

namespace weatherMvc.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherMvcDbContext _context;

        public WeatherController(WeatherMvcDbContext context)
        {
            _context = context;
        }


        // GET: searchCity
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
                return RedirectToAction("Index", "weather", new { longitude = model.location_long, latitude = model.location_lat });
            }
            else
            {
                return View(model);
            }
        }

        // GET: Weather
        public async Task<IActionResult> Index(double longitude, double latitude)
        {
            WeatherData ViewModel = new WeatherData();

            WeatherData response = await CallDarkSky(longitude, latitude);

            if (response != null)
            {
                ViewModel.currently = response.currently;
                ViewModel.daily = response.daily;
                ViewModel.flags = response.flags;
                ViewModel.hourly = response.hourly;
                ViewModel.daily.daily_data = response.daily.daily_data;
            }

            return View(ViewModel);
        }

        public async Task<WeatherData> CallDarkSky(double longitude, double latitude)
        {
            WeatherData weather_data = new WeatherData();
            HttpClient httpclient = new HttpClient();
            //LocationData location = new LocationData();

            //LocationData geocode = GetLocationFromGoogle("this").Result;

            string weather_uri = $"https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/{latitude},{longitude}?exclude=minutely,hourly";               //{41.443423},{-81.775168}

            try
            {
                HttpResponseMessage response = await httpclient.GetAsync($"{weather_uri}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                WeatherData deserializedWeather = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                _context.Add(deserializedWeather);

                await _context.SaveChangesAsync();

                return deserializedWeather;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Reach Dark Sky...");
                Console.WriteLine($"Reason: {e}");
                return weather_data;
            }
        }

        public async Task<LocationData> GetLocationFromGoogle(string address)
        {
            LocationData location = new LocationData();
            HttpClient httpClient = new HttpClient();

            // build request string:
             
            string baseUrl = "https://maps.googleapis.com/maps/api/geocode/json?";
            string cityLookup = $"address={address}&region=us&key=YOUR_API_KEY";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl + cityLookup}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                LocationData deserializedLocation = JsonConvert.DeserializeObject<LocationData>(responseBody);

                location = deserializedLocation;

                await _context.SaveChangesAsync();

                return location;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot reach google because {e}");
                return location;
            }
        }
    }
}