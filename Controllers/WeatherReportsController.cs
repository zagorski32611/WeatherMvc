using System.Linq;
using Microsoft.AspNetCore.Mvc;
using weatherMvc.Data;
using weatherMvc.Models;
using weatherMvc.Interfaces;

namespace weatherMvc.Controllers
{
    public class weatherReportsController : Controller
    {
        private readonly WeatherMvcDbContext _context;

        private readonly IWeatherService _weatherService;
        public weatherReportsController(WeatherMvcDbContext context, IWeatherService weatherService)
        {
            _context = context;
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult sortDays()
        {
            var reportData = new WeatherReport();
            return View(reportData);
        }

        [HttpPost]
        public IActionResult sortDays(WeatherReport weatherReport)
        {
            var listofDays = _context.DailyData
                            .Where(d => d.temperatureMax > 30)
                            .ToList();
            ViewData["days"] = listofDays;

            return View();
        }
    }
}