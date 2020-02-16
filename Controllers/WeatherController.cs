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
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "weather", new {latitude = model.locationLatitude, longitude = model.locationLongitude});
            }
            else
            {
                return View(model);
            }
        }

        // GET: Weather
        public async Task<IActionResult> Index(double latitude, double longitude)
        {
            WeatherData ViewModel = new WeatherData();
            
            WeatherData response = await CallDarkSky(latitude, longitude);

            if(response != null)
            {
                ViewModel.currently = response.currently;
                ViewModel.daily     = response.daily;
                ViewModel.flags = response.flags;
                ViewModel.hourly = response.hourly;
            }
            
            await _context.WeatherData.AddAsync(response);

            return View(ViewModel);
        }

        // GET: Weather/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherData = await _context.WeatherData
                .FirstOrDefaultAsync(m => m.weatherDataId == id);
            if (weatherData == null)
            {
                return NotFound();
            }
            return View(weatherData);
        }

        // GET: Weather/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Weather/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("latitude,longitude,offset,timezone")] WeatherData weatherData)
        {
            WeatherData weather_data = new WeatherData();

            WeatherData response = await CallDarkSky();
            
            weather_data = response;

            if (ModelState.IsValid)
            {
                _context.Add(weather_data);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weather_data);
        }
        */
        // GET: Weather/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!(id is int))
            {
                return NotFound();
            }

            var weatherData = await _context.WeatherData.FindAsync(id);
            if (weatherData == null)
            {
                return NotFound();
            }
            return View(weatherData);
        }

        // POST: Weather/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("latitude,longitude,offset,timezone")] WeatherData weatherData)
        {
            if (id != weatherData.weatherDataId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weatherData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeatherDataExists(weatherData.weatherDataId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(weatherData);
        }

        // GET: Weather/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weatherData = await _context.WeatherData
                .FirstOrDefaultAsync(m => m.weatherDataId == id);
            if (weatherData == null)
            {
                return NotFound();
            }

            return View(weatherData);
        }

        // POST: Weather/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weatherData = await _context.WeatherData.FindAsync(id);
            _context.WeatherData.Remove(weatherData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeatherDataExists(int id)
        {
            return _context.WeatherData.Any(e => e.weatherDataId == id);
        }


        public async Task<WeatherData> CallDarkSky(double latitude, double longitude)
        {
            WeatherData weather_data = new WeatherData();
            
            HttpClient httpclient = new HttpClient();
            
            string weather_uri = $"https://api.darksky.net/forecast/dcd2262dfdbb2349f6e41e54e7a8d40a/{latitude},{longitude}";               //{41.443423},{-81.775168}

            try
            {
                HttpResponseMessage response = await httpclient.GetAsync($"{weather_uri}");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                WeatherData deserializedWeather = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                weather_data = deserializedWeather;

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
    }
}